<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentationLayer._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Rent a Car</h1>
        
      
    </div>

    <div class="row">
        <div class="col-md-4">
           
            <asp:Label ID="Label1" runat="server" Text="Model:"></asp:Label>
            <asp:TextBox ID="TextBoxModel" runat="server"></asp:TextBox>
           
        </div>
        <div class="col-md-4">
          
            <asp:Label ID="Label2" runat="server" Text="ProductionYear:"></asp:Label>
            <asp:TextBox ID="TextBoxProductionYear" runat="server"></asp:TextBox>
            <asp:Button ID="Add" runat="server" OnClick="Add_Click" Text="Add" />
          
        </div>
        <div class="col-md-4">
            
            <asp:ListBox ID="ListBoxWriteLine" runat="server" Height="238px" Width="405px"></asp:ListBox>
            
        </div>
    </div>

</asp:Content>
