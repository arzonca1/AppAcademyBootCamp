<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GameControl.ascx.cs" Inherits="Tic_Tac_Toe.Control.GameControl" %>

<asp:Button runat="server" ID="AIgame" OnClick="AIgame_Click" text="Play against AI"/>
<br />
<asp:Button runat="server" ID="TPgame" OnClick="TPgame_Click" text="2 Player game"/>
<br /> <br /> 
<asp:Button runat="server" ID="Button1" OnClick="Board_Click" text=" " BackColor="YellowGreen" ForeColor="Orange"/>
<asp:Button runat="server" ID="Button2" OnClick="Board_Click" text=" " BackColor="YellowGreen" ForeColor="Orange"/>
<asp:Button runat="server" ID="Button3" OnClick="Board_Click" text=" " BackColor="YellowGreen" ForeColor="Orange"/>
<br />
<asp:Button runat="server" ID="Button4" OnClick="Board_Click" text=" " BackColor="YellowGreen" ForeColor="Orange"/>
<asp:Button runat="server" ID="Button5" OnClick="Board_Click" text=" " BackColor="YellowGreen" ForeColor="Orange"/>
<asp:Button runat="server" ID="Button6" OnClick="Board_Click" text=" " BackColor="YellowGreen" ForeColor="Orange"/>
<br />
<asp:Button runat="server" ID="Button7" OnClick="Board_Click" text=" " BackColor="YellowGreen" ForeColor="Orange"/>
<asp:Button runat="server" ID="Button8" OnClick="Board_Click" text=" " BackColor="YellowGreen" ForeColor="Orange"/>
<asp:Button runat="server" ID="Button9" OnClick="Board_Click" text=" " BackColor="YellowGreen" ForeColor="Orange"/>

<asp:Label runat="server" ID="BottomMessage" Text="" />
