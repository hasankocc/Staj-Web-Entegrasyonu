<%@ Page Title="" Language="C#" MasterPageFile="~/H_AnaMaster.Master" AutoEventWireup="true" CodeBehind="H_StajSonucu.aspx.cs" Inherits="Website.H_StajSonucu" %>
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
				  Staj Dosyalarına G(eçti) ve K(aldı) harflerini kullanarak not veriniz.Kalan öğrencilerin kalma sebebini yorum satırına yazınız
                  </div>
				
				<div class="x_panel" style="height:470px;">
                   <div class="x_title">
				    <h2> Staj Sonucu</h2>
                    <ul class="nav navbar-right panel_toolbox">
                    </ul>			
					<div class="clearfix"></div>
                   </div>
				 <div class="x_content" style="margin-top:20px;">
                  <p><asp:Label ID="LabelOgrNo" runat="server"></asp:Label></p>
				  <p><asp:Label ID="LabelBolum" runat="server"></asp:Label></p>
                  <p><asp:Label ID="LabelAdsoy" runat="server" ></asp:Label><p>
				  <p></p>
                  </div>
				      <div id="demo-form2" data-parsley-validate class="form-horizontal form-label-left" style="margin-top:40px;">
					 <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12">Final Notu </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">                         
                          <asp:TextBox ID="finalnotu" runat="server" type="number"  required="required" placeholder="Etki Oranı %100" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12">Yorum </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <asp:TextBox id="yorum" TextMode="multiline" CssClass="form-control" Columns="50" placeholder="Max. 100 karakter" style="resize:none;" Rows="3" runat="server" />
                        </div>
                      </div>
					<div class="ln_solid" style="width:940px; margin-left:45px; margin-top:40px;"></div>
                      <div class="form-group" style="margin-left:460px; margin-top:30px;">
                        <div class="col-md-6 col-sm-6 col-xs-12 col-md-offset-3">                        
                          <asp:Button ID="btnNotVer" runat="server" CssClass="btn btn_success" Text="Not Ver" OnClick="btnNotVer_Click"  /> 
						  <asp:Button ID="btnIptal" runat="server" CssClass="btn btn_primary" Text="İptal Et" OnClick="btnIptalEt_Click"  /> 
                        </div>
                      </div>	
                  </div>				  
                </div>
			   </div>
              </div>
        </div>	
		
        <!-- /page content -->


</asp:Content>
