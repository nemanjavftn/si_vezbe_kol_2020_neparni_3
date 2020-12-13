<%@ Page Title="Rent a car" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="PresentationLayer.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.<asp:ListBox ID="ListBoxCars" runat="server" Width="303px"></asp:ListBox>
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Model"></asp:Label>
    <asp:TextBox ID="TextBoxModel" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Godiste"></asp:Label>
    <asp:TextBox ID="TextBoxProductYear" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="Dodaj" />
</p>
</asp:Content>
