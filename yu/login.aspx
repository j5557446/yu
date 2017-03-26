<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="yu.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #yu{
            margin-left:0px;
            margin-bottom:40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="fixed-width">
        <h2 id="yu">登入BOOK-LIFE:</h2>
 <table>
      
       <tr>
            <td style="height: 50px; width: 220px; font-size: 20px;">
                <asp:Label ID="Label1" runat="server" Text="請輸入您的E-Mail:"></asp:Label></td>
            <td>
                <asp:TextBox ID="txt_user_no" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_user_no" ErrorMessage="E-Mail不可空白!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td style="height: 50px; font-size: 20px;">
                <asp:Label ID="Label2" runat="server" Text="請輸入您密碼:"></asp:Label></td>
            <td>
                <asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_password" ErrorMessage="密碼不可空白!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
        </tr>
      
    </table>
            <div>
                <asp:Button ID="btn_login" runat="server" Text="登入" OnClick="btn_login_Click" />
                <asp:Label ID="lbl_message" runat="server" ForeColor="Red"></asp:Label>
            </div>
        </div>
</asp:Content>
