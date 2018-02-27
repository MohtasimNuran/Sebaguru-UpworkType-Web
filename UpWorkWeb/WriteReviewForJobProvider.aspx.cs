using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class WriteReviewForJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        SelectedJobSeeker selectedJobSeeker = new SelectedJobSeeker();
        CompleteJob completeJob = new CompleteJob();
        Notification notification = new Notification();
        protected void Page_Load(object sender, EventArgs e)
        {
            var emailForReview = Session["EmailForReview"].ToString();
            var details = db.JobSeekers.Where(x => x.Email == emailForReview).Select(x => x).ToList().LastOrDefault();
            Image1.ImageUrl = details.Picture;
            nameLabel.Text = details.Full_Name;
            emailLabel.Text = details.Email;

            var reviewList = db.SelectedJobSeekers.Where(x => x.JobSeeker.Email == emailForReview).Select(x => new
            {
                Picture = x.PostJob.JobProviderPersonal.Picture,
                CompanyName = x.PostJob.JobProviderCompany.CompanyName,
                x.ReviewForComplete,
                x.ReviewForIncomplete,
                x.Status,
                JobCode = x.PostJob.JobCode,
                JobTitle = x.PostJob.JobTitle
            }).ToList();
            Repeater2.DataSource = reviewList;
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

        protected void saveButton_Click(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();
            var emailForReview = Session["EmailForReview"].ToString();
            var jobCode = Session["JobCode"].ToString();

            try
            {
                if (db.SelectedJobSeekers.Where(x => x.JobSeeker.Email == emailForReview && x.PostJob.JobCode == jobCode).Select(x => x.Status).ToList().LastOrDefault() == "complete")
                {
                    Response.Write("<script>alert('This job is already completed, You are not allowed to review now   ! ! !');</script>");
                }
                else
                {
                    selectedJobSeeker = db.SelectedJobSeekers.Where(x => x.JobSeeker.Email == emailForReview && x.PostJob.JobCode == jobCode).Select(x => x).First();
                    selectedJobSeeker.ReviewForIncomplete = reviewTextBox.Text;
                    selectedJobSeeker.Status = "incomplete";
                    db.SaveChanges();

                    //notification start
                    if (Session["JobId"].ToString() == "PersonalId")
                    {
                        var name = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.FullName).ToList().LastOrDefault();

                        notification.JobSeekerNotificationId = selectedJobSeeker.JobSeekerSelectedId;
                        notification.PostJobNotificationId = selectedJobSeeker.PostJobSelectedId;
                        notification.Comments = name + "---write review on your performed job---" + jobCode;
                        notification.Status = "unread";
                        notification.PostedDate = DateTime.Now;
                        db.Notifications.Add(notification);
                        db.SaveChanges();
                    }
                    else if (Session["JobId"].ToString() == "CompanyId")
                    {
                        var name = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.CompanyName).ToList().LastOrDefault();

                        notification.JobSeekerNotificationId = selectedJobSeeker.JobSeekerSelectedId;
                        notification.PostJobNotificationId = selectedJobSeeker.PostJobSelectedId;
                        notification.Comments = name + "---write review on your performed job---" + jobCode;
                        notification.Status = "unread";
                        notification.PostedDate = DateTime.Now;
                        db.Notifications.Add(notification);
                        db.SaveChanges();
                    }
                    //notification end


                    Response.Write("<script>alert('Updated  ! ! !');</script>");
                    Response.Redirect("WriteReviewForJobProvider.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Something Went wrong !!! ');</script>");
            }
        }

        protected void completeJobButton_Click(object sender, EventArgs e)
        {
            var email = Session["EmailForReview"].ToString();

            try
            {
                if (db.SelectedJobSeekers.Where(x => x.JobSeeker.Email == email).Select(x => x.Status).ToList().LastOrDefault() == "complete")
                {
                    Response.Write("<script>alert('This job is already completed, you are not allowed to review anymore  ! ! !');</script>");
                }
                else
                {
                    selectedJobSeeker = db.SelectedJobSeekers.Where(x => x.JobSeeker.Email == email).Select(x => x).First();
                    selectedJobSeeker.ReviewForComplete = reviewTextBox.Text;
                    selectedJobSeeker.Status = "complete";
                    db.SaveChanges();

                    //notification
                    notification.JobSeekerNotificationId = selectedJobSeeker.JobSeekerSelectedId;
                    notification.PostJobNotificationId = selectedJobSeeker.PostJobSelectedId;
                    var jobCode = Session["JobCode"].ToString();
                    notification.Comments = jobCode + "---write review on your performance and complete your job";
                    notification.Status = "unread";
                    notification.PostedDate = DateTime.Now;
                    db.Notifications.Add(notification);
                    db.SaveChanges();


                    Response.Write("<script>alert('Updated  ! ! !');</script>");
                    Response.Redirect("WriteReviewForJobProvider.aspx");
                }

            }
            catch (Exception)
            {
                Response.Write("<script>alert('Something Went wrong !!! ');</script>");
            }
        }

        protected void Repeater2_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "JobTitle")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApplyJobProvider.aspx");
            }
            else if (e.CommandName == "JobCode")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApplyJobProvider.aspx");
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