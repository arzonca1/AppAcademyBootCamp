<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookTemplateAdd.aspx.cs" Inherits="Library.BookTemplateAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">

    <h2>Add Book Template Base (Not individual instance)</h2>

    <fieldset>

        <div>
            <asp:label id="TitleLabel" runat="server" associatedcontrolid="Title1" text="Title: " />
            <asp:textbox id="Title1" runat="server" />
        </div> 

        <div>
            <asp:label id="ISBNLabel" runat="server" associatedcontrolid="ISBN" text="ISBN: " />
            <asp:textbox id="ISBN" runat="server" />
        </div>

        <div>
            <asp:Label ID ="AuthorDDLLabel" runat="server" AssociatedControlID="AuthorDDL" Text="Author: " />
            <asp:DropDownList ID="AuthorDDL" runat="server" AppendDataBoundItems="true">

            </asp:DropDownList>
        </div>

    </fieldset>

    <div>
        <asp:button id="Save" runat="server" text="Save" onclick="Save_Click" />
    </div>

</asp:Content>
