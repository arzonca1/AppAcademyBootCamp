<%@ Page Title="Edit Book Status" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookEdit.aspx.cs" Inherits="Library.BookEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
     <h2>Edit Book Status</h2>

    <fieldset>

        <div>
            <asp:Label ID="BookID" runat="server" />
            <asp:Label ID="BookTitle" runat="server"/>
            <asp:Label ID="BookAuthor" runat="server" />



        </div>
        <div>
            <asp:Label ID ="BookStatus" runat="server" AssociatedControlID="BookStatusDDL" Text="Status: " />
            <asp:DropDownList ID="BookStatusDDL" runat="server" AppendDataBoundItems="true" />
        </div>

    </fieldset>

    <div>
        <asp:button id="Save" runat="server" text="Save" onclick="Save_Click" />
        <asp:button id="Cancel" runat="server" text="Cancel" onclick="Cancel_Click" />
    </div>
</asp:Content>
