<%@ Page Title="" Language="C#" MasterPageFile="~/RpnCalculator.Master" AutoEventWireup="true" CodeBehind="CalculatorUI.aspx.cs" Inherits="RpnCalculator.CalculatorUI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <h1>RPN Calculator</h1>

    <div>
        <asp:Repeater ItemType="System.String" ID="StackViewer" runat="server">
            <ItemTemplate>
                <div class="stack-entry"><%# Item %></div>
            </ItemTemplate>
        </asp:Repeater>

    </div>

    <section>
        <asp:TextBox ID="NumberInput" runat="server"></asp:TextBox>
        <asp:Button ID="Enter" OnClick="HandleEnter" Text="Enter" runat="server" />
    </section>

    <fieldset>
        <asp:Button ID="Add" Text="+" OnClick="HandleAdd" runat="server" />
        <asp:Button ID="Minus" Text="-" OnClick="HandleMinus" runat="server" />
        <asp:Button ID="Multiply" Text="*" OnClick="HandleMultiply" runat="server" />
        <asp:Button ID="Divide" Text="/" OnClick="HandleDivide" runat="server" />
        <asp:Button ID="Negate" Text="+/-" OnClick="HandleNegate" runat="server" />
        <asp:Button ID="SquareRoot" Text="Sqrt" OnClick="HandleSquareRoot" runat="server" />
        <asp:Button ID="XtoY" Text="x^y" OnClick="HandleXtoY" runat ="server" /> 
        <asp:Button ID="EtoX" Text ="e^x" OnClick="HandleEtoX" runat="server" />
        <asp:Button ID="OneOverX" Text ="1/x" OnClick="HandleOneOverX" runat ="server" />
        <asp:Button ID="Sin" Text="sin(x)" OnClick="HandleSin" runat="server" />
        <asp:Button ID="Cos" Text="cos(x)" OnClick="HandleCos" runat="server" />


    </fieldset>

    <fieldset>
        <legend>Stack Operations</legend>
        <asp:Button ID="Drop" Text="Drop" OnClick="HandleDrop" runat="server" />
        <asp:Button ID="Clear" Text="Clear" OnClick="HandleClear" runat="server" />
        <asp:Button ID="Swap" Text="Swap" OnClick="HandleSwap" runat="server" />
        <asp:Button ID="Rotate" Text="Rotate" OnClick="HandleRotate" runat="server" />

    </fieldset>
</asp:Content>
