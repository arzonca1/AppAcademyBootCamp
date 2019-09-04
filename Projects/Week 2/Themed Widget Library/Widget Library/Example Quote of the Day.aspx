<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Example Quote of the Day.aspx.cs" Inherits="Widget_Library.Example_Quote_of_the_Day" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <h1>Widget library</h1>
        <h2>Quote of the Day / Random Quote Documentation</h2>
        <p>This control displays a quote of the day or a completely random.</p>
        <h3>Available Properties</h3>
        <ul>
           <li>'Randomize': Boolean value, if set to true will display a random quote, QOTD only otherwise</li>

        </ul>
        <h3>Examples</h3>

        <pre>&lt;wl:Quote runat="server" /&gt;</pre>

        <wl:Quote runat="server" />
        



        <pre>&lt;wl:Quote runat="server" randomize /&gt;</pre>
        <wl:Quote runat="server" randomize="true" />
</asp:Content>
