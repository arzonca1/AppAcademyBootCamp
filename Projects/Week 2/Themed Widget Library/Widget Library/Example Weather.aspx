<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Example Weather.aspx.cs" Inherits="Widget_Library.Example_Weather" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
        <h1>Widget library</h1>
        <h2>Weather Documentation</h2>
        <p>This widget takes a zip code and displays weather information about the location</p>
        <h3>Available Properties</h3>
        <ul>
            <li>Zip code</li>
        </ul>

        <h3>Example:</h3>

        <pre>&lt;wl:weather runat="server" /&gt;</pre>
        <wl:Weather runat="server" />
</asp:Content>