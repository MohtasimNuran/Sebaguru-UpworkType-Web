<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuJobProvider.aspx.cs" Inherits="UpWorkWeb.MenuJobProvider" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Job Provider Menu</h1>
        <p>
            <asp:Button ID="jobListButton" runat="server" OnClick="jobListButton_Click" Text="Job List" />
        </p>
        <p>
            <asp:Button ID="postJobButton" runat="server" OnClick="postJobButton_Click" Text="Post Job" />
        </p>
        <p>
            <asp:Button ID="alreadyPostedButton" runat="server" OnClick="alreadyPostedButton_Click" Text="Already  Posted Job" />
        </p>
        <p>
            <asp:Button ID="selectedJobSeekerButton" runat="server" OnClick="selectedJobSeekerButton_Click" Text="Selected JobSeeker/ Working Candidate" />
        </p>
        <p>
            <asp:Button ID="completeJobFromWorkingListButton" runat="server" Text="Complete Job From Working List" OnClick="completeJobFromWorkingListButton_Click" />
        </p>
        <p>
            <asp:Button ID="viewProfileButton" runat="server" OnClick="viewProfileButton_Click" Text="View Profile" />
        </p>
        <p>
            <asp:Button ID="msgNotificationButton" runat="server" OnClick="msgNotificationButton_Click" Text="Message Notification" />
        </p>
        <p>
            <asp:Button ID="sendMsgButton" runat="server" OnClick="sendMsgButton_Click" Text="Send Message" />
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Dashboard" />
    
    </div>
    </form>
</body>
</html>
