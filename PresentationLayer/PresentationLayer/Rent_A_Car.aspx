<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rent_A_Car.aspx.cs" Inherits="PresentationLayer.Rent_A_Car" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Model"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Godiste"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonAddNewCar" runat="server" OnClick="Button1_Click" Text="Button" />
    </p>
    <p>
        <asp:ListBox ID="ListBoxCarss" runat="server" Width="420px"></asp:ListBox>
    </p>
</asp:Content>
