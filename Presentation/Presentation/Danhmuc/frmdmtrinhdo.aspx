<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmdmtrinhdo.aspx.cs" Inherits="Presentation.frmdmtrinhdo" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <header class="lou" style="font-size:medium; font-weight: bold; color:CaptionText">DANH MỤC TRÌNH ĐỘ</header>
    <br />
  
     <div class="lou">
      <table >
        <tr>
            <td>
                            <asp:Label ID="Label1" runat="server" Text="Mã trình độ"></asp:Label>
                        </td>
            <td>
                            <asp:TextBox ID="matrinhdo" runat="server"></asp:TextBox>
                        </td>
        </tr>
        <tr>
            <td>
                            <asp:Label ID="Label2" runat="server" Text="Tên trình độ"></asp:Label>
                        </td>
            <td>
                            <asp:TextBox ID="tentrinhdo" runat="server"></asp:TextBox>
                        </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                                        <asp:Button ID="them" runat="server" Text="Thêm" OnClick="them_Click" />
                                        <asp:Button ID="xoa" runat="server" Text="Xoá" OnClick="xoa_Click" />
                                        <asp:Button ID="sua" runat="server" Text="Sửa" />
                                    </td>
        </tr>
    </table>
</div>
    <br />
    
    <div class="lou1" style="overflow:scroll">
                <asp:GridView ID="danhsachtrinhdo" runat="server" AutoGenerateSelectButton="true" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" OnSelectedIndexChanged="danhsachtrinhdo_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="matd" HeaderText="Mã trình độ" />
                        <asp:BoundField DataField="tentd" HeaderText="Tên trình độ" />
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
            border: 1px solid #3300CC; width:60%; height:220px }

    </style>
</asp:Content>
