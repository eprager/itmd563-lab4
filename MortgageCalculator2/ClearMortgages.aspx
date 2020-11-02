<%@ Page Title="Clear Mortgages" Language="C#" MasterPageFile="~/SiteMaster1.Master" AutoEventWireup="true" CodeBehind="ClearMortgages.aspx.cs" Inherits="MortgageCalculator2.ClearMortgages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Clear Mortgages</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form2">
        <h2>Clear Mortgages</h2>
        <div>
            <asp:Button ID="Button1" runat="server" onClick="clear_Click" Text="Clear Submissions" />
            <asp:Label ID="Output" runat="server" Text=""></asp:Label>
        </div>
    </form>

</asp:Content>
