<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.vb" Inherits="About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>Car Loan Calculator</h1>
    </hgroup>
<article>

        <p>        
            The Car Loan Calculator website was developed for the book <em>Microsoft Visual Basic 2013 Step by Step</em>, by Michael Halvorson (Microsoft Press, 2013). The website is best viewed using Microsoft Internet Explorer. To learn more about how this ASP.NET Web Forms application was created, read Chapter 19 in the book.</p>
        <p>        
            <strong>Operating Instructions:</strong></p>
        <p>        
            Type a loan amount, without currency symbol or commas, into the Loan Amount box.</p>
        <p>        
            Type an interest rate in decimal format into the Interest Rate text box. Do not include the &quot;%&quot; sign. For example, to specify a 9% interest rate, type &quot;0.09&quot;.</p>
        <p>        
            Note that this loan calculator assumes a three-year, 36-month payment period.</p>
        <p>        
            Click the Calculate button to compute the basic monthly loan payment that does not include taxes or other fees.</p>
    </article>

    <aside>
        <h3>Aside Title</h3>
        <p>        
            Use this area to provide additional information.
        </p>
        <ul>
            <li><a runat="server" href="~/">Home</a></li>
            <li><a runat="server" href="~/About">About</a></li>
            <li><a runat="server" href="~/Contact">Contact</a></li>
        </ul>
    </aside>
</asp:Content>