<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ek1.aspx.cs" Inherits="Website.Ek1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<META http-equiv=content-type content=text/html;charset=x-mac-turkish>
</head>
<body>
    <form id="form1" runat="server">
<div>
<font face="Times New Roman" size="-1" color="#686868">Bölüm ve Dekanlıkça imzalı belgeler Bölüm Sekreterliğinden teslim alınacak ve ilgili Fabrikaya verilecektir.</font> 
<font><b>Ek–1</b></font>

<br />


   
<table border="0.5"  style="height:auto; width:auto;">
<asp:ListView ID="ListVw" runat="server">
    <ItemTemplate>
<tr>
<td>
<img src="images/kbu1.png" />
    

    <br /><br />

    							      
 Konu: Endüstri Stajı         <font color="white">eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee</font>           Tarih: 
    <br />
    <br />
    <br />

…………………………………………………………………………………………………....……….<br /><br /><br /><br />

Fakültemiz <%# Eval("Bolum.bolum_adi") %> Bölümü  <%# Eval("ogrenci_no") %> numaralı <%# Eval("ad") %> <%# Eval("soyad") %> adlı öğrencimiz , 20 iş günü staj yapmakla zorunludur. Staj sigorta primi Üniversitemiz tarafından yatırılacaktır. <br /><br />

İş yerinizde staj yapması uygun görüldüğü takdirde Staj İşyeri Kabul Belgesinin doldurularak <br />Fakültemize elden yada  posta ile gönderilmesi için gereğini saygıyla rica ederiz.<br /><br /><br /><br /><br /><br />




<font color="white">eeeeeeeeeee</font>Bölüm	<font color="white">eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee</font>Dekanlık
    <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
    <br />
    

</td>
</tr>
        </ItemTemplate>
     </asp:ListView>
</table>

   <!-- <asp:GridView ID="gv" runat="server" />-->
</div>
    </form>
</body>
</html>
