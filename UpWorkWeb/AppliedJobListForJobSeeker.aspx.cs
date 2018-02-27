using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class AppliedJobListForJobSeeker : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();
            var jobId = Session["JobId"].ToString();
            //profile image
            //profieImage.ImageUrl = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();


            var appliedJobList = db.AppliedJobSeekers.Where(x => x.JobSeeker.Email == email).Select(x => new
            {
                JobCode = x.PostJob.JobCode,
                JobTitle = x.PostJob.JobTitle,
                Type = x.PostJob.Type,
                Location = x.PostJob.Location,
                Category = x.PostJob.Category,
                DeadLineDate = x.PostJob.DeadLineDate,
                Payment = x.PostJob.Payment,
                CoverPhoto = x.PostJob.CoverPhoto,
                Count = db.AppliedJobSeekers.Count(y => y.PostJobId == x.PostJobId),
                //Picture = db.AppliedJobSeekers.Where(z => z.PostJob.JobCode == x.PostJob.JobCode).Select(z => z.JobSeeker.Picture).ToList(),

            }).ToList();

            Repeater2.DataSource = appliedJobList;
            Repeater2.DataBind();



        }


        protected void Repeater2_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var jobCode = e.CommandName.ToString();
            if (jobCode != "")
            {
                Session["JobCode"] = jobCode;
                Response.Redirect("JobDetailsWithAppliedCandidate.aspx");
                //Response.Write(jobCode);
            }
            else
            {
                Session["JobCode"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithAppliedCandidate.aspx");
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