<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuJobSeeker.aspx.cs" Inherits="UpWorkWeb.MenuJobSeeker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Job Seeker Menu</h1>
        <p>
            <asp:Button ID="jobListButton" runat="server" OnClick="jobListButton_Click" Text="Job List" />
        </p>
        <p>
            <asp:Button ID="appliedJobListButton" runat="server" OnClick="appliedJobListButton_Click" Text="Applied Job List" />
        </p>
        <p>
            <asp:Button ID="myProfileButton" runat="server" OnClick="myProfileButton_Click" Text="My Profile" />
        </p>
        <p>
            <asp:Button ID="completeJobListButton" runat="server" OnClick="completeJobListButton_Click" Text="Complete Job List" />
        </p>
        <p>
            <asp:Button ID="workingJobListButton" runat="server" OnClick="workingJobListButton_Click" Text="Working Job List" />
        </p>
        <p>
            <asp:Button ID="notificationButton" runat="server" OnClick="notificationButton_Click" Text="Notification" />
        </p>
        <p>
            <asp:Button ID="msgNotificationButton" runat="server" OnClick="msgNotificationButton_Click" Text="Message Notification" />
        </p>
        <p>
            <asp:Button ID="sendMsgButton" runat="server" OnClick="sendMsgButton_Click" Text="Send Message" />
        </p>
        <p>
            <asp:Button ID="dashBoardButton" runat="server" OnClick="dashBoardButton_Click" Text="DashBoard" />
        </p>
    
    </div>
    </form>
</body>
</html>
