<%@ Page Title="Car Loan Calculator" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><em>Car Loan Calculator</em></h1>
            </hgroup>
            <p>
                Enter the required information and click Calculate!</p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <p>
    <br />
</p>
<p>
    <asp:TextBox ID="AmountTextBox" runat="server"></asp:TextBox>
&nbsp;
    <asp:Label ID="AmountLabel" runat="server" Text="Loan Amount"></asp:Label>
</p>
<p>
    <asp:TextBox ID="InterestTextBox" runat="server"></asp:TextBox>
&nbsp;
    <asp:Label ID="InterestLabel" runat="server" Text="Interest Rate (for example, 0.09)"></asp:Label>
</p>
<p>
    <asp:TextBox ID="PaymentTextBox" runat="server"></asp:TextBox>
&nbsp;
    <asp:Label ID="PaymentLabel" runat="server" Text="Monthly Payment"></asp:Label>
</p>
<p>
    <asp:Button ID="CalculateButton" runat="server" Text="Calculate" />
</p>
<p>
    <asp:HyperLink ID="ProspectsLink" runat="server" NavigateUrl="~/FacultyLoanLeads.aspx">Display Loan Prospects</asp:HyperLink>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
