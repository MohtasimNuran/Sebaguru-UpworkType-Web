<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobProviderMasterPage.Master" CodeBehind="EditPostJobProvider.aspx.cs" Inherits="UpWorkWeb.EditPostJobProvider" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Edit Post</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">
        <br />
        <br />
        <br />
        <br />
        <div class="container panel">
            <div class="col-md-4">
            </div>
            <div class="col-md-4">

                <h1 style="color: #1e90ff;"><strong>Post Job</strong></h1>
                <hr />

                <asp:RadioButton ID="onlineRadioButton" runat="server" GroupName="onOrOff" Text="Online Job" AutoPostBack="True" OnCheckedChanged="onlineRadioButton_CheckedChanged" />
                <asp:RadioButton ID="offlineRadioButton" runat="server" GroupName="onOrOff" Text="Offline Job" AutoPostBack="True" OnCheckedChanged="offlineRadioButton_CheckedChanged" />
                <br />
                <asp:Label ID="locationLabel" runat="server" Text="Location"></asp:Label>
                <asp:TextBox ID="locationTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="Label7" runat="server" Text="Title"></asp:Label>
                <asp:TextBox ID="jobTitleTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorfullname" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="jobTitleTextBox" ForeColor="red"></asp:RequiredFieldValidator>

                <br />
                <asp:Label ID="Label6" runat="server" Text="Category"></asp:Label>
                <asp:DropDownList ID="categoryDropDownList" runat="server" CssClass="form-control">
                    <asp:ListItem>web</asp:ListItem>
                    <asp:ListItem>design</asp:ListItem>
                    <asp:ListItem>nothing</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="categoryDropDownList" ForeColor="red" InitialValue="...select one..."></asp:RequiredFieldValidator>

                <br />
                <asp:Label ID="Label" runat="server" Text="Job Responsibility"></asp:Label>
                <asp:TextBox ID="jobResponseTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="jobResponseTextBox" ForeColor="red"></asp:RequiredFieldValidator>

                <br />
                <asp:Label ID="Label2" runat="server" Text="Message"></asp:Label>
                <asp:TextBox ID="msgTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Deadline"></asp:Label>
                <%--<asp:TextBox ID="deadLineTextBox" runat="server"></asp:TextBox>--%>
                <input type="date" id="deadLineTextBox" runat="server" class="form-control" />

                <br />
                <asp:Image ID="coverImage" runat="server" CssClass="img-thumbnail" />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Change Photo"></asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Payment"></asp:Label>
                <asp:TextBox ID="paymentTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="paymentTextBox" ForeColor="red"></asp:RequiredFieldValidator>
                <br />
                <asp:DropDownList ID="perDropDownList" runat="server" CssClass="form-control">
                    <asp:ListItem>/hour</asp:ListItem>
                    <asp:ListItem>/day</asp:ListItem>
                    <asp:ListItem>/week</asp:ListItem>
                    <asp:ListItem>/month</asp:ListItem>
                    <asp:ListItem>/year</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="perDropDownList" ForeColor="red" InitialValue="...select one..."></asp:RequiredFieldValidator>

                <br />
                <br />
                <asp:Button ID="postButton" ValidationGroup="Group1" CssClass="btn btn-primary" runat="server" OnClick="postButton_Click" Text="Post" />
                <br />
            </div>

            <div class="col-md-4"></div>
        </div>
    </div>
</asp:Content>
