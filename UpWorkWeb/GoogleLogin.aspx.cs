using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UpWorkWeb.Model;

namespace UpWorkWeb
{
    public partial class GoogleLogin : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        JobSeeker jobSeeker = new JobSeeker();
        protected void Page_Load(object sender, EventArgs e)
        {
            GoogleProfile googleProfile = (GoogleProfile)Session["GoogleUser"];

            if (!IsPostBack)
            {
                var emailGoogle = googleProfile.Emails.Find(email => email.Type == "account").Value;

                if (db.JobSeekers.Any(x => x.Email == emailGoogle))
                {
                    Session["Email"] = emailGoogle;
                    Session["JobId"] = "JobSeeker";
                    Response.Redirect("MenuJobSeeker.aspx");
                }
                else
                {
                    nameLabel.Text = googleProfile.DisplayName;
                    emailLabel.Text = googleProfile.Emails.Find(email => email.Type == "account").Value;
                    genderLabel.Text = googleProfile.Gender;
                    Image1.ImageUrl = googleProfile.Image.Url;
                    googleIdLabel.Text = googleProfile.Id;
                    Response.Write("<script>alert('We have got some basic info, we need further more information to complete registration for security purpose, please co-operate us...Thank You!!!');</script>");
                }
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            GoogleProfile googleProfile = (GoogleProfile)Session["GoogleUser"];
            var mail = googleProfile.Emails.Find(email => email.Type == "account").Value;
            if (Page.IsValid)
            {
                if (
                    db.JobSeekers.Any(
                        x =>
                            x.Email == mail ||
                            db.JobProviderCompanies.Any(y => y.CompanyEmail == mail) ||
                            db.JobProviderPersonals.Any(z => z.Email == mail)))
                {
                    Response.Write("<script>alert('This email already exists!!!');</script>");
                }
                else
                {
                    jobSeeker.Full_Name = googleProfile.DisplayName;
                    jobSeeker.Email = googleProfile.Emails.Find(email => email.Type == "account").Value;
                    ;
                    jobSeeker.Birthdate = Request.Form["birthDateTextBox"];
                    jobSeeker.Phone = phnTextBox.Text;
                    jobSeeker.Gender = googleProfile.Gender;
                    jobSeeker.Nationnality = nationnalityTextBox.Text;
                    jobSeeker.Picture = googleProfile.Image.Url;
                    jobSeeker.Category = categoryDropDownList.SelectedValue;
                    jobSeeker.CommentBox = commentTextBox.Text;
                    var num = db.JobSeekers.Select(x => x).ToList();
                    string code = string.Format("{0:D3}", num.Count + 1);
                    jobSeeker.JobSeekerCode = categoryDropDownList.SelectedValue + code;
                    jobSeeker.RegDate = DateTime.Now.ToShortDateString();
                    jobSeeker.Password = passwordTextBox.Text;
                    db.JobSeekers.Add(jobSeeker);
                    db.SaveChanges();
                    Response.Write("<script>alert('Account Successfully Created!!!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Give the required data!!');</script>");
            }

        }
    }
}