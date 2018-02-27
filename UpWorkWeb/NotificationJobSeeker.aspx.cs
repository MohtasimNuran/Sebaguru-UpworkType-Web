using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class NotificationJobSeeker : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        Notification notification = new Notification();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var email = Session["Email"].ToString();

                var count = db.Notifications.Count(x => x.JobSeeker.Email == email && x.Status == "unread");

                var notificationList = db.Notifications.Where(x => x.JobSeeker.Email == email && x.Status == "unread").Select(x => new
                {
                    x.Comments,
                    x.PostJob.CompanyId,
                    x.PostJob.JobProviderCompany.CompanyName,
                    x.PostJob.PersonalId,
                    x.PostJob.JobProviderPersonal.FullName,
                    x.PostJob.JobCode,
                    x.PostedDate
                }).OrderByDescending(x => x.PostedDate).ToList();

                notificationRepeater.DataSource = notificationList;
                notificationRepeater.DataBind();

                //profile image
                //profieImage.ImageUrl = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
            }
            

        }

        protected void notificationRepeater_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "CompanyId")
            {
                Session["CompanyId"] = e.CommandArgument.ToString();
                Response.Redirect("ProfileViewOthersJobProviderCompany.aspx");
            }
            else if (e.CommandName == "PersonalId")
            {
                Session["PersonalId"] = e.CommandArgument.ToString();
                Response.Redirect("ProfileViewOthersJobProviderPersonal.aspx");
            }
            else if (e.CommandName == "Details")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApply.aspx");
            }
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();

            var notificationList = db.Notifications.Where(x => x.JobSeeker.Email == email && x.Status == "unread").Select(x => x).ToList();

            foreach (var aItem in notificationList)
            {
                aItem.Status = "read";
                db.SaveChanges();
                
            }
            Response.Redirect("NotificationJobSeeker.aspx");
        }

        protected void logOutButton_OnClick(object sender, EventArgs e)
        {
            Session["Email"] = "";
            Session["JobCode"] = "";
            Session["EmailForReview"] = "";
            Session["EmailForProfile"] = "";
            Response.Redirect("LoginPage.aspx");
        }
    }
}