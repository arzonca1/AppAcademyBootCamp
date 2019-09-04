<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookAdd.aspx.cs" Inherits="Library.BookAdd" %>


<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <h2>Add Individual Book (Use Add Book Template to add new titles)</h2>

    <fieldset>

        <div>
            <asp:Label ID ="Book" runat="server" AssociatedControlID="BookDDL" Text="Title: " />
            <asp:DropDownList ID="BookDDL" runat="server" AppendDataBoundItems="true" />
        </div> 

        <div>
            <asp:Label ID ="Branch" runat="server" AssociatedControlID="BranchDDL" Text="Branch: " />
            <asp:DropDownList ID="BranchDDL" runat="server" AppendDataBoundItems="true" />
        </div>


    </fieldset>

    <div>
        <asp:button id="Save" runat="server" text="Save" onclick="Save_Click" />
    </div>
</asp:Content>
