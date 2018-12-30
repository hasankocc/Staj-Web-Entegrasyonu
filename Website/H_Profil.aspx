<%@ Page Title="" Language="C#" MasterPageFile="~/H_AnaMaster.Master" AutoEventWireup="true" CodeBehind="H_Profil.aspx.cs" Inherits="Website.H_Profil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- page content -->
        <div class="right_col" role="main"  >
          <div class="" >
            <div class="page-title">
              <div class="title_left">
                <h3>Kullanıcı Profili</h3>
              </div>

            </div>
            
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
				   Belirli aralıklarla şifrenizi güncellemeyi unutmayınız.
                  </div>
            <div class="row">
              <div class="col-md-6 col-xs-12" >
                <div class="x_panel" style="height:auto;">
                  <div class="x_title">
                    <h2>Profil Detay
                    </h2>
                    <ul class="nav navbar-right panel_toolbox">
                    </ul>
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                    <br />
                    <form class="form-horizontal form-label-left input_mask">
                      




                  <div class="x_content">
                    <div class="col-md-3 col-sm-3 col-xs-12 profile_left">
                      <div class="profile_img">
                        <div id="crop-avatar">
                          <!-- Current avatar -->                        
                          <asp:Image ID="Image1" runat="server" src="images/user.png" CssClass="img-responsive avatar-view" title="Change the avatar"  />
                        </div>
                      </div>
                      <h3><asp:Label ID="Labeladsoy" runat="server"></asp:Label></h3>

                      <ul class="list-unstyled user_data">
                        <li><asp:Label ID="labelOgrno" runat="server" ></asp:Label></li>
                        <li><asp:Label ID="labelBolum" runat="server" ></asp:Label></li>
						<li><asp:Label ID="labelEposta" runat="server"></asp:Label></li>
                      </ul>  

                    </div>
                    <div class="col-md-9 col-sm-9 col-xs-12">              
                    </div>

                  </div>


                    </form>
                  </div>
                </div>




              </div>

              <div class="col-md-6 col-xs-12" >
                <div class="x_panel" style="height:auto;">
                  <div class="x_title">
                    <h2>Şifre Değiştir</h2>
                    <ul class="nav navbar-right panel_toolbox">
                    
                    </ul>
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                    <br />
                      <p>
                          Eski Şifre  
                          <asp:TextBox ID="eskiSifre" runat="server" type="password"  required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                          
                      </p>
                       <p>
                            Yeni Şifre
                            <asp:TextBox ID="yeniSifre" runat="server" type="password"  required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
                       </p>
   					    <p>
                           
                            Şifre Doğrula
                            <asp:TextBox ID="sifreDogrula" runat="server" type="password"  required="required" CssClass="form-control col-md-7 col-xs-12"></asp:TextBox>
						</p> 
                     
                      <br />
                      <br />
                      <asp:Button ID="btnDegistir" runat="server" CssClass="btn btn-success" Text="Degistir" OnClick="btnDegistir_Click" />
                  </div>
                </div>
              </div>

            </div>
                </div>
              </div>
          </div>
        </div>

        <!-- /page content -->

</asp:Content>
