<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BranchList.aspx.cs" Inherits="Library.BranchList" %>

<%@ Import Namespace="System.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">

    <h2>Branches</h2>

    <div>
        <asp:HyperLink runat="server" NavigateUrl="~/BranchAdd.aspx">Add New Branch</asp:HyperLink>
    </div>

    <asp:Repeater ID="Branches" runat="server" ItemType="DataRow">
        <HeaderTemplate>
            <table>
                <tr>
                    <th>Name</th>
                    <th>Address</th>
                    <th>Zip</th>
                    <th>&nbsp;</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Item.Field<string>("Name") %></td>
                <td><%# Item.Field<string>("StreetAddress") %></td>
                <td><%# Item.Field<string>("Zip") %></td>
                <td><asp:HyperLink runat="server" NavigateUrl='<%# $"~/BranchEdit.aspx?ID={Item.Field<int>("BranchID")}" %>' Text="Edit" /></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>

</asp:Content>
