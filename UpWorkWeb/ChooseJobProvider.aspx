<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChooseJobProvider.aspx.cs" Inherits="UpWorkWeb.ChooseJobProvider" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>What Type of Account??
        </h1>
        <br />
        <asp:Button ID="companyAccountButton" runat="server" OnClick="companyAccountButton_Click" Text="Company Account" />
        <br />
        <br />
        <asp:Button ID="personalAccountButton" runat="server" OnClick="personalAccountButton_Click" Text="Personal Account" />
    
    </div>
    </form>
</body>
</html>
