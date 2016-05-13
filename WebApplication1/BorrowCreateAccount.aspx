<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BorrowCreateAccount.aspx.cs" Inherits="WebApplication1.BorrowCreateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div id="BAccountCreation">
    <table>
        
        <tr><td>Company trading name:</td><td><asp:TextBox ID="txtCompanyTName" runat="server"></asp:TextBox></td></tr>
        <tr><td>Company registration number:</td><td><asp:TextBox ID="txtCompanyRegNum" runat="server"></asp:TextBox></td></tr>
        <tr><td>First name:</td><td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td></tr>
        <tr><td>Second name:</td><td><asp:TextBox ID="txtSecondName" runat="server"></asp:TextBox></td></tr>
        <tr><td>Username:</td><td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td></tr>
        <tr><td>Email Address:</td><td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td></tr>
        <tr><td>Confirm Email Address</td><td><asp:TextBox ID="txtConfirmEmail" runat="server"></asp:TextBox></td></tr>
        <tr><td>Password:</td><td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td></tr>
        <tr><td></td><td><asp:button runat="server" text="bnCreateAccount" OnClick="Unnamed1_Click" /></td></tr>  
    </table>

</div>
</asp:Content>