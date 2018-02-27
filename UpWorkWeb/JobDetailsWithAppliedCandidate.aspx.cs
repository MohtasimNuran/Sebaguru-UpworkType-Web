using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class JobDetailsWithAppliedCandidate : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var jobCode = Session["JobCode"].ToString();

            //typeLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Type).ToList().LastOrDefault();
            //locationLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Location).ToList().LastOrDefault();
            //categoryLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Category).ToList().LastOrDefault();
            //jobResponsibilityLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.JobResponsibility).ToList().LastOrDefault();
            //detailsLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Message).ToList().LastOrDefault();
            //coverImage.ImageUrl = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.CoverPhoto).ToList().LastOrDefault();
            //paymentLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Payment).ToList().LastOrDefault();

            var jobDetails = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x).ToList().LastOrDefault();

            typeLabel.Text = jobDetails.Type;
            locationLabel.Text = jobDetails.Location;
            categoryLabel.Text = jobDetails.Category;
            jobResponsibilityLabel.Text = jobDetails.JobResponsibility;
            detailsLabel.Text = jobDetails.Message;
            coverImage.ImageUrl = jobDetails.CoverPhoto;
            paymentLabel.Text = jobDetails.Payment;

            jobCodeLabel.Text = jobCode;
            deadLineLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.DeadLineDate).ToList().LastOrDefault().ToString();
            var jobTitle = db.PostJobs.Where(y => y.JobCode == jobCode).Select(y => y.JobTitle).ToList().LastOrDefault();
            var appliedCandidateList = db.AppliedJobSeekers.Where(x => x.PostJob.JobCode == jobCode).Select(x => new
            {
                JobCode = jobCode,
                JobTitle = jobTitle,
                Picture = x.JobSeeker.Picture,
                Full_Name = x.JobSeeker.Full_Name,
                Email = x.JobSeeker.Email
            }).ToList();

            Repeater2.DataSource = appliedCandidateList;
            Repeater2.DataBind();

            var email = Session["Email"].ToString();
            //profile image
            //profieImage.ImageUrl = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
        }

        protected void Repeater2_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Session["EmailForProfile"] = e.CommandArgument.ToString();
            Response.Redirect("ProfileViewForOthers.aspx");
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