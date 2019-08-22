<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ErrorHandlingExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <%--<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">--%>

                <asp:TextBox ID="Number1" runat="server" />
                <asp:TextBox ID="Number2" runat="server" />
                <asp:Button ID="Sum" runat="server" Text="Sum" OnClick="Sum_Click" />
                <asp:Label ID="Result" runat="server" />

                <asp:HyperLink runat="server" Text="Clear" NavigateUrl="~/Default.aspx" />
             <br /> <br />
            <asp:HyperLink runat="server" Text="Go Bye Bye" NavigateUrl="~/Xyzzy.aspx" />
                 <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br />
            <%--</asp:Content>--%>
        </div>
    </form>
</body>
</html>

