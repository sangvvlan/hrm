<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmdangnhap.aspx.cs" Inherits="Presentation.Nguoidung.frmdangnhap" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="lou1">
    <asp:Login ID="Dangnhap" runat="server" LoginButtonText="Đăng nhập" PasswordLabelText="Mật khẩu:" RememberMeText="Nhớ đăng nhập." TitleText="Đăng nhập" UserNameLabelText="Người dùng:" OnAuthenticate="Dangnhap_Authenticate" PasswordRequiredErrorMessage="Bắc buộc nhập mật khẩu." UserNameRequiredErrorMessage="Bắc buộc nhập người dùng." Width="459px" FailureText="Đăng nhập không thành công. Cố gắng đăng nhập lần nữa." BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="X-Small" ForeColor="#333333" Height="194px" TextLayout="TextOnTop">
        <CheckBoxStyle Font-Size="X-Small" Wrap="False" />
        <InstructionTextStyle Font-Italic="True" ForeColor="Black" Font-Size="X-Small" />
        <LabelStyle Font-Size="X-Small" />
        <FailureTextStyle Font-Size="X-Small" />
        <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="Medium" ForeColor="#284E98" />
        <TextBoxStyle Font-Size="Large" />
        <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="Large" ForeColor="White" />
        <ValidatorTextStyle Font-Size="Small" />
    </asp:Login>
    <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Register</asp:HyperLink>
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
            border: 1px solid #3300CC; width:488px; height:430px }
  </style>

</asp:Content>
