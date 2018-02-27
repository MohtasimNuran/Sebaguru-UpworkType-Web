using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace UpWorkWeb
{
    public partial class SelectedJobSeekerListForJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        SelectedJobSeeker selectedJobSeeker = new SelectedJobSeeker();
        protected void Page_Load(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();
            var jobId = Session["JobId"].ToString();
            if (jobId == "CompanyId")
            {
                var selectedJobSeekerList =
                    db.SelectedJobSeekers.Where(x => x.PostJob.JobProviderCompany.CompanyEmail == email).Select(x => new
                    {
                        x.PostJob.JobCode,
                        x.JobSeeker.Full_Name,
                        x.JobSeeker.Email,
                        x.JobSeeker.Phone,
                        x.JobSeeker.Picture
                    }).ToList();
                //selectedJobSeekerListGridView.DataSource = selectedJobSeekerList;
                //selectedJobSeekerListGridView.DataBind();
                Repeater2.DataSource = selectedJobSeekerList;
                Repeater2.DataBind();

                //profile image
                var profileImg = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.CompanyLogo).ToList().LastOrDefault();
                //profieImage.ImageUrl = profileImg;
            }
            else if (jobId == "PersonalId")
            {
                var selectedJobSeekerList =
                    db.SelectedJobSeekers.Where(x => x.PostJob.JobProviderPersonal.Email == email).Select(x => new
                    {
                        x.PostJob.JobCode,
                        x.JobSeeker.Full_Name,
                        x.JobSeeker.Email,
                        x.JobSeeker.Phone,
                        x.JobSeeker.Picture
                    }).ToList();
                //selectedJobSeekerListGridView.DataSource = selectedJobSeekerList;
                //selectedJobSeekerListGridView.DataBind();
                Repeater2.DataSource = selectedJobSeekerList;
                Repeater2.DataBind();

                //profile image
                var profileImg = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
                //profieImage.ImageUrl = profileImg;
            }
        }

        protected void selectedJobSeekerListGridView_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(selectedJobSeekerListGridView, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void selectedJobSeekerListGridView_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = selectedJobSeekerListGridView.SelectedRow;
            string jobCode = row.Cells[0].Text;
            string selectefJobSeekerEmail = row.Cells[2].Text;
            //MessageBox.Show(jobCode);
            Session["JobCode"] = jobCode;
            Session["SelectedJobSeekerEmail"] = selectefJobSeekerEmail;
            Response.Redirect("");
        }

        protected void Repeater2_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {

            //var emailForReview = e.CommandName.ToString();
            //if (emailForReview != "")
            //{
            //    Session["EmailForReview"] = emailForReview;
            //    Response.Redirect("WriteReviewForJobProvider.aspx");
            //}
            //else
            //{
            //    Session["EmailForProfile"] = e.CommandArgument.ToString();
            //    Response.Redirect("ProfileViewForOthers.aspx");
            //}

            

            if (e.CommandName == "Review")
            {
                //Session["EmailForReview"] = e.CommandArgument.ToString();
                //Response.Redirect("WriteReviewForJobProvider.aspx");


                string info = e.CommandArgument.ToString();

                string[] arg = new string[2];

                char[] splitter = { ';' };

                arg = info.Split(splitter);

                Session["EmailForReview"] = arg[0];
                Session["JobCode"] = arg[1];
                Response.Redirect("WriteReviewForJobProvider.aspx");
            }
            else if (e.CommandName == "Profile")
            {
                Session["EmailForProfile"] = e.CommandArgument.ToString();
                Response.Redirect("ProfileViewForOthersJobProvider.aspx");
            }
        }


        [System.Web.Services.WebMethod]
        public static JobSeeker GetEmail(string email)
        {
            //UpWorkDBEntities db = new UpWorkDBEntities();


            //var emailForReview = db.Students.Where(x => x.Email.Contains(email)).Select(x => x).ToList().LastOrDefault();
            JobSeeker jobSeeker = new JobSeeker();
            jobSeeker.Email = email;

            return jobSeeker;
        }

        protected void saveButton_OnClick(object sender, EventArgs e)
        {
            var email = ViewState["EmailForReview"].ToString();

            try
            {
                selectedJobSeeker = db.SelectedJobSeekers.Where(x => x.JobSeeker.Email == email).Select(x => x).First();
                //selectedJobSeeker.Review = reviewTextBox.Text;
                db.SaveChanges();
                Response.Write("<script>alert('Updated  ! ! !');</script>");
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Something Went wrong !!! ');</script>");
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