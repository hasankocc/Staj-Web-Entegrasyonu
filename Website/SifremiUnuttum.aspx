<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SifremiUnuttum.aspx.cs" Inherits="Website.SifremiUnuttum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Şifremi Unuttum</title>

     <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

<link rel="shortcut icon" href="images/krbkmin.png">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap-theme.min.css">
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="css/krbk-stylesheet.css">

</head>
<body>
    <form id="form1" runat="server">
<body style="background-color:#373547;">

<div id="ana" > 
<div id="ikon">
<img src="images/kbuso.png" />
</div>
<div id="sifremiunuttum_giris">

<p class="label_kullanici_girisi">Şifremi Unuttum</p>
<p id="label_kullanici_girisi">TC Kimlik Numaranızı giriniz</p>
<asp:TextBox ID="txtTCNo" placeholder="TC Kimlik Numarası" type="number" runat="server" required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
<p>
   <asp:Button ID="btnSifremiUnuttum" runat="server" CssClass="btn btn_girisyap" Text="Gönder" OnClick="btnSifremiUnuttum_Click" />
</p>
    <p>
        <asp:Label ID="lblUyari" runat="server" ForeColor="White"></asp:Label>
    </p>
</div>
</div>

</body>
    </form>
</body>
</html>
