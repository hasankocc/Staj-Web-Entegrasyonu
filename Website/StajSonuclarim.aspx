<%@ Page Title="" Language="C#" MasterPageFile="~/AnaMaster.Master" AutoEventWireup="true" CodeBehind="StajSonuclarim.aspx.cs" Inherits="Website.StajSonuclarim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <!--page content -->
      <div class="right_col" role="main">
		 <h1>
         <small class="pull-right">Tarih: 16/08/2016</small>
         </h1>
		 <div class="clearfix"></div>
		      <div class="row" style="margin-top:20px;">
              <div class="col-md-12 col-sm-12 col-xs-12">
			  
                <div class="x_panel" >
                  <div class="x_title">
				    <h2><i class="fa fa-info-circle"></i> Bilgi</h2>
                    <ul class="nav navbar-right panel_toolbox">
                    </ul>
					<div class="clearfix"></div>
                  </div> 
                   Yorum ikonuna tıklayarak yetkili akademisyenin stajınız hakkındaki kanaatlerini öğrenebilirsiniz
                  </div>
				  <div class="x_panel" style="height:500px;">
				   <div class="x_title">
				    <h2> Staj Sonuçlarım</h2>
                    <ul class="nav navbar-right panel_toolbox">
                    </ul>			
					<div class="clearfix"></div>
                  </div> 
				  
				  <div class="x_content" style="margin-top:20px;">                    
                    <div class="table-responsive">
                      <table class="table table-striped jambo_table bulk_action">
                        <thead>
                          <tr class="headings">
                            <th class="column-title">Öğrenci No </th>
                            <th class="column-title">Öğrenci Ad</th>
                            <th class="column-title">Öğrenci Soyad</th>
							<th class="column-title">Staj Kodu</th>
                            <th class="column-title">Staj Sonucu</th>
                            <th class="column-title">Tarih </th>
							<th class="column-title no-link last"><span class="nobr">Yorum</span>
                          </tr>
                        </thead>
                        
                        <tbody>

                              <asp:ListView ID="ListStajSonuclarim" runat="server">
                                 <ItemTemplate>
                                    <tr>
                                      <td><%# Eval("Kullanici.ogrenci_no") %></td>
                                      <td><%# Eval("Kullanici.ad") %></td>
                                      <td><%# Eval("Kullanici.soyad") %></td>
                                      <td><%# Eval("staj_kodu") %></td>
                                      <td><%# Eval("staj_sonuc") %></td>
                                      <td><%# Eval("staj_baslangic") %></td>
                                      <td class=" last"><a class="popup"  href="#"><i class="fa fa-external-link" style="margin-left:15px;" ></i></a>		
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
		<div id="CalenderModalNew" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">

          <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
            <h4 class="modal-title" id="myModalLabel">Staj Sonucu</h4>
          </div>
          <div class="modal-body">
            <div id="testmodal" style="padding: 5px 20px;">
              <form id="antoform" class="form-horizontal calender" role="form">
                <div class="form-group">
                  <label class="col-sm-3 control-label">Not</label>
                  <div class="col-sm-9">                  
                      <asp:TextBox ID="not" runat="server" type="number" readonly style="margin:auto; margin-top:-5px;" required="required" CssClass="form-control"></asp:TextBox>
                  </div>
                </div>
                <div class="form-group">
                  <label class="col-sm-3 control-label">Yorum</label>
                  <div class="col-sm-9">        
                    <asp:TextBox id="yorum" TextMode="multiline" CssClass="form-control" Columns="50" readonly  style="resize:none;" Rows="2" runat="server" />
                  </div>
                </div>
              </form>
            </div>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-default antoclose" data-dismiss="modal">Kapat</button>
          </div>
        </div>
      </div>
    </div>
<div id="fc_create" data-toggle="modal" data-target="#CalenderModalNew"></div>
    
        <!-- /page content -->
</asp:Content>
<asp:Content ContentPlaceHolderID="cntntFooter" runat="server">
    <script>
        $(document).ready(function () {
            $('a.popup').click(function () {
                $('#fc_create').click();
            });
        });
            </script>
</asp:Content>
