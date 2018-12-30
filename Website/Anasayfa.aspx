<%@ Page Title="" Language="C#" MasterPageFile="~/AnaMaster.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="Website.Anasayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="right_col" role="main">
		 <h1>
         <small class="pull-right">Tarih: <asp:Label ID="lblTarihBilgisi" runat="server"></asp:Label></small>
         </h1>
		 <div class="clearfix"></div>
		      <div class="row" style="margin-top:20px;">
              <div class="col-md-12 col-sm-12 col-xs-12">
			  
                <div class="x_panel" >
                  <div class="x_title">
				    <h2><i class="fa fa-info-circle"></i> Uyarı</h2>
                    <ul class="nav navbar-right panel_toolbox">
                    </ul>
					<div class="clearfix"></div>
                  </div> 
				  Tek bir başvuru hakkınız vardır.Başvuru yaptıysanız mevcut başvurunuzda değişikliğe gidiniz.Yeni başvuru yaparken yapacağınız başvuruyu önce Taslak olarak kaydedin daha sonra emin olduktan sonra başvuruyu tamamlaya tıklayınız.Aksi takdirde başvurunuzu düzenleyemezsiniz
                  </div>
				  <div class="x_panel" style="height:500px;">
				   <div class="x_title">
				    <h2> Mevcut Başvurular</h2>
                    <ul class="nav navbar-right panel_toolbox">
                    </ul>			
					<div class="clearfix"></div>
                  </div> 
				  
				  <div class="x_content" style="margin-top:20px;">                    
                    <div class="table-responsive">
                      <table class="table table-striped jambo_table bulk_action">
                        <thead>
                          <tr class="headings">
                            <th></th>
                            <th class="column-title">Öğrenci No </th>
                            <th class="column-title">Öğrenci Ad </th>
                            <th class="column-title">Öğrenci Soyad </th>
							<th class="column-title">Staj Kodu</th>
                            <th class="column-title">Başlangıç Tarih </th>
                            <th class="column-title">Durum </th>
                            <th></th>
                          </tr>
                        </thead>

                        <tbody>
                            <asp:ListView ID="ListAnasayfa" runat="server">
                              <ItemTemplate>
                                    <tr>       
                                      <td></td>                              
                                      <td><%# Eval("Kullanici.ogrenci_no") %></td>
                                      <td><%# Eval("Kullanici.ad") %></td>
                                      <td><%# Eval("Kullanici.soyad") %></td>
                                      <td><%# Eval("staj_kodu") %></td>
                                      <td><%# Eval("staj_baslangic") %></td>
                                      <td><%# Eval("Durum.durum_mesaj") %></td>
                                    </tr>
                              </ItemTemplate>
                            </asp:ListView>
						  <tbody>

						  </table>
						  </div>
						  </div>
						  
				      <a href="BasvuruSayfasi.aspx"><button type="button" class="btn btn-dark"  >Yeni Başvuru</button></a> 
                      <asp:Button ID="btnPdf" class="btn btn-dark" runat="server" Text="Başvuru Belgesi indir" OnClick="btnPdf_Click" />
                       </div>
                </div>
              </div>
        </div>	
</asp:Content>
