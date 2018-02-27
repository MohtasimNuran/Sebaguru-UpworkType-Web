using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace UpWorkWeb
{
    public partial class PostedJobListForJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        private string jobId;
        protected void Page_Load(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();
            jobId = Session["JobId"].ToString();
            if (jobId == "PersonalId")
            {
                var id = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Id).ToList().LastOrDefault();
                ViewState["Id"] = id;
                var postedJobList = db.PostJobs.Where(x => x.PersonalId == id).Select(x => new
                {
                    JobCode = x.JobCode,
                    JobResponsibility = x.JobResponsibility,
                    Type = x.Type,
                    Location = x.Location,
                    CoverPhoto = x.CoverPhoto,
                    Category = x.Category,
                    Payment = x.Payment,
                    Count = x.AppliedJobSeekers.Count(y => y.PostJob.Id == y.PostJobId),
                    DeadLineDate = x.DeadLineDate,
                    RegDate = x.RegDate,
                    Per = x.Per

                }).ToList();
                Repeater2.DataSource = postedJobList;
                Repeater2.DataBind();

                //profile image
                var profileImg = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
                //profieImage.ImageUrl = profileImg;
            }
            else if (jobId == "CompanyId")
            {
                var id = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.Id).ToList().LastOrDefault();
                ViewState["Id"] = id;
                //var postedJobList = db.PostJobs.Where(x => x.CompanyId == id).Select(x => x).ToList();
                var postedJobList = db.PostJobs.Where(x => x.CompanyId == id).Select(x => new
                {
                    JobCode = x.JobCode,
                    JobResponsibility = x.JobResponsibility,
                    Type = x.Type,
                    Location = x.Location,
                    CoverPhoto = x.CoverPhoto,
                    Category = x.Category,
                    Payment = x.Payment,
                    Count = x.AppliedJobSeekers.Count(y => y.PostJob.Id == y.PostJobId),
                    DeadLineDate = x.DeadLineDate,
                    RegDate = x.RegDate,
                    Per = x.Per

                }).ToList();
                Repeater2.DataSource = postedJobList;
                Repeater2.DataBind();

                //profile image
                var profileImg = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.CompanyLogo).ToList().LastOrDefault();
                //profieImage.ImageUrl = profileImg;
            }
        }
        protected void Repeater2_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var jobCode = e.CommandName.ToString();
            if (jobCode != "")
            {
                Session["JobCode"] = jobCode;
                Response.Redirect("EditPostJobProvider.aspx");
                //Response.Write(jobCode);
            }
            else
            {
                Session["JobCode"] = e.CommandArgument.ToString();
                Response.Redirect("AppliedCandidateListForJobProvider.aspx");
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