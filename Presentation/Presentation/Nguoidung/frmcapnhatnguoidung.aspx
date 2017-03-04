<%@ Page Title="Đăng nhập" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmcapnhatnguoidung.aspx.cs" Inherits="Presentation.Nguoidung.frmcapnhatnguoidung" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <header class="lou" style="font-size:medium; font-weight: bold; color:CaptionText" >DANH MỤC TÀI KHOẢN</header>
    <br />
    <div class="lou">
    <table style="width:100%" >
        <tr>
            <td>
                            <asp:Label ID="Label1" runat="server" Text="Tài khoản"></asp:Label>
                        </td>
            <td>
                            <asp:TextBox ID="tentaikhoan" runat="server"></asp:TextBox>
                        </td>
        </tr>
        <tr>
            <td>
                            <asp:Label ID="Label2" runat="server" Text="Passsword"></asp:Label>
                        </td>
            <td>
                            <asp:TextBox ID="matkhau" runat="server"></asp:TextBox>
                        </td>
        </tr>
        <tr>
            <td>
                            <asp:Label ID="Label3" runat="server" Text="Quyền"></asp:Label>
                        </td>
            <td>
                            <asp:DropDownList ID="quyennv" runat="server" Height="23px" Width="126px">
                                <asp:ListItem>Quản trị</asp:ListItem>
                                <asp:ListItem>Khách</asp:ListItem>
                                <asp:ListItem>Nhân viên</asp:ListItem>
                            </asp:DropDownList>
                        </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                                        <asp:Button ID="themmoinguoidung" runat="server" height="26px"  Text="Thêm mới " width="100px" OnClick="themmoinguoidung_Click" />
                                        <asp:Button ID="capnhat" runat="server" Text="Cập nhật" width="100px" height="26px" />
                                        <asp:Button ID="thoat" runat="server" Text="Thoát" width="100px" />
                                    </td>
        </tr>
    </table>
    </div>
    <br />
    <div class="lou1" style=" overflow:scroll">
    
    <asp:GridView ID="dstaikhoan" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="dstaikhoan_SelectedIndexChanged" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" >
                    <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Taikhoan" HeaderText="Tài khoản người dùng" />
                    <asp:BoundField DataField="matkhau" HeaderText="Mật khẩu" />
                    <asp:BoundField DataField="quyen" HeaderText="Quyền" />
                </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
    </div>
    <style type="text/css">
    .lou {border-radius: 10px 10px 10px 10px;
            -moz-border-radius: 10px 10px 10px 10px;
            -webkit-border-radius: 10px 10px 10px 10px;
            border: 1px solid #3300CC; width:100%; }
    .rw {
        width: 126px;
        height: 50%;
    }
  .rw1 {
        width: 82px;
        height: 50%;
    }
  .lou1 {border-radius: 10px 10px 10px 10px;
            -moz-border-radius: 10px 10px 10px 10px;
            -webkit-border-radius: 10px 10px 10px 10px;
            border: 1px solid #3300CC; width:100%; height:200px }
  </style>
</asp:Content>
