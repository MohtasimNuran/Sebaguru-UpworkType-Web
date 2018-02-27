using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class MenuJobProvider : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void jobListButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobList.aspx");
        }

        protected void postJobButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("PostJobByJobProvider.aspx");
        }

        protected void alreadyPostedButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("PostedJobListForJobProvider.aspx");
        }

        protected void viewProfileButton_Click(object sender, EventArgs e)
        {
            if (Session["JobId"].ToString() == "PersonalId")
            {
                Response.Redirect("ProfileViewSelfJobProviderPersonal.aspx");
            }
            else if (Session["JobId"].ToString() == "CompanyId")
            {
                Response.Redirect("ProfileViewSelfJobProviderCompany.aspx");
            }
        }

        protected void selectedJobSeekerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectedJobSeekerListForJobProvider.aspx");
            //Response.Redirect("RepeaterWithjQueryPopup.aspx");
        }

        protected void completeJobFromWorkingListButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompleteJobListForJobProvider.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DashBoardJobProvider.aspx");
        }

        protected void sendMsgButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("MessageJobProvider.aspx");
        }

        protected void msgNotificationButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("MessageNotification.aspx");
        }
    }
}