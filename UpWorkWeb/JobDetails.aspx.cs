using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class JobDetails : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        AppliedJobSeeker appliedJobSeeker = new AppliedJobSeeker();
        private string jobId;
        protected void Page_Load(object sender, EventArgs e)
        {
            var jobCode = Session["JobCode"].ToString();
            var email = Session["Email"].ToString();
            DateTime now = DateTime.Now.Date;

            //profile image
            //profieImage.ImageUrl = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();

            var jobDetails = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x).ToList().LastOrDefault();

            typeLabel.Text = jobDetails.Type;
            locationLabel.Text = jobDetails.Location;
            categoryLabel.Text = jobDetails.Category;
            jobResponsibilityLabel.Text = jobDetails.JobResponsibility;
            detailsLabel.Text = jobDetails.Message;
            coverImage.ImageUrl = jobDetails.CoverPhoto;
            paymentLabel.Text = jobDetails.Payment;
            jobCodeLabel.Text = jobCode;
            regLabel.Text = jobDetails.RegDate.ToString();
            deadLineLabel.Text = jobDetails.DeadLineDate.ToString();
            nameLabel.Text = jobDetails.JobTitle;
            jobTitleLabel.Text = nameLabel.Text;
            perLabel.Text = jobDetails.Per;

            //postedIdLinkButton.Text = jobDetails.JobProviderCompany.CompanyName;
            //postedIdPersonalLinkButton.Text = jobDetails.JobProviderPersonal.FullName;


            //typeLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Type).ToList().LastOrDefault();
            //locationLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Location).ToList().LastOrDefault();
            //categoryLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Category).ToList().LastOrDefault();
            //jobResponsibilityLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.JobResponsibility).ToList().LastOrDefault();
            //detailsLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Message).ToList().LastOrDefault();
            //coverImage.ImageUrl = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.CoverPhoto).ToList().LastOrDefault();
            //paymentLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Payment).ToList().LastOrDefault();
            //jobCodeLabel.Text = jobCode;
            //regLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.RegDate).ToList().LastOrDefault().ToString();
            //deadLineLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.DeadLineDate).ToList().LastOrDefault().ToString();
            //nameLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.JobTitle).ToList().LastOrDefault();
            //jobTitleLabel.Text = nameLabel.Text;
            //perLabel.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Per).ToList().LastOrDefault();

            postedIdLinkButton.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.JobProviderCompany.CompanyName).ToList().LastOrDefault();
            postedIdPersonalLinkButton.Text = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.JobProviderPersonal.FullName).ToList().LastOrDefault();
        }

        protected void applyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["Email"] as string))  //not null
            {
                var email = Session["Email"].ToString();
                jobId = Session["JobId"].ToString();
                if (jobId == "PersonalId")
                {
                    Response.Write("<script>alert('Sorry!! You are not eligible, You logged in as a job provider ID, you must have to log in as a job seeker!!!');</script>");
                }
                else if (jobId == "CompanyId")
                {
                    Response.Write("<script>alert('Sorry!! You are not eligible, You logged in as a job provider ID, you must have to log in as a job seeker!!!');</script>");
                }
                else if (jobId == "JobSeeker")
                {
                    var jobCode = Session["JobCode"].ToString();
                    var postJobId = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Id).ToList().LastOrDefault();
                    var jobSeekerId =
                        db.JobSeekers.Where(x => x.Email == email).Select(x => x.Id).ToList().LastOrDefault();
                    if (db.AppliedJobSeekers.Any(x => x.JobSeekerId == jobSeekerId && x.PostJobId == postJobId))
                    {
                        Response.Write("<script>alert('You have already applied for this job!!!');</script>");
                    }
                    else
                    {
                        if (db.PostJobs.Where(x => x.Id == postJobId).Select(x => x.DeadLineDate).ToList().LastOrDefault() > DateTime.Now.Date)
                        {
                            appliedJobSeeker.JobSeekerId = jobSeekerId;
                            appliedJobSeeker.PostJobId = postJobId;
                            appliedJobSeeker.YourSay = yourSayTextBox.Text;
                            db.AppliedJobSeekers.Add(appliedJobSeeker);
                            db.SaveChanges();
                            Response.Write("<script>alert('You have Successfully Applied for the job!!!');</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Deadline Date is over!!!');</script>");
                        }

                    }

                }
            }
            else  //if null
            {
                Response.Write("<script>alert('Please, Log in first!!! You have to Log in as Job Seeker!!!');</script>");
            }
        }

        protected void postedIdLinkButton_Click(object sender, EventArgs e)
        {
            var jobCode = Session["JobCode"].ToString();
            Session["CompanyId"] = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.CompanyId).ToList().LastOrDefault();
            Response.Redirect("ProfileViewOthersJobProviderCompany.aspx");
        }

        protected void postedIdPersonalLinkButton_OnClick(object sender, EventArgs e)
        {
            var jobCode = Session["JobCode"].ToString();
            Session["PersonalId"] = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.PersonalId).ToList().LastOrDefault();
            Response.Redirect("ProfileViewOthersJobProviderPersonal.aspx");
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