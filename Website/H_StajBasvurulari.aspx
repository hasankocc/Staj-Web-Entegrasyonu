<%@ Page Title="" Language="C#" MasterPageFile="~/H_AnaMaster.Master" AutoEventWireup="true" CodeBehind="H_StajBasvurulari.aspx.cs" Inherits="Website.H_StajBasvurulari" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- page content -->
        <div class="right_col" role="main">
		 <h1>
         <small class="pull-right">Tarih: 16/08/2016</small>
         </h1>
		 <div class="clearfix"></div>
          <div class="" style="height:750px;">
            <div class="clearfix"></div>

            <div class="row" >

              <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel" style="margin-top:auto; height:900px;" >
                  <div class="x_title">
                    <h2>Staj Başvuruları</h2>

                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                    <p class="text-muted font-13 m-b-30">
                      Aşağıdan staj başvurularını seçip işlem yapabilirsiniz.Bir seferde bir staj başvurusu işlemi yapabilirsiniz.
                    </p>
                    <table  id="datatable-checkbox" class="table table-striped table-bordered bulk_action">
                      <thead>
                        <tr>
                          <th></th>
                          <th>Öğrenci No</th>
                          <th>Ad</th>
                          <th>Soyad</th>
                          <th>Staj Kodu</th>
                          <th>Giriş Tarihi</th>
                          <th>Staj Notu</th>
                          <th>Staj Durumu</th>
                        </tr>
                      </thead>

                    
                      <tbody>
                       
                          <asp:ListView ID="listBasvurular" runat="server">
                              <ItemTemplate>
                                    <tr>       
                                      <td><asp:CheckBox  ID="CheckHstaj"  Text='<%# Eval("staj_id") %>' class="flat" runat="server" /></td>
                                      <td><%# Eval("Kullanici.ogrenci_no") %></td>
                                      <td><%# Eval("Kullanici.ad") %></td>
                                      <td><%# Eval("Kullanici.soyad") %></td>
                                      <td><%# Eval("staj_kodu") %></td>
                                      <td><%# Eval("staj_baslangic") %></td>
                                      <td><%# Eval("staj_sonuc") %></td>
                                      <td><%# Eval("Durum.durum_mesaj") %></td>
                                    </tr>
                              </ItemTemplate>
                          </asp:ListView>
                 
                      </tbody>
                    </table>
					<br>
                  </div>
                   
				    <div class="form-group" >
                        <div class="col-md-6 col-sm-6 col-xs-12 col-md-offset-3" style="float:left; margin:auto">
                          <asp:Button ID="btnNotVer" runat="server" CssClass="btn btn_primary" Text="Not Ver" OnClick="btnNotVer_Click"  />                  
                          <asp:Button ID="btnSil" runat="server" style="width:74px;" CssClass="btn btn_primary" Text="Sil" OnClick="btnSil_Click" OnClientClick="return confirm('Staj Başvurusunu Silmek Istediginize Emin Misiniz?');" /> 
                        </div>
                      </div>
				  
                </div>
              </div>
            	  				 
                    
            </div>

          </div>
        </div>
        <!-- /page content -->
</asp:Content>
