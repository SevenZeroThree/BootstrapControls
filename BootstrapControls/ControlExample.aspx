<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlExample.aspx.cs" Inherits="BootstrapControls.ControlExample" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <div class="row">
        <div class="col-md-6">
            <h2>Bootstrap TextBox</h2>
            <bootstrap:TextBox ID="TextBox1" runat="server" CssClass="test" ToolTip="Test"></bootstrap:TextBox>
            <bootstrap:TextBox ID="TextBox2" runat="server" CssClass="test" Placeholder="Test"></bootstrap:TextBox>
        </div>
        <div class="col-md-6">
            <h2>Standard TextBox</h2>
            <asp:TextBox ID="RealTextBox" runat="server" CssClass="test"></asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-md-6">
            <h2>Bootstrap Button</h2>
            <bootstrap:Button ID="Button1" runat="server" ButtonType="Default" Text="Bootstrap"></bootstrap:Button>
            <bootstrap:Button ID="Button2" runat="server" ButtonType="Primary" Text="Bootstrap"></bootstrap:Button>
            <bootstrap:Button ID="Button3" runat="server" ButtonType="Success" Text="Bootstrap"></bootstrap:Button>
            <bootstrap:Button ID="Button4" runat="server" ButtonType="Info" Text="Bootstrap"></bootstrap:Button>
            <bootstrap:Button ID="Button5" runat="server" ButtonType="Warning" Text="Bootstrap"></bootstrap:Button>
            <bootstrap:Button ID="Button6" runat="server" ButtonType="Danger" Text="Bootstrap"></bootstrap:Button>
            <bootstrap:Button ID="Button7" runat="server" ButtonType="Link" Text="Bootstrap"></bootstrap:Button>

            <bootstrap:Button ID="Button8" runat="server" ButtonSize="Large" Text="Bootstrap"></bootstrap:Button>
            <bootstrap:Button ID="Button10" runat="server" ButtonType="Info" IsBlock="True" Text="Bootstrap"></bootstrap:Button>
            <bootstrap:Button ID="Button9" runat="server" ButtonType="Success" IsBlock="True" Text="Bootstrap" CssClass="active"></bootstrap:Button>
        </div>
        <div class="col-md-6">
            <h2>Standard Button</h2>
            <asp:Button ID="StandardButton" runat="server" Text="Standard Button"></asp:Button>
        </div>
    </div>

</asp:Content>
