<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobSeekerMasterPage.Master" CodeBehind="MessageJobSeeker.aspx.cs" Inherits="UpWorkWeb.MessageJobSeeker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Message</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">
        <br />
        <br />
        <br />
        <br />
        <div class="container panel">

            <h1 style="color: #1e90ff">Message</h1>
            <hr />
            <div>
                Email To:
        <asp:TextBox ID="receiverTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorfullname" runat="server" ErrorMessage="*" ControlToValidate="receiverTextBox" ForeColor="red"></asp:RequiredFieldValidator>

                <br />
                Message Body:
         <asp:TextBox ID="msgTextBox" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="msgTextBox" ForeColor="red"></asp:RequiredFieldValidator>


                <br />
                <asp:Button ID="sendButton" runat="server" OnClick="sendButton_Click" Text="Send" CssClass="btn btn-primary" />
                <br />
                <br />
            </div>
        </div>
    </div>
</asp:Content>
