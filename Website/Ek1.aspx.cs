using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Text.RegularExpressions;
using BLL;

namespace Website
{
    public partial class Ek1 : System.Web.UI.Page
    {
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        public string RelativeToAbsoluteURLS(string text)
        {
            if (String.IsNullOrEmpty(text))
                return text;

            string absoluteUrl = Request.PhysicalApplicationPath;
            String value = Regex.Replace(text, "<(.*?)(src)=\"(?!http)(.*?)\"(.*?)>", "<$1$2=\"" + absoluteUrl + "$3\"$4>", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            return value.Replace(absoluteUrl + "/", absoluteUrl);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            BLL.Kullanici blKullanici = new BLL.Kullanici();
            object kullanici = Session["KullaniciAdi"];
            string temp = Convert.ToString(kullanici);
            if (kullanici == null)
            {
                Response.Write("<script>alert('Oturum Süreniz Geçmiş!');</script>");
                System.Threading.Thread.Sleep(1000);
                Server.Transfer("Login.aspx");
            }
            
            if (!IsPostBack)
            {
                ListVw.DataSource = blKullanici.ListeGetir(temp);
                ListVw.DataBind();
            }

            //gridview için:
            //IEnumerable<int> data = Enumerable.Range(1, 4);
            //gv.DataSource = data;
            //gv.DataBind();

            Page p = new Page();
            HtmlForm f = new HtmlForm();
            f.Controls.Add(form1);
            p.Controls.Add(f);
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            f.Controls[0].RenderControl(htw);
            string content = sw.ToString();



            Document doc = new Document(iTextSharp.text.PageSize.A4);
            MemoryStream output = new MemoryStream();
            PdfWriter.GetInstance(doc, output);
            doc.Open();


           
            
            
            content = RelativeToAbsoluteURLS(content);
            List<IElement> dizi = HTMLWorker.ParseToList(new StringReader(content), null);

            foreach (var item in dizi)
                doc.Add(item);

            



            Phrase phrase = new Phrase(Environment.NewLine);
            doc.Add(phrase);


            

            BaseFont STF_Helvetica_Turkish = BaseFont.CreateFont("Helvetica", "CP1254",BaseFont.NOT_EMBEDDED);
            Font fontNormal = new Font(STF_Helvetica_Turkish, 9, Font.NORMAL,BaseColor.DARK_GRAY); 
            fontNormal.SetFamily("Arial");
            Anchor anc = new Anchor("Karabük Üniversitesi, Mühendislik Fakültesi, Kampüs,  KARABÜK, Tel: (0 370)  433 20 21, Faks: (0 370)  433 32 90", fontNormal);
            doc.Add(anc);
            //doc.Add(new Paragraph("bu bir paragraftır :)"));
            //doc.Add(new Anchor("http://www.da.name.tr"));

            doc.Close();







            doc.Close();
            Response.Clear();
            // tarayıcıda göstermek için:
            Response.AddHeader("content-disposition", "inline;filename=Ek1.pdf;");
            // download ettirmek için:
            Response.ContentType = "application/pdf";
            Response.BinaryWrite(output.ToArray());
            Response.End();
        }
    }
}