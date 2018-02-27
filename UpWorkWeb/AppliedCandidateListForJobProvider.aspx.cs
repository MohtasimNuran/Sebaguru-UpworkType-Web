using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class AppliedCandidateListForJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        SelectedJobSeeker selectedJobSeeker = new SelectedJobSeeker();
        Notification notification = new Notification();
        protected void Page_Load(object sender, EventArgs e)
        {
            var jobCode = Session["JobCode"].ToString();
            var postJobId = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Id).ToList().LastOrDefault();

            var appliedJobseekerList = db.AppliedJobSeekers.Where(x => x.PostJobId == postJobId).Select(x => new
            {
                FullName = x.JobSeeker.Full_Name,
                Email = x.JobSeeker.Email,
                YourSay = x.YourSay,
                JobCode = x.PostJob.JobCode,
                Picture = x.JobSeeker.Picture,
                Phone = x.JobSeeker.Phone,
                DeadLine = x.PostJob.DeadLineDate
            }).ToList();
            Repeater2.DataSource = appliedJobseekerList;
            Repeater2.DataBind();

            var email = Session["Email"].ToString();
            var jobId = Session["JobId"].ToString();
            if (jobId == "PersonalId")
            {
                //profile image
                var profileImg = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
                //profieImage.ImageUrl = profileImg;
            }
            else if (jobId == "CompanyId")
            {
                //profile image
                var profileImg = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.CompanyLogo).ToList().LastOrDefault();
                //profieImage.ImageUrl = profileImg;
            }
        }

        protected void Repeater2_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var jobSeekerEmail = e.CommandName.ToString();
            if (jobSeekerEmail != "")
            {
                Session["JobSeekerEmail"] = jobSeekerEmail;
                Response.Redirect("AppliedCandidateDetails.aspx");
            }
            else
            {
                DateTime now = DateTime.Now.Date;

                var jobCode = Session["JobCode"].ToString();

                jobSeekerEmail = e.CommandArgument.ToString();

                Session["JobSeekerEmail"] = jobSeekerEmail;

                if (now > db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.DeadLineDate).ToList().LastOrDefault())
                {
                    var postJobId = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Id).ToList().LastOrDefault();
                    var jobSeekerId = db.JobSeekers.Where(x => x.Email == jobSeekerEmail).Select(x => x.Id).ToList().LastOrDefault();
                    if (db.SelectedJobSeekers.Any(x => x.JobSeekerSelectedId == jobSeekerId && x.PostJobSelectedId == postJobId))
                    {
                        Response.Write("<script>alert('This Candidate is Already Selected!!!');</script>");
                    }
                    else
                    {
                        selectedJobSeeker.JobSeekerSelectedId = jobSeekerId;
                        selectedJobSeeker.PostJobSelectedId = postJobId;
                        selectedJobSeeker.Status = "incomplete";
                        db.SelectedJobSeekers.Add(selectedJobSeeker);
                        db.SaveChanges();

                        //notification
                        notification.JobSeekerNotificationId = jobSeekerId;
                        notification.PostJobNotificationId = postJobId;
                        notification.Comments = "You are selected for the job-" + jobCode;
                        notification.Status = "unread";
                        notification.PostedDate = DateTime.Now;
                        db.Notifications.Add(notification);
                        db.SaveChanges();

                        Response.Write("<script>alert('This Candidate is Selected Successfully!!!');</script>");

                    }
                }
                else
                {
                    Response.Write("<script>alert('You can select candidate after the deadline date!!!');</script>");
                }
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