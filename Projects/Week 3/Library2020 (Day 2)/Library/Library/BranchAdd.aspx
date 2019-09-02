<%@ Page Title="Add Branch" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BranchAdd.aspx.cs" Inherits="Library.BranchAdd" %>
<%@ import namespace="System.Data" %>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">

    <h2>Add Branch</h2>

    <fieldset>

        <div>
            <asp:label id="NameLabel" runat="server" associatedcontrolid="Name" text="Branch Name: " />
            <asp:textbox id="Name" runat="server" />
        </div>

        <div>
            <asp:label id="StreetAddress" runat="server" associatedcontrolid="StreetAddress" text="Address: " />
            <asp:textbox id="Address" runat="server" />
        </div>

        
        <div>
            <asp:label id="Zip" runat="server" associatedcontrolid="Zip" text="ZIP: " />
            <asp:textbox id="zipcode" runat="server" />
        </div>

    </fieldset>

    <div>
        <asp:button id="Save" runat="server" text="Save" onclick="Save_Click" />
    </div>

</asp:Content>
