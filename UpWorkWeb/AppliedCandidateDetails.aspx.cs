using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class AppliedCandidateDetails : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        SelectedJobSeeker selectedJobSeeker = new SelectedJobSeeker();
        Notification notification = new Notification();
        protected void Page_Load(object sender, EventArgs e)
        {
            var jobSeekerEmail = Session["JobSeekerEmail"].ToString();
            var jobCode = Session["JobCode"].ToString();
            var postJobId = db.PostJobs.Where(x => x.JobCode == jobCode).Select(x => x.Id).ToList().LastOrDefault();
            //var jobSeekerId = db.JobSeekers.Where(x => x.Email == jobSeekerEmail).Select(x => x.Id).ToList().LastOrDefault();


            fullNameLabel.Text = db.JobSeekers.Where(x => x.Email == jobSeekerEmail).Select(x => x.Full_Name).ToList().LastOrDefault();
            nameLabel.Text = fullNameLabel.Text;
            emailLabel.Text = db.JobSeekers.Where(x => x.Email == jobSeekerEmail).Select(x => x.Email).ToList().LastOrDefault();
            phnLabel.Text = db.JobSeekers.Where(x => x.Email == jobSeekerEmail).Select(x => x.Phone).ToList().LastOrDefault();
            genderLabel.Text = db.JobSeekers.Where(x => x.Email == jobSeekerEmail).Select(x => x.Gender).ToList().LastOrDefault();
            nationalityLabel.Text = db.JobSeekers.Where(x => x.Email == jobSeekerEmail).Select(x => x.Nationnality).ToList().LastOrDefault();
            commmentLabel.Text = db.JobSeekers.Where(x => x.Email == jobSeekerEmail).Select(x => x.CommentBox).ToList().LastOrDefault();
            categoryLabel.Text = db.JobSeekers.Where(x => x.Email == jobSeekerEmail).Select(x => x.Category).ToList().LastOrDefault();
            Image1.ImageUrl = db.JobSeekers.Where(x => x.Email == jobSeekerEmail).Select(x => x.Picture).ToList().LastOrDefault();
            yourSayLabel.Text =
                db.AppliedJobSeekers.Where(x => x.JobSeeker.Email == jobSeekerEmail && x.PostJobId == postJobId)
                    .Select(x => x.YourSay)
                    .ToList()
                    .LastOrDefault();
            regDateLabel.Text = db.JobSeekers.Where(x => x.Email == jobSeekerEmail).Select(x => x.RegDate).ToList().LastOrDefault();
            var selectedJobSeekerList =
                       db.SelectedJobSeekers.Where(x => x.JobSeeker.Email == jobSeekerEmail).Select(x => new
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
                           x.ReviewForIncomplete,
                           x.Status
                       }).ToList();
            Repeater2.DataSource = selectedJobSeekerList;
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

        protected void selectCandidateButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now.Date;
            var jobSeekerEmail = Session["JobSeekerEmail"].ToString();
            var jobCode = Session["JobCode"].ToString();

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