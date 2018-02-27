using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class CompleteJobListForJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();
            var jobId = Session["JobId"].ToString();
            if ( jobId== "CompanyId")
            {
                var selectedJobSeekerList =
                    db.SelectedJobSeekers.Where(x => x.PostJob.JobProviderCompany.CompanyEmail == email && x.Status == "complete").Select(x => new
                    {
                        JobCode = x.PostJob.JobCode,
                        JobTitle = x.PostJob.JobTitle,
                        Category = x.PostJob.Category,
                        FullName = x.JobSeeker.Full_Name,
                        Email = x.JobSeeker.Email,
                        Phone = x.JobSeeker.Phone,
                        Picture = x.JobSeeker.Picture
                    }).ToList();
                //completeJobListGridView.DataSource = selectedJobSeekerList;
                //completeJobListGridView.DataBind();
                Repeater2.DataSource = selectedJobSeekerList;
                Repeater2.DataBind();

                //profile image
                var profileImg = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.CompanyLogo).ToList().LastOrDefault();
                //profieImage.ImageUrl = profileImg;

            }
            else if (jobId == "PersonalId")
            {
                var selectedJobSeekerList =
                    db.SelectedJobSeekers.Where(x => x.PostJob.JobProviderPersonal.Email == email && x.Status == "complete").Select(x => new
                    {
                        JobCode = x.PostJob.JobCode,
                        JobTitle = x.PostJob.JobTitle,
                        Category = x.PostJob.Category,
                        FullName = x.JobSeeker.Full_Name,
                        Email = x.JobSeeker.Email,
                        Phone = x.JobSeeker.Phone,
                        Picture = x.JobSeeker.Picture
                    }).ToList();
                //completeJobListGridView.DataSource = selectedJobSeekerList;
                //completeJobListGridView.DataBind();
                Repeater2.DataSource = selectedJobSeekerList;
                Repeater2.DataBind();

                //profile image
                var profileImg = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
                //profieImage.ImageUrl = profileImg;
            }
        }


        protected void Repeater2_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {

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