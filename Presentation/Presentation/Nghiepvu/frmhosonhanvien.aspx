<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmhosonhanvien.aspx.cs" Inherits="Presentation.Nghiepvu.frmhosonhanvien" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div id="main">
    <div id="head">
        <b>HỒ SƠ NHÂN VIÊN</b>
    </div>
    <div id="left" class ="lou" style="width: 335px">
        <div class="lou">
        <table >
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Tìm kiếm" Width="100%" ></asp:Label></td>
                <td><asp:DropDownList ID="timkiem" runat="server" Width="100%"> </asp:DropDownList></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Từ khoá" Width="100%"></asp:Label></td>
                <td><asp:TextBox ID="tukhoa" runat="server" Width="150px"></asp:TextBox></td>
            </tr>
        </table>
        </div>
        <br />
        <div class="lou" style="overflow:scroll; vertical-align:middle baseline; width:335px; height:335px" >
            <asp:GridView ID="danhsachnhanvien" runat="server" OnRowDataBound="danhsachnhanvien_RowDataBound"  
                                        OnSelectedIndexChanged="danhsachnhanvien_SelectedIndexChanged" AutoGenerateColumns="False" 
                                CellPadding="4" ForeColor="#333333" Width="360px" Height ="100%" ShowHeader="False">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField HeaderText = "STT" ItemStyle-Width="10px">
                                    <ItemTemplate>
                                        <asp:Label ID="lblRowNumber" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                                    </ItemTemplate> 
                                    <ItemStyle Width="10px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                                </asp:TemplateField>
                                <asp:CommandField ShowSelectButton="True" ItemStyle-Width="20px" />
                                <asp:BoundField DataField="manv" ItemStyle-Width="50px"  />
                                <asp:BoundField DataField="tennv" ItemStyle-Width="300px" >
                                <ItemStyle Width="320px" />
                                </asp:BoundField>
                            </Columns>
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
        </div>

    </div>
    <div id="content">
        <div class="lou">
            <table style="width:100%; font-size:small; font-weight:normal">
                <tr>
                    <td style="vertical-align :top">
                        <table>
                            <tr>
                                <td><asp:FileUpload ID="loadhinh" runat="server" Width="90%" /></td>
                                        
                            </tr>
                            <tr>
                                <td><asp:Button ID="uphinh" runat="server" Text="Cập nhật hình" OnClick="uphinh_Click" /></td>
                            </tr>
                        </table>
                    </td>
                    <td style="vertical-align:top central" class="auto-style1">
                        <asp:Image ID="hinhnhanvien" runat="server" Width="95px" Height="100px" CssClass="lou"/>
                    </td>
                </tr>
            </table>

        </div>
        <br />
        <div style="overflow:scroll;  width:101%; vertical-align:top">
                <div class="lou">
                    <table style="width:100%">
                        <tr >
                            <td style="width:95px;">
                                <asp:Label ID="Label5" runat="server" Text="Họ và tên" Width="90px" ></asp:Label>
                            </td>
                            <td style="width:195px">
                                <asp:TextBox ID="hovaten" runat="server" Width="100px"></asp:TextBox>
                            </td>
                            <td class="rw1">
                                <asp:Label ID="Label4" runat="server" Text="Mã nhân viên" Width="90px" ></asp:Label>
                            </td>
                            <td class="rw">
                                <asp:TextBox ID="manhanvien" runat="server" ReadOnly="true" Width="90px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 90px" >
                                <asp:Label ID="Label11" runat="server" Text="Ngày sinh" Width="90px"></asp:Label>
                            </td>
                            <td style="width: 195px">
                                <asp:TextBox ID="ngaysinh" runat="server" Width="100px"></asp:TextBox>
                            </td>
                            <td class="rw1">
                                <asp:Label ID="Label10" runat="server" Text="Giới tính" Width="90px"></asp:Label>
                            </td>
                            <td class="rw1">
                                <asp:DropDownList ID="gioitinh" Width="100px" runat="server" >
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 90px">
                                <asp:Label ID="Label12" runat="server" Text="Quê quán" Width="90px"></asp:Label>
                            </td>
                            <td style="width: 195px">
                                <asp:TextBox ID="noisinh" runat="server" Width="100px"></asp:TextBox>
                            </td>
                            <td class="rw1">
                                <asp:Label ID="Label15" runat="server" Text="Dân tộc" Width="90px"></asp:Label>
                            </td>
                            <td class="rw1">
                                <asp:DropDownList ID="dantoc" Width="100px" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label13" runat="server" Text="Số CMND" Width="90px"></asp:Label>
                            </td>
                            <td >
                                <asp:TextBox ID="CMND" Width="100px" runat="server"></asp:TextBox>
                            </td>
                            <td class="rw1">
                                <asp:Label ID="Label16" runat="server" Text="Tôn giáo" Width="100px"></asp:Label>
                            </td>
                            <td class="rw1">
                                <asp:DropDownList ID="tongiao" Width="100px" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 95px">
                                <asp:Label ID="Label29" runat="server" Text="Thường trú" Width="90px"></asp:Label>
                            </td>
                            <td style="width: 195px">
                                <asp:TextBox ID="choohientai" runat="server" Width="100px" ></asp:TextBox>
                            </td>
                            <td class="rw1">
                                <asp:Label ID="Label8" runat="server" Width="90px" Text="Trình độ"></asp:Label>
                            </td>
                            <td class="rw1">
                                <asp:DropDownList ID="matrinhdo" Width="100px" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label19" runat="server" Text="Điện thoại" Width="100px"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="dienthoai" runat="server" Width="100px"></asp:TextBox>
                            </td>
                            <td class="rw1">
                                <asp:Label ID="Label9" runat="server" Width="90px" Text="Chuyên môn"></asp:Label>
                            </td>
                            <td class="rw1">
                                <asp:DropDownList ID="machuyenmon" Width="100px" runat="server">
                                </asp:DropDownList>

                            </td>
                        </tr>
                        <tr>
                            <td >
                                &nbsp;</td>
                            <td >
                                &nbsp;</td>
                            <td class="rw1">
                                <asp:Label ID="Label14" runat="server" Text="Gia đình" Width="90px"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="giadinh" Width="100px" runat="server" >
                                    <asp:ListItem Value="0">Chưa có gia đình</asp:ListItem>
                                    <asp:ListItem Value="1">Có gia đình</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                </table>
                </div>
                <br />
                <div class="lou"> 
                <table style="width: 100%">
                    <tr>
                        <td class="rw1">
                            <asp:Label ID="Label24" runat="server" Text="Loại HĐ" Width="100%"></asp:Label>
                        </td>
                        <td class="rw1" >
                            <asp:DropDownList ID="loaihd"  runat="server" Width="100px">
                            </asp:DropDownList>
                        </td>
                        <td class ="rw">
                            <asp:Label ID="Label22" runat="server" Text="HĐLĐ số" Width="100px"></asp:Label>
                        </td>
                        <td class="rw">
                            <asp:TextBox ID="hdldso" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td class="rw1">
                            <asp:Label ID="Label30" runat="server" Text="Đơn vị"></asp:Label>
                        </td>
                        <td class="rw1" >
                            <asp:DropDownList ID="donvi" runat="server" Width="100px">
                            </asp:DropDownList>
                        </td>
                        <td class="rw">
                            <asp:Label ID="Label25" runat="server" Text="Ngày HĐ"  Width="100px"></asp:Label>
                        </td>
                        <td class="rw">
                            <asp:TextBox ID="ngayhd" runat="server"  Width="100px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td class="rw1">
                            <asp:Label ID="Label6" runat="server" Text="Phòng" Width="100px"></asp:Label>
                        </td>
                        <td class="rw1">
                            <asp:DropDownList ID="maphong" runat="server" Width="100px" >
                            </asp:DropDownList>
                        </td>
                        <td class="rw" >
                            <asp:Label ID="Label26" runat="server" Text="Ngày BĐ" Width="100px"></asp:Label>
                        </td>
                        <td class="rw">
                            <asp:TextBox ID="ngaybd" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="rw1" >
                            <asp:Label ID="Label7" runat="server" Text="Chức vụ" Width="100px"></asp:Label>
                        </td>
                        <td class="rw1">
                            <asp:DropDownList ID="machucvu" runat="server" Width="100px">
                            </asp:DropDownList>
                        </td>
                        <td class="rw">
                            <asp:Label ID="Label27" runat="server" Text="Ngày KT" Width="100px"></asp:Label>
                        </td>
                        <td class="rw">
                            <asp:TextBox ID="ngaykt" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="rw" >
                            <asp:Label ID="Label20" runat="server" Text="Bậc lương" Width="100px"></asp:Label>
                        </td>
                        <td class="rw">
                            <asp:DropDownList ID="bacluong" runat="server" Width="100px">
                            </asp:DropDownList>
                        </td>
                        <td class="rw">
                            <asp:Label ID="Label21" runat="server" Text="Phụ cấp CV (VNĐ)" Width="100px"></asp:Label>
                        </td>
                        <td class="rw">
                            <asp:TextBox ID="phucapcv" runat="server"  Width="100px" ></asp:TextBox>
                        </td>
                    </tr>
                    </table>     
                </div>
                <br />
                <div class="lou">
                <table  >
                    <tr>
                        <td>
                          <asp:Button ID="them" runat="server" Text="Thêm" OnClick="them_Click" />                
                        </td>
                        <td>
                            <asp:Button ID="xoa" runat="server" Text="Xoá" height="26px" width="54px" OnClick="xoa_Click" />
                        </td>
                        <td>
                            <asp:Button ID="sua" runat="server" Text="Sửa" height="26px" width="54px" OnClick="sua_Click" />
                        </td>
                        <td>
                            <asp:Button ID="in" runat="server" Text="In" height="26px" width="54px" OnClick="in_Click" />
                        </td>
                        <td>
                            <asp:Button ID="huy" runat="server" Text="Huỷ" height="26px" width="54px" OnClick ="huy_Click" />
                        </td>
                    </tr>
                </table>
                </div> 

        </div>
    </div>
</div>

    
<style type="text/css">
    .lou {border-radius: 10px 10px 10px 10px;
            -moz-border-radius: 10px 10px 10px 10px;
            -webkit-border-radius: 10px 10px 10px 10px;
            border: 1px solid #3300CC}
    .rw {
        width: 126px;
        height: 50%;
    }
  .rw1 {
        width: 82px;
        height: 50%;
    }

    #main{
    width: 1000px;
    padding: 0;
    margin-left: auto;
    margin-right: auto;
    }
    #head{
    height: 20px;
    background-color: #F5F5F5;
    border: 1px solid #CDCDCD;
    margin-bottom:5px;
    }
    #left{
     width: 335px;
     min-height: 400px;
     border: 1px solid #CDCDCD;
     float:left;
     background-color: #CDCDCD;
     margin-bottom: 5px;
    }
    #content{
     width: 433px;
     min-height: 400px;
     border: 1px solid #CDCDCD;
     float:left;
     margin-left: 5px;
     margin-right: 5px;
     margin-bottom: 5px;
    }
</style>
    
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="HeadContent">
    
    </asp:Content>

