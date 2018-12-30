<%@ Page Title="" Language="C#" MasterPageFile="~/H_AnaMaster.Master" AutoEventWireup="true" CodeBehind="H_Anasayfa.aspx.cs" Inherits="Website.H_Anasayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- page content -->
        <div class="right_col" role="main">
        <div class="">
		 <h1>
         <small class="pull-right">Tarih: 16/08/2016</small>
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
				  Aşağıda öğrencilerin staj yapamayacağı tarihleri seçebilirsiniz.Takvimdeki tarihlerden birini seçerek ekleme işlemi yapabilir , listede bulunan tarihlerden birini de seçip silebilirsiniz.
                  </div>
            <div class="row">
              <div class="col-md-6 col-xs-12" >
                <div class="x_panel" style="height:auto;">
                  <div class="x_title">
                    <h2>Resmi Tatil Günlerini Ayarla</h2>
                    <ul class="nav navbar-right panel_toolbox">
                    </ul>
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                    <br />
                    <form class="form-horizontal form-label-left input_mask">


					  <div class="row calendar-exibit">

                      <div class="col-md-9">
                          <asp:Calendar ID="Calendar1" runat="server" ></asp:Calendar>
                       <%-- <fieldset>
                          <div class="control-group">
                            <div class="controls">
                              <div class="col-md-11 xdisplay_inputx form-group has-feedback">
                                <input type="text" class="form-control has-feedback-left" id="single_cal2" placeholder="First Name" aria-describedby="inputSuccess2Status2">
                                <span class="fa fa-calendar-o form-control-feedback left" aria-hidden="true"></span>
                                <span id="inputSuccess2Status2" class="sr-only">(success)</span>
                              </div>
                            </div>
                          </div>
                        </fieldset>--%>
                      </div>

                    </div>
					
					
                      <div class="ln_solid"></div>
                      <div class="form-group">
                        <div class="col-md-9 col-sm-9 col-xs-12 col-md-offset-3">
                          <asp:Button ID="btnSil" runat="server" Text="Sil" CssClass="btn btn_primary" OnClick="btnSil_Click" style="float:right;" />
                          <asp:Button ID="btnTamamla" runat="server" style="float:right;" CssClass="btn btn_primary" Text="Ekle" OnClick="btnTamamla_Click"  />                  
                        </div>
                      </div>

                    </form>
                  </div>
                </div>




              </div>

              <div class="col-md-6 col-xs-12" >
                <div class="x_panel" style="height:auto;">
                  <div class="x_title">
                    <h2>Kayıtlı Tarihler</h2>
                    <ul class="nav navbar-right panel_toolbox">
                    
                    </ul>
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                    <br />
            <table  id="datatable-checkbox" class="table table-striped table-bordered bulk_action">
                      <thead>
                        <tr>
                          <th>Tarih</th>
                        </tr>
                      </thead>
                    
                <tbody>
                  <asp:ListView ID="ListView1" runat="server">
                       <ItemTemplate>
                                    <tr>       
                                      <td><%# Eval("tarih1") %></td>
                                    </tr>
                       </ItemTemplate>
                  </asp:ListView>
                </tbody>
            </table>

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
