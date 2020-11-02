<%@ Page Title="List Mortgages" Language="C#" MasterPageFile="~/SiteMaster1.Master" AutoEventWireup="true" CodeBehind="ListMortgages.aspx.cs" Inherits="MortgageCalculator2.ListMortgages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>List Mortgages</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form2">
        <h2>List Mortgages</h2>
        <div>
            <asp:Button ID="Button1" runat="server" onClick="list_Click" Text="View Submissions" />
            <br />
            <br />

            <asp:Label ID="Label1" runat="server" AssociatedControlID="Mortgages" Text=""></asp:Label>
            <asp:TextBox ID="Mortgages" Text="" runat="server" Multiline="true" Height="146px" Width="672px" ReadOnly="True" Rows="1000" TextMode="MultiLine"></asp:TextBox>
            
        </div>
    </form>

</asp:Content>

