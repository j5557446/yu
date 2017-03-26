<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="yu.register" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        #yu{
            margin-left:0px;
            margin-bottom:40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
        
    <div class="fixed-width">
        <h2 id="yu">加入BOOK-LIFE:</h2>
 <table>
        <tr>
            <td style="height: 50px; width: 220px; font-size: 20px;">
                <asp:Label ID="Label1" runat="server" Text="請輸入您的姓名:"></asp:Label></td>
            <td>
                <asp:TextBox ID="txt_user_name" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_user_name" ErrorMessage="姓名不可空白!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td style="height: 50px; font-size: 20px;">
                <asp:Label ID="Label2" runat="server" Text="請輸入您的E-Mail:"></asp:Label></td>
            <td>
                <asp:TextBox ID="txt_user_no" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_user_no" ErrorMessage="E-Mail不可空白!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style1" style="height: 50px; font-size: 20px;">
                <asp:Label ID="Label3" runat="server" Text="請設定您的密碼:"></asp:Label></td>
            <td class="auto-style1">
                <asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_password" ErrorMessage="密碼不可空白!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td style="height: 50px; font-size: 20px;">
                <asp:Label ID="Label4" runat="server" Text="請再輸入一次密碼: "></asp:Label></td>
            <td>
                <asp:TextBox ID="txt_passcheck" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txt_passcheck" ErrorMessage="密碼不可空白!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
        </tr>
     <tr>
            <td style="height: 50px; font-size: 20px;">
                <asp:Label ID="Label5" runat="server" Text="請輸入您的地址:"></asp:Label></td>
            <td>
                <asp:TextBox ID="txt_user_address" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_user_address" ErrorMessage="地址不可空白!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
        </tr>
      <tr>
            <td style="height: 50px; font-size: 20px;">
                <asp:Label ID="Label6" runat="server" Text="請輸入您的電話:"></asp:Label></td>
            <td>
                <asp:TextBox ID="txt_user_phone" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_user_phone" ErrorMessage="電話不可空白!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
        </tr>
      </table>
        </div>
    <div class="fixed-width">
        <asp:Button ID="btn_register" runat="server" Text="註冊"  OnClick="btn_register_Click" BackColor="White" />

        <asp:Label ID="lbl_message" runat="server" ForeColor="Red"></asp:Label>

    </div>
      
</asp:Content>
