<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Example Quote of the Day.aspx.cs" Inherits="Widget_Library.Example_Quote_of_the_Day" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Widget library</h1>
        <h2>Quote of the Day / Random Quote Documentation</h2>
        <p>This control displays a quote of the day or a completely random.</p>
        <h3>Available Properties</h3>
        <ul>
           <li>'Randomize': Boolean value, if set to true will display a random quote, QOTD only otherwise</li>

        </ul>
        <h3>Examples</h3>

        <pre>&lt;wl:Quote runat="server" /&gt;</pre>

        <wl:Quote runat="server" />
        



        <pre>&lt;wl:Quote runat="server" randomize /&gt;</pre>
        <wl:Quote runat="server" randomize="true" />
  <p>     
           <a href="Default.aspx">Return to Home</a>
</p>
    </div>
    </form>
</body>
</html>
