<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookTemplateList.aspx.cs" Inherits="Library.BookTemplateList" %>
<%@ import namespace="System.Data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <h2>Book Template List:</h2>

    <div>
        <asp:HyperLink runat="server" navigateurl ="~/BookTemplateAdd.aspx">Add book template</asp:HyperLink>
    </div>

    <asp:Repeater ID="Templates" runat="server" ItemType="DataRow">
        <HeaderTemplate>
            <table>
                <tr>
                    <th>Author</th>
                    <th>Title</th>
                    <th>ISBN</th>
                    <th>&nbsp;</th>
                </tr>
            </table>
        </HeaderTemplate>
         <ItemTemplate>

            <td><%# Item.Field<int>("BookTemplateID") %> </td>
            <td><%# Item.Field<string>("Title") %></td>
            <td><%# Item.Field<string>("ISBN") %></td>
            <td><asp:HyperLink runat="server" NavigateUrl='<%# $"~/ItemEdit.aspx?ID={Item.Field<int>("BookTemplateID")}" %>' text="Edit" /> </td>
        </ItemTemplate> 
    </asp:Repeater>
</asp:Content>
