<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmdmphongban.aspx.cs" Inherits="Presentation.Danhmuc.frmdmphongban" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <header class="lou" style="font-size:medium; font-weight: bold; color:CaptionText" >DANH MỤC PHÒNG BAN</header>
    <br />
    <div class="lou">
    <table>
        <tr>
            <td>
                            <asp:Label ID="Label1" runat="server" Text="Mã phòng"></asp:Label>
                        </td>
            <td>
                            <asp:TextBox ID="maphong" runat="server"></asp:TextBox>
                        </td>
        </tr>
        <tr>
            <td>
                            <asp:Label ID="Label2" runat="server" Text="Tên phòng"></asp:Label>
                        </td>
            <td>
                            <asp:TextBox ID="tenphong" runat="server"></asp:TextBox>
                        </td>
        </tr>
        <tr>
            <td>
                            <asp:Label ID="Label3" runat="server" Text="Điện thoại"></asp:Label>
                        </td>
            <td>
                            <asp:TextBox ID="dienthoai" runat="server"></asp:TextBox>
                        </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                                        <asp:Button ID="them" runat="server" Text="Thêm" OnClick="them_Click" />
                                        <asp:Button ID="Xoá" runat="server" Text="Xoá" />
                                        <asp:Button ID="Sửa" runat="server" Text="Sửa" />
                                    </td>
        </tr>
    </table>
    </div>
    <br />
<div class="lou1" style="overflow:scroll">

    
                <asp:GridView ID="danhsachphongban" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="true" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" OnSelectedIndexChanged="danhsachphongban_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="maphong" HeaderText="Mã phòng" />
                        <asp:BoundField DataField="tenphong" HeaderText="Tên phòng" />
                        <asp:BoundField DataField="dienthoai" HeaderText="Điện thoại" />
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
            border: 1px solid #3300CC; width:60%; }
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
            border: 1px solid #3300CC; width:60%; height:180px }
    </style>
</asp:Content>
