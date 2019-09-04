<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Example Text Control.aspx.cs" Inherits="Widget_Library.Controls.Example_Text_Control" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
            <h1>Widget library</h1>
            <h2>Font Control Documentation</h2>
            <p>This control presents the user with a dropdown menu of fonts and updates the font in the example text to the selected font. </p>
            <h3>Available Properties</h3>
            <ul>
                <li>`Fonts`: Drop down menu to select the font from </li>
            </ul>
            <h3>Examples</h3>

            <pre>&lt;wl:Font runat=server/&gt;</pre>


            <wl:Font runat="server" />
    </asp:Content>