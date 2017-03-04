<%@ Page Title="Danh sách người dùng" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmOK.aspx.cs" Inherits="Presentation.Nguoidung.frmOK" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <header class="lou" style="font-size:medium; font-weight: bold; color:CaptionText">DANH SÁCH NGƯỜI DÙNG </header>
    
    <br />
    <div class="lou" style ="height:450px">
    <asp:GridView ID="Danhsachnguoidung" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Taikhoan" HeaderText="Tài khoản người dùng" />
            <asp:BoundField DataField="matkhau" HeaderText="Mật khẩu" />
            <asp:BoundField DataField="quyen" HeaderText="Quyền" />
        </Columns>
    </asp:GridView>
    </div>

    <style type="text/css">
    .lou {border-radius: 10px 10px 10px 10px;
            -moz-border-radius: 10px 10px 10px 10px;
            -webkit-border-radius: 10px 10px 10px 10px;
            border: 1px solid #3300CC; width:60%}
    .rw {
        width: 126px;
        height: 50%;
    }
  .rw1 {
        width: 82px;
        height: 50%;
    }
  </style>

</asp:Content>
