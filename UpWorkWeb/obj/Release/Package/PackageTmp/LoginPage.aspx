<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PartialMasterPage.Master" CodeBehind="LoginPage.aspx.cs" Inherits="UpWorkWeb.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">
        <br />
        <br />
        <br />
        <br />
        <br />
        <div class="container panel" style="background-color: #dcdcdc">
            <br />
            <div class="col-md-4">
            </div>
            <div class="col-md-4 jumbotron">

                <h1 style="color: #1e90ff;"><strong>Log In</strong></h1>
                <hr/>
                <div class="">
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="emailTextBox" runat="server" CssClass="form-control" placeholder="Email..."></asp:TextBox>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox ID="passwordTextBox" runat="server" CssClass="form-control" placeholder="Password..."></asp:TextBox>
                    <asp:LinkButton ID="LinkButton1" runat="server">Forgot Password</asp:LinkButton>
                    <br />
                    <br />

                    <asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="Login" CssClass="btn btn-info" />

                    <br />
                    <br />
                    <asp:Button ID="facebookLoginButton" runat="server" OnClick="facebookLoginButton_Click" Text="Facebook Login" CssClass="btn btn-primary" />

                    <asp:Button ID="gmailLoginButton" runat="server" Text="Gmail Login" OnClick="gmailLoginButton_Click" CssClass="btn btn-danger" />
                    <br />
                    <br />
                </div>

            </div>
            <div class="col-md-4"></div>
        </div>
    </div>

</asp:Content>
