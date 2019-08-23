<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tic_Tac_Toe.Default" %>

<!DOCTYPE html>

<link href="Stylesheet.css" rel="stylesheet" type="text/css" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="Ugly">
    <div>
    
        <ttt:PlayGame runat="server"/>
    </div>
    </form>
</body>
</html>
