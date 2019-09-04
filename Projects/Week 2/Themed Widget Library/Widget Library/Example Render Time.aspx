<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Example Render Time.aspx.cs" Inherits="Widget_Library.Example_Render_Time" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
            <h1>Widget library</h1>
            <h2>Render Time Control Documentation</h2>
            <p>This control displays the time the page was rendered at</p>
            <h3>Available Properties</h3>
            <ul>
                <li>`Label`: The text to display before the render time.</li>
                <li>`Format`: The date format string to use for the render time.</li>
            </ul>
            <h3>Examples</h3>

            <pre>&lt;wl:rendertime runat="server" /&gt;</pre>


            <wl:RenderTime runat="server" />


            <pre>&lt;wl:rendertime label="This is a custom label: " format="MM/dd/yy hh:mm tt" runat="server" /&gt;</pre>
            <wl:RenderTime Label="This is a custom label: " Format="MM/dd/yy hh:mm tt" runat="server" />
</asp:Content>