using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Website
{
    public partial class PDFOlustur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            iTextSharp.text.Document dosya = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
            MemoryStream cikti = new MemoryStream();
            iTextSharp.text.pdf.PdfWriter.GetInstance(dosya, cikti);
            dosya.Open();
            dosya.Add(new iTextSharp.text.Paragraph("Deneme"));
            dosya.Close();
            Response.Clear();
            Response.AddHeader("content-disposition", "attachment;filename=Export.pdf");
            Response.ContentType = "application/pdf";
            Response.BinaryWrite(cikti.ToArray());
            Response.End();
        }
    }
}