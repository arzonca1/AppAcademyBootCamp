<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BranchEdit.aspx.cs" Inherits="Library.BranchEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">

    <h2>Edit Branch</h2>

    <fieldset>

        <div>
            <asp:Label ID="NameLabel" runat="server" AssociatedControlID="Name" Text="Branch Name: " />
            <asp:TextBox ID="Name" runat="server" />
        </div>

        <div>
            <asp:Label ID="AddressLabel" runat="server" AssociatedControlID="Address" Text="Address: " />
            <asp:TextBox ID="Address" runat="server" />
        </div>

        <div>
            <asp:Label ID="ZipLabel" runat="server" AssociatedControlID="Zip" Text="Zip: " />
            <asp:TextBox ID="Zip" runat="server" />
        </div>

    </fieldset>

    <div>
        <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" />
        <asp:Button ID="Cancel" runat="server" Text="Cancel" OnClick="Cancel_Click" />
    </div>

</asp:Content>
