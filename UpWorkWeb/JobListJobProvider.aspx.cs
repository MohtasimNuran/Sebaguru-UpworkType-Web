using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class JobListJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        DateTime now = DateTime.Now.Date;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var email = Session["Email"].ToString();
                var jobId = Session["JobId"].ToString();
                if (jobId == "PersonalId")
                {
                    var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderBy(x => x.RegDate).ThenBy(x => x.DeadLineDate).ToList();

                    Repeater2.DataSource = jobList;
                    Repeater2.DataBind();

                    //profile image
                    var profileImg = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
                    //profieImage.ImageUrl = profileImg;
                }
                else if (jobId == "CompanyId")
                {
                    var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderBy(x => x.RegDate).ThenBy(x => x.DeadLineDate).ToList();

                    Repeater2.DataSource = jobList;
                    Repeater2.DataBind();

                    //profile image
                    var profileImg = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.CompanyLogo).ToList().LastOrDefault();
                    //profieImage.ImageUrl = profileImg;
                }
            }
            
        }

        protected void Repeater2_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var jobId1 = Session["JobId"].ToString();

            if (jobId1 == "PersonalId")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApplyJobProvider.aspx");
            }
            else if (jobId1 == "CompanyId")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApplyJobProvider.aspx");
            }
            else if (jobId1 == "JobSeeker")
            {
                Session["JobCode"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetails.aspx");
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

        protected void categoryDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (categoryDropDownList.SelectedValue == "Category")
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
            else
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now && x.Category == categoryDropDownList.SelectedValue).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
        }

        protected void typeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeDropDownList.SelectedValue == "Type")
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
            else
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now && x.Type == typeDropDownList.SelectedValue).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
        }

        protected void timeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (timeDropDownList.SelectedValue == "Time")
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
            else
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now && x.Per == timeDropDownList.SelectedValue).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
        }
    }
}