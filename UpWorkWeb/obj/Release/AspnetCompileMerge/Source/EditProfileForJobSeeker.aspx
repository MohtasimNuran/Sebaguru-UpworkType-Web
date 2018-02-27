<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProfileForJobSeeker.aspx.cs" Inherits="UpWorkWeb.EditProfileForJobSeeker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Edit Job Seeker</h1>
        <br />
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Full-Name"></asp:Label>
        <asp:TextBox ID="fullNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label11" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Birth-date"></asp:Label>
        <asp:TextBox ID="birthDateTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="phnTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
        <asp:DropDownList ID="genderDropDownList" runat="server">
            <asp:ListItem>...Select One...</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Nationnality"></asp:Label>
        <asp:TextBox ID="nationnalityTextBox" runat="server"></asp:TextBox>
        <br />
        Category<asp:DropDownList ID="categoryDropDownList" runat="server">
            <asp:ListItem>nothing</asp:ListItem>
            <asp:ListItem>web</asp:ListItem>
            <asp:ListItem>design</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Comment Box"></asp:Label>
        <asp:TextBox ID="commentBoxTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Image ID="profileImage" runat="server" />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="editButton" runat="server" OnClick="editButton_OnClick" Text="Update" />
    </div>
    </form>
</body>
</html>
