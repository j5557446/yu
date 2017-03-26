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
        <h2 id="yu">登入宇哥:</h2>
 <table>
      
        <tr>
            <td style="height: 50px; font-size: 20px;">
                <asp:Label ID="Label2" runat="server" Text="請輸入您的E-Mail:"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1" style="height: 50px; font-size: 20px;">
                <asp:Label ID="Label3" runat="server" Text="請輸入您的密碼:"></asp:Label></td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
        </tr>
      
    </table>
        </div>
</asp:Content>
