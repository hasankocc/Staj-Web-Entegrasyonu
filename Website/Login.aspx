<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Website.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>KBUSO</title>
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

<div id="ana"> 
<div id="ikon">
<img src="images/kbuso.png" />
</div>
<div id="giris">
<p class="label_kullanici_girisi">KULLANICI GİRİŞİ</p>
    <asp:TextBox ID="txtEposta" placeholder="E-Posta adresi" runat="server" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
    <asp:TextBox ID="txtSifre" Text="Şifre" TextMode="Password" placeholder="Şifre" runat="server" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
<p>
    <asp:Button ID="btnGirisYap" runat="server" CssClass="btn btn_girisyap" Text="Giriş Yap" OnClick="btnGirisYap_Click" />
    <a href="Kaydol.aspx"><input type="button" value="Kayıt Ol" class="btn btn_kaydol" /></a>
</p>
<p id="sifremi_unuttum"><a href="SifremiUnuttum.aspx"><font color="#C9C9C9"><u>Şifremi Unuttum</u></font></a></p>
</div>
</div>

</form>
</body>
</html>
