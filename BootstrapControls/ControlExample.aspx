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

    <div class="row">
        <div class="col-md-6">
            <h2>Bootstrap Table</h2>
            <bootstrap:Table ID="Table1" runat="server" Striped="True" HoverRows="True" Condensed="true">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>
                        1
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        2
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        3
                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                </asp:TableRow>
            </bootstrap:Table>
        </div>
        <div class="col-md-6">
            <h2>Standard Table</h2>
            <asp:Table ID="StandardTable1" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>
                        1
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        2
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        3
                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                    <asp:TableCell>
                        Value
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </div>
    <div class="row">
        <h2>Bootstrap GridView</h2>
        <bootstrap:GridView ID="BootstrapGridView" runat="server" AutoGenerateColumns="true" Striped="true" HoverRows="true">
        </bootstrap:GridView>
    </div>
    <div class="row">
        <h2>Standard GridView</h2>
        <asp:GridView ID="StandardGridView" runat="server" AutoGenerateColumns="true">
        </asp:GridView>
    </div>
</asp:Content>
