using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace UpWorkWeb
{
    public partial class CompleteJobListForJobSeeker : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var email = Session["Email"].ToString();
                var selectedJobSeekerList =
                       db.SelectedJobSeekers.Where(x => x.JobSeeker.Email == email && x.Status == "complete").Select(x => new
                       {
                           x.PostJob.JobTitle,
                           x.PostJob.JobCode,
                           x.PostJob.CoverPhoto,
                           x.PostJob.Category,
                           x.PostJob.CompanyId,
                           x.PostJob.JobProviderCompany.CompanyName,
                           x.PostJob.PersonalId,
                           x.PostJob.JobProviderPersonal.FullName,
                           x.ReviewForComplete,
                           x.Status
                       }).ToList();
                Repeater2.DataSource = selectedJobSeekerList;
                Repeater2.DataBind();

                //profile image
                //profieImage.ImageUrl = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
            }


        }

        protected void Repeater2_OnItemCommand(object source, RepeaterCommandEventArgs e)
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
            else if (e.CommandName == "JobTitle")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApply.aspx");
            }
            else if (e.CommandName == "JobCode")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApply.aspx");
            }
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