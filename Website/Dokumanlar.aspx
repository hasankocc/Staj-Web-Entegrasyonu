<%@ Page Title="" Language="C#" MasterPageFile="~/AnaMaster.Master" AutoEventWireup="true" CodeBehind="Dokumanlar.aspx.cs" Inherits="Website.Dokumanlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="right_col" role="main">
		 <h1 >
         <small class="pull-right">Tarih: 16/08/2016</small>
         </h1>
		      <div class="row" style="margin-top:115px;">
               <div class="col-md-12 col-sm-12 col-xs-12">
			    <div class="x_panel" style="height:470px;">
                   <div class="x_title">
				    <h2> Dökümanlar</h2>
                    <ul class="nav navbar-right panel_toolbox">
                    </ul>			
					<div class="clearfix"></div>
                   </div>
				 <div class="x_content" style="margin-top:20px;">

                    <table class="table">
                      <thead>
                        <tr>
                          <td>
                          <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">-Staj Dosyası</asp:LinkButton></td>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td scope="row">
                           <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">-Form1(Firmaya teslim edilecek belge)</asp:LinkButton></td>
                        </tr>
                        <tr>
                          <td scope="row">
                          <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">-Fom2</asp:LinkButton></td>
                        </tr>
						
                      </tbody>
                    </table>

                  </div>
                </div>
			   </div>
              </div>
        </div>	
		
        <!-- /page content -->
</asp:Content>
