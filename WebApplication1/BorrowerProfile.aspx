<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BorrowerProfile.aspx.cs" Inherits="WebApplication1.BorrowerProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="BorrowerProfilePic">
        <asp:Image ID="imgBorrower" runat="server" Height="150px" Width="150px" />
        <br />
        <asp:Label ID="lbBorrower" runat="server" Text="Borrower name" Font-Bold="True" Font-Size="Larger"></asp:Label>
    </div>
    <div id="BorrowerProfileText">
        Borrower status:
        <asp:Label ID="lbBorrowerStatus" runat="server" Text="Borrower status "></asp:Label>
    </div>
    <div style="clear:both;">&nbsp;</div>
</asp:Content>
