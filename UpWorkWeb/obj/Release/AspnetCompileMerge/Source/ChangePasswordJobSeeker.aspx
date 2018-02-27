<%@ Page Title="" Language="C#" MasterPageFile="~/JobSeekerMasterPage.Master" AutoEventWireup="true" CodeBehind="ChangePasswordJobSeeker.aspx.cs" Inherits="UpWorkWeb.ChangePasswordJobSeeker" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Change Passowrd</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">

        <div class="container panel">

            <h2 style="color: #1e90ff">Change Password</h2>
            <hr style="border: 1px solid; color: #1e90ff" />
            <div class="panel col-md-5">
                <label>Old Password</label>
                <asp:TextBox ID="oldPasswordTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="oldPasswordTextBox" ValidationGroup="Group1"></asp:RequiredFieldValidator>
                <br/>
                <label>New Password</label>
                <asp:TextBox ID="passwordTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="passwordTextBox" ValidationGroup="Group1"></asp:RequiredFieldValidator>
                <br/>
                <label>Retype New Password</label>
                <asp:TextBox ID="reTypePasswordTextBox" runat="server" CssClass="form-control" ValidationGroup="Group1"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="password didn't match" ControlToCompare="passwordTextBox" ValidationGroup="Group1" ControlToValidate="reTypePasswordTextBox" Type="String" Operator="Equal" ForeColor="red"></asp:CompareValidator>
                <br/>
                <asp:Button ID="changePasswordButton" runat="server" OnClick="changePasswordButton_OnClick" Text="Change" CssClass="btn btn-success" ValidationGroup="Group1" />
            </div>
        </div>
    </div>
</asp:Content>
