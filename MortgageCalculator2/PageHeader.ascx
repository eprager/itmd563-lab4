<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PageHeader.ascx.cs" Inherits="MortgageCalculator2.WebUserControl1" %>

<h1>Mortgage Calculator</h1>

<hr />

<asp:Menu ID="Menu1" Orientation="Horizontal" runat="server" StaticSubMenuIndent="10px" BackColor="#E3EAEB" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#666666">
    <DynamicHoverStyle BackColor="#666666" ForeColor="White"></DynamicHoverStyle>

    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px"></DynamicMenuItemStyle>

    <DynamicMenuStyle BackColor="#E3EAEB"></DynamicMenuStyle>

    <DynamicSelectedStyle BackColor="#1C5E55"></DynamicSelectedStyle>
    <Items>
        <asp:MenuItem Text="Calc Mortgage" Value="Calc Mortgage" NavigateUrl="~/CalculateForm.aspx"></asp:MenuItem>
        <asp:MenuItem Text="List Mortgages" Value="List Mortgages" NavigateUrl="~/ListMortgages.aspx"></asp:MenuItem>
        <asp:MenuItem Text="Clear Mortgages" Value="Clear Mortgages" NavigateUrl="~/ClearMortgages.aspx"></asp:MenuItem>
    </Items>
    <StaticHoverStyle BackColor="#666666" ForeColor="White"></StaticHoverStyle>

    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px"></StaticMenuItemStyle>

    <StaticSelectedStyle BackColor="#1C5E55"></StaticSelectedStyle>
    <StaticItemTemplate>
        <%# Eval("Text") %>
    </StaticItemTemplate>
</asp:Menu>

<hr />