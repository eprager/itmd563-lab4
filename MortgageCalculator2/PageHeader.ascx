<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PageHeader.ascx.cs" Inherits="MortgageCalculator2.WebUserControl1" %>

<h1>Mortgage Calculator</h1>

<hr />

<asp:Menu ID="Menu1" Orientation="Horizontal" runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px">
    <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicMenuStyle BackColor="#FFFBD6" />
    <DynamicSelectedStyle BackColor="#FFCC66" />
    <Items>
        <asp:MenuItem Text="Calc Mortgage" Value="Calc Mortgage" NavigateUrl="~/CalculateForm.aspx"></asp:MenuItem>
        <asp:MenuItem Text="List Mortgages" Value="List Mortgages" NavigateUrl="~/ListMortgages.aspx"></asp:MenuItem>
        <asp:MenuItem Text="Clear Mortgages" Value="Clear Mortgages" NavigateUrl="~/ClearMortgages.aspx"></asp:MenuItem>
    </Items>
    <StaticHoverStyle BackColor="#990000" ForeColor="White" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticSelectedStyle BackColor="#FFCC66" />
    <StaticItemTemplate>
        <%# Eval("Text") %>
    </StaticItemTemplate>
</asp:Menu>

<hr />