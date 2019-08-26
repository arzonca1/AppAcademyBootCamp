<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Counter.ascx.cs" Inherits="Widget_Library.Controls.Counter" %>

<div>
    <asp:Button ID="Minus" runat="server" Text ="-" OnClick="Minus_Click" />
    <asp:Label ID="Value" runat="server" />
    <asp:Button ID="Plus" runat="server" Text="+" OnClick="Plus_Click" />
</div>