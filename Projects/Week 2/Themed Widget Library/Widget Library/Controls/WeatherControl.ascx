<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WeatherControl.ascx.cs" Inherits="Widget_Library.Controls.WeatherControl" %>


<div>
    <asp:validationsummary runat="server" 
        validationgroup="WeatherInformation" 
        headertext="The following errors were found:" 
        forecolor="Red" />
    <div>
        <asp:label id="ZipLabel" runat="server" associatedcontrolid="Zip">
            Enter a Zip Code:
        </asp:label>
        <asp:textbox id="Zip" runat="server" />
        <asp:requiredfieldvalidator runat="server" 
            controltovalidate="Zip" display="Dynamic" 
            errormessage="Please provide a zip code." 
            text="*" forecolor="Red" validationgroup="WeatherInformation" />
        <asp:regularexpressionvalidator runat="server"
            controltovalidate="Zip" display="Dynamic"
            errormessage="Please provide a valid 5-digit zip code."
            text="*" forecolor="Red" validationgroup="WeatherInformation"
            validationexpression="\d\d\d\d\d" />
    </div>
    <asp:button id="GetWeather" runat="server" text="Get Weather"
        validationgroup="WeatherInformation" onclick="GetWeather_Click" />
</div>

<asp:repeater id="WeatherInformation" runat="server" 
        itemtype="KeyValuePair<string, string>">
    <headertemplate>
        <ul>
    </headertemplate>
    <itemtemplate>
        <li>
            <%# Item.Key %>: <%# Item.Value %>
        </li>
    </itemtemplate>
    <footertemplate>
        </ul>
    </footertemplate>
</asp:repeater>

<asp:panel id="Error" runat="server">
    <p>
        Sorry, there was an error retrieving the weather information.
    </p>
</asp:panel>
