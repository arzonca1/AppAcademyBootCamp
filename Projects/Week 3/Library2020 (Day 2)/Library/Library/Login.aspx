<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Library.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">


    <h2>Login</h2>


    <asp:Panel ID="FailureMessage" runat="server" Visible="false">
        <p>Login failure.</p>
    </asp:Panel>

    <fieldset>
        <div>
            <asp:Label ID="LibraryCardNumberLabel" runat="server" AssociatedControlID="LibraryCardNumber" Text="Library Card Number: " />
            <asp:TextBox ID="LibraryCardNumber" runat="server" CssClass="form-control" />
        </div>

        <div>
            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" Text="Password: " />
            <asp:TextBox ID="Password" runat="server" CssClass="form-control" TextMode="Password" />
        </div>
    </fieldset>
    <div class="p-3">
        <asp:Button ID="LoginUser" runat="server" Text="Login" CssClass="btn btn-success btn-lg" OnClick="LoginUser_Click" />
    </div>

</asp:Content>
