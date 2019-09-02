<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="Library.BookList" %>
<%@ import namespace="System.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <h2>Book Template List:</h2>

    <div>
        <asp:HyperLink runat="server" navigateurl ="~/BookAdd.aspx">Add book</asp:HyperLink>
    </div>

    <asp:Repeater ID="Books" runat="server" ItemType="DataRow">
        <HeaderTemplate>
            <table>
                <tr>
                    <th>BookID</th>
                    <th>Author</th>
                    <th>Title</th>
                    <th>ISBN</th>
                    <th>Branch</th>
                    <th>Status</th>
                </tr>
            </table>
        </HeaderTemplate>
         <ItemTemplate>

            <td><%# Item.Field<int>("BookID") %> </td>
            <td><%# Item.Field<string>("Author") %></td>
            <td><%# Item.Field<string>("Title") %></td>
            <td><%# Item.Field<string>("ISBN") %> </td>
            <td><%# Item.Field<string>("Branch") %></td>
            <td><%# Item.Field<string>("Status") %></td>
            <td>&nbsp;</td>

            
            <td><asp:HyperLink runat="server" NavigateUrl='<%# $"~/BookEdit.aspx?ID={Item.Field<int>("BookID")}" %>' text="Edit" /> </td>
            <td><br /></td>
         
         </ItemTemplate> 
        
    </asp:Repeater>
</asp:Content> 
