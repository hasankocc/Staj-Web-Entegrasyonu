<%@ Page Title="" Language="C#" MasterPageFile="~/H_AnaMaster.Master" AutoEventWireup="true" CodeBehind="H_Dokumanlar.aspx.cs" Inherits="Website.H_Dokumanlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- page content -->
        <div class="right_col" role="main">
		 <h1 >
         <small class="pull-right">Tarih: 16/08/2016</small>
         </h1>
		      <div class="row" style="margin-top:115px;">
               <div class="col-md-12 col-sm-12 col-xs-12">
			    
				<div class="x_panel" >
                  <div class="x_title">
				    <h2><i class="fa fa-info-circle"></i> Bilgi</h2>
                    <ul class="nav navbar-right panel_toolbox">
                    </ul>
					<div class="clearfix"></div>
                  </div> 
				  Form1,Form2,Form3 belgelerini indirebilirsiniz
                  </div>
				
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
                        <td>  <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Form1</asp:LinkButton>  </td>
                        </tr>
                      </thead>
                      <tbody>                         
                        <tr>
                           <td scope="row"> <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Form2</asp:LinkButton> </td>
                        </tr>
                        <tr>
                          <td scope="row"> <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Form3</asp:LinkButton> </td>
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
