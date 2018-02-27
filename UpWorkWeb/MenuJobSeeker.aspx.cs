using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class MenuJobSeeker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void jobListButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobList.aspx");
        }

        protected void appliedJobListButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AppliedJobListForJobSeeker.aspx");
        }

        protected void myProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfileViewSelfJobSeeker.aspx");
        }

        protected void completeJobListButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompleteJobListForJobSeeker.aspx");
        }

        protected void workingJobListButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("WorkingJobListForJobSeeker.aspx");
        }

        protected void dashBoardButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("DashBoardJobSeeker.aspx");
        }

        protected void notificationButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("NotificationJobSeeker.aspx");
        }

        protected void msgNotificationButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("MessageNotification.aspx");
        }

        protected void sendMsgButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("MessageJobSeeker.aspx");
        }
    }
}