<%@ Page Title="" Language="C#" MasterPageFile="~/AnaMaster.Master" AutoEventWireup="true" CodeBehind="StajBasvurularim.aspx.cs" Inherits="Website.StajBasvurularim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

         <!-- page content -->
         <div class="right_col" role="main">
		 <h1>
         <small class="pull-right">Tarih: 16/08/2016</small>
         </h1>
		 <div class="clearfix"></div>
		      <div class="row" >
              <div class="col-md-12 col-sm-12 col-xs-12">
			  
                <div class="x_panel" >
                  <div class="x_title">
				    <h2><i class="fa fa-info-circle"></i> Uyarı</h2>
                    <ul class="nav navbar-right panel_toolbox">
                    </ul>
					<div class="clearfix"></div>
                  </div> 
				  Staj dosyası eklemek istediğiniz staj başvurunuzu seçiniz ve staj dosyasını ekleyiniz.Staj dosyasını yükledikten sonra başvuru bilgilerinde düzenleme yapılamaz.
				  Staj dosyalarınızı .docx şeklinde yükleyiniz.Staj dosyalarınız güncellemek istediğinizde tekrar yükleyiniz.Her yüklemede bir önceki staj dosyası silinecektir.
                  </div>
				  <div class="x_panel" style="height:500px;">
				   <div class="x_title">
				    <h2> Staj Başvurularım</h2>
                    <ul class="nav navbar-right panel_toolbox">
                    </ul>			
					<div class="clearfix"></div>
                  </div> 
				  
				  <div class="x_content" style="margin-top:20px;">                    
                    <div class="table-responsive">
                      <table class="table table-striped jambo_table bulk_action">
                        <thead>
                          <tr class="headings">
                            <th>                        
                            </th>
                            <th class="column-title">Öğrenci No </th>
                            <th class="column-title">Öğrenci Ad </th>
                            <th class="column-title">Öğrenci Soyad </th>
							<th class="column-title">Staj Kodu</th>
                            <th class="column-title">Tarih </th>
                            <th class="column-title">Durum </th>
                            <th></th>
                          </tr>
                        </thead>
                        <tbody>

                            <asp:ListView ID="ListStajBasvurularim" runat="server" >
                             <ItemTemplate>
                                    <tr>
                                      <td><asp:CheckBox ID="CheckStajBasvurularim" Text='<%# Eval("staj_id") %>' class="flat"  runat="server" /></td>
                                      <td><%# Eval("Kullanici.ogrenci_no") %></td>
                                      <td><%# Eval("Kullanici.ad") %></td>
                                      <td><%# Eval("Kullanici.soyad") %></td>
                                      <td><%# Eval("staj_kodu") %></td>
                                      <td><%# Eval("staj_baslangic") %></td>
                                      <td><%# Eval("Durum.durum_mesaj") %></td>
                                    </tr>
                              </ItemTemplate>
                            </asp:ListView>

                       </tbody>
                      </table>
                    </div>	

                      <div class="form-group">
                        <div class="col-md-6 col-sm-6 col-xs-12 col-md-offset-3" style="margin:auto; float:left;">
                          <asp:Button ID="btnStajDosyasiEkle" runat="server" CssClass="btn btn-primary" Text="Staj Dosyası Ekle" OnClick="btnStajDosyasiEkle_Click"  />      
                          <asp:Button ID="btnSDuzenle" runat="server" style="width:136px;" CssClass="btn btn-primary" Text="Düzenle"  OnClick="btnSDuzenle_Click"  />      
                        </div>
                      </div>
                  </div>
				  				 				  

				  </div>
                </div>

		
        <!-- /page content -->
         </div>
         </div>
</asp:Content>
