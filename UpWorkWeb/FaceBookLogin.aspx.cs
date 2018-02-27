using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ASPSnippets.FaceBookAPI;
using UpWorkWeb.Model;

namespace UpWorkWeb
{
    public partial class FaceBookLogin : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        JobSeeker jobSeeker = new JobSeeker();
        protected void Page_Load(object sender, EventArgs e)
        {
            FaceBookUser faceBookUser = (FaceBookUser)Session["FaceBookUser"];

            if (!IsPostBack)
            {
                var emailFacebook = faceBookUser.Email;

                if (db.JobSeekers.Any(x => x.Email == emailFacebook))
                {
                    Session["Email"] = emailFacebook;
                    Session["JobId"] = "JobSeeker";
                    Response.Redirect("MenuJobSeeker.aspx");
                }
                else
                {
                    nameLabel.Text = faceBookUser.Name;
                    emailLabel.Text = faceBookUser.Email;
                    genderLabel.Text = faceBookUser.Gender;
                    Image1.ImageUrl = faceBookUser.PictureUrl;
                    facebookIdLabel.Text = faceBookUser.Id;
                    Response.Write("<script>alert('We have got some basic info, we need further more information to complete registration for security purpose, please co-operate us...Thank You!!!');</script>");
                }
            }

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            FaceBookUser faceBookUser = (FaceBookUser)Session["FaceBookUser"];
            if (Page.IsValid)
            {
                if (
                    db.JobSeekers.Any(
                        x =>
                            x.Email == faceBookUser.Email ||
                            db.JobProviderCompanies.Any(y => y.CompanyEmail == faceBookUser.Email) ||
                            db.JobProviderPersonals.Any(z => z.Email == faceBookUser.Email)))
                {
                    Response.Write("<script>alert('This email already exists!!!');</script>");
                }
                else
                {
                    jobSeeker.Full_Name = faceBookUser.Name;
                    jobSeeker.Email = faceBookUser.Email;
                    jobSeeker.Birthdate = Request.Form["birthDateTextBox"];
                    jobSeeker.Phone = phnTextBox.Text;
                    jobSeeker.Gender = faceBookUser.Gender;
                    jobSeeker.Nationnality = nationnalityTextBox.Text;
                    jobSeeker.Picture = faceBookUser.PictureUrl;
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