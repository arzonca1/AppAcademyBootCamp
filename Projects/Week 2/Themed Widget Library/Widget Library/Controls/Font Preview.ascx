<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Font Preview.ascx.cs" Inherits="Widget_Library.Controls.Font_Preview" %>

<div>
    <asp:Label runat="server" AssociatedControlID="FontsDDL">Font: </asp:Label>
    <asp:DropDownList ID="FontsDDL" runat="server" AutoPostBack="true"></asp:DropDownList>
</div>\

<div>
    <asp:Label ID="LoremIpsum" runat ="server">
        Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
        Nullam vulputate, nisl ut volutpat pulvinar, mi lectus 
        malesuada arcu, eu scelerisque tortor elit eu augue. 
        Nullam in nibh eleifend, fringilla enim id, consectetur 
        dolor. Pellentesque habitant morbi tristique senectus et 
        netus et malesuada fames ac turpis egestas. Fusce eleifend 
        sit amet justo nec euismod. Sed pharetra laoreet dolor. 
        Cras auctor molestie quam, sed pulvinar ligula malesuada 
        tincidunt. Suspendisse euismod tincidunt justo, a faucibus 
        nisi commodo eu. Vestibulum tempus vehicula diam mattis 
        convallis. Cras a velit et lacus pulvinar varius vel eget 
        magna. Donec nisl magna, interdum non sem nec, viverra 
        lobortis velit. Aenean faucibus quam vel ante congue dictum. 
        Mauris vel metus lorem. Curabitur mattis nisi ut convallis 
        vehicula. Donec mollis bibendum luctus. Class aptent taciti 
        sociosqu ad litora torquent per conubia nostra, per 
        inceptos himenaeos.
    </asp:Label>
</div>