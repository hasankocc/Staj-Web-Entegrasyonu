<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kaydol.aspx.cs" Inherits="Website.Kaydol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>KBUSO</title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>

<link rel="shortcut icon" href="images/krbkmin.png"/>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"/>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap-theme.min.css"/>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="css/krbk-stylesheet.css"/>
</head>
<body>
<form id="form1" runat="server">
<body style="background-color:#373547;">

<div id="ana" > 
<p class="k_label_kullanici_girisi">KAYIT OL</p>
<asp:TextBox ID="txtTckimlikno" runat="server" type="number" style="margin-top:25px; width:275px;" placeholder="T.C. Kimlik No"  required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
<asp:TextBox ID="txtOgrencino" runat="server" type="number" style="margin-top:75px; margin-left:-275px; width:275px;" placeholder="Öğrenci No"  required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
<asp:TextBox ID="txtAd" runat="server" type="text" style="margin-top:125px; margin-left:-275px; width:275px;" placeholder="Ad" required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
<asp:TextBox ID="txtSoyad" runat="server" type="text" style="margin-top:175px; margin-left:-275px; width:275px;" placeholder="Soyad" required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
<asp:TextBox ID="txtEposta" runat="server" style="margin-top:25px; margin-left:100px; width:275px;" required="required" placeholder="E-Posta Adresi" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
<asp:TextBox ID="txtSifre" type="password" runat="server" style="margin-top:8px; margin-left:100px; width:275px;" required="required" placeholder="Şifre" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
<asp:TextBox ID="txtsif" type="password" runat="server" style="margin-top:5px; margin-left:100px; width:275px;" required="required" placeholder="Şifre Tekrar" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>

<asp:DropDownList ID="DDBolum"  
    runat="server"  
    AutoPostBack="true"   CssClass="form-control col-md-7 col-xs-12" style="width:275px; margin-left:100px; margin-top:5px;">  
    <asp:ListItem Value="Bilgisayar Mühendisliği"></asp:ListItem>  
    <asp:ListItem Value="Biyomedikal Mühendisliği"></asp:ListItem>  
    <asp:ListItem Value="Çevre Mühendisliği"></asp:ListItem>  
    <asp:ListItem Value="Elektrik Elektronik Mühendisliği"></asp:ListItem>  
    <asp:ListItem Value="Endüstri Mühendisliği"></asp:ListItem>   
    <asp:ListItem Value="İnşaat Mühendisliği"></asp:ListItem> 
    <asp:ListItem Value="Kimya Mühendisliği"></asp:ListItem> 
    <asp:ListItem Value="Makine Mühendisliği"></asp:ListItem> 
    <asp:ListItem Value="Mekatronik Mühendisliği"></asp:ListItem>   
    <asp:ListItem Value="Metalurji ve Malzeme Mühendisliği"></asp:ListItem>   
    <asp:ListItem Value="Tıp Mühendisliği"></asp:ListItem>  
</asp:DropDownList> 

    <asp:Button ID="btnKaydol" runat="server" CssClass="btn btn_girisyap" Text="Kayıt Ol" OnClick="btnKaydol_Click" style="margin-left:-30px; margin-top:70px; " />  
</div>
    </body>
    </form>
</body>
</html>
