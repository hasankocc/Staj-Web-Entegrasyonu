<%@ Page Title="" Language="C#" MasterPageFile="~/AnaMaster.Master" AutoEventWireup="true" CodeBehind="BasvuruSayfasi.aspx.cs" Inherits="Website.BasvuruSayfasi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- page content -->
        <div class="right_col" role="main">
		 <h1>
         <small class="pull-right">Tarih: 16/08/2016</small>
         </h1>
		   <div class="">
		 <div class="clearfix"></div>

		      <div class="row" style="height:1500px;" >
              <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel" >
                  <div class="x_title">
                    <h2>Başvuru Sayfası</h2>
                    <ul class="nav navbar-right panel_toolbox">

                    </ul>
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                    <br />
                    <div id="demo-form2" data-parsley-validate class="form-horizontal form-label-left">

                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name">Firma Adı <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                        <asp:TextBox ID="firmadi" runat="server" type="text"  required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="last-name">Telefon veya Fax <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          
                          <asp:TextBox ID="tel" runat="server" type="number"  required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>
                     <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12">Yetkili Ad Soyad<span class="required">*</span></label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          
                          <asp:TextBox ID="yetkiliadsoy" runat="server" type="text"  required="required"  CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>
                       <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12">Yetkili Mevki<span class="required">*</span></label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          
                          <asp:TextBox ID="yetkilimevki" runat="server" type="text"  required="required"  CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>
                      <div class="form-group">
                        <label for="middle-name" class="control-label col-md-3 col-sm-3 col-xs-12">Yetkili Kişi Email<span class="required">*</span></label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          
                          <asp:TextBox ID="email" runat="server" type="text"  required="required" placeholder="birisi@example.com" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>
  
					 <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Adres <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">         
                          <asp:TextBox id="adres" TextMode="multiline" CssClass="form-control" Columns="50" placeholder="Max. 100 karakter" style="resize:none;" Rows="3" runat="server" />
                        </div>
                      </div>
					  
					  
                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="last-name">Çalışan Eleman Sayısı 
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <asp:TextBox ID="calisanelemansayisi" runat="server" type="number"  ontextchanged="TextBox1_TextChanged" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>

                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="last-name">Lisans Mezunu Personel Sayısı 
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox ID="lisanspersonelsayisi" runat="server" type="number"   CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>

                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="last-name">Bölümde Çalışan Mühendis Sayısı 
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:TextBox ID="muhendissayisi" runat="server" type="number"  CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>

                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="last-name">Staj Öğrencisi Kontenjanı 
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <asp:TextBox ID="stajkontenjani" runat="server" type="number"   CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>

                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="last-name">Makine Parkı 
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox ID="makineparki" runat="server" type="number"  CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>					  
					  
					  <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="last-name">Sosyal Hizmetler(yemek,servis vs) 
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <asp:TextBox ID="sosyalhizmetler" runat="server" type="text"  CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                        </div>
                      </div>	
					  
					 <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12">Eklemek istedikleriniz 
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <asp:TextBox id="eklemekistedikleriniz" TextMode="multiline" CssClass="form-control" Columns="50"  style="resize:none;" Rows="3" runat="server" />
                        </div>
                      </div>
					  <div class="form-group">
                        <label class="col-md-3 col-sm-3 col-xs-12 control-label">Staj günlerine cumartesi dahildir
                        </label>

                        <div class="col-md-9 col-sm-9 col-xs-12">
                          <div class="checkbox">
                            <label>                         
                                <asp:CheckBox ID="cmrtesidahildir" runat="server"></asp:CheckBox>
                            </label>
                          </div>
                        </div>
                      </div>
					  

                      <div class="form-group">
                        <label class="col-md-3 col-sm-3 col-xs-12 control-label">Staj yapılacak tarih aralığı
                        </label>
						<div class="col-md-9 col-sm-9 col-xs-12">                            
                         <asp:Calendar ID="calBaslangic" runat="server" OnSelectionChanged="calBaslangic_SelectionChanged"></asp:Calendar>  ile  <asp:Calendar ID="calBitis" runat="server" OnSelectionChanged="calBitis_SelectionChanged"></asp:Calendar>
						 </div>
                      </div>
		              <div class="form-group">
                        <asp:Label ID="lbl_staj_gun_sayisi"  CssClass="col-md-9 col-sm-9 col-xs-12 control-label"  Text="0" runat="server"></asp:Label>
					   </div>
					  	 <div class="form-group">			 
                        <label class="col-md-9 col-sm-9 col-xs-12 control-label"><b><font color="red">*Not:</font></b><font color="black">Tarih aralığını ayarlarken bayram günlerini ve cumartesi günlerini dikkate alınız!</font>
                        </label>
					  	 </div>
						 <br>
                      <div class="ln_solid"></div>
                      <div class="form-group">
                        <div class="col-md-6 col-sm-6 col-xs-12 col-md-offset-3"> 
                          <asp:Button ID="btnTaslakKaydet" runat="server" CssClass="btn btn_primary" Text="Taslak Kaydet" OnClick="btnTaslakKaydet_Click"  />                        
                          <asp:Button ID="btnBasvuruTamamla" runat="server" CssClass="btn btn_primary" Text="Başvuruyu Tamamla" OnClick="btnBasvuruTamamla_Click"  />                  
                          <asp:Button ID="btnIptal" runat="server" CssClass="btn btn_primary" Text="İptal Et" OnClick="btnIptalet_Click"  /> 
                        </div>
                      </div>

                    </div>
                  </div>
                </div>
              </div>
            </div>
		
        <!-- /page content -->


    </div>
</asp:Content>
