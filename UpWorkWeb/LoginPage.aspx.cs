using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPSnippets.FaceBookAPI;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using ASPSnippets.GoogleAPI;
using UpWorkWeb.Model;

namespace UpWorkWeb
{
    public partial class LoginPage : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (string.IsNullOrEmpty(Session["Button"] as string))
                {
                    GetJobSeekerInfoByFaceBook();
                }

                else if (Session["Button"].ToString() == "Facebook")
                {
                    GetJobSeekerInfoByFaceBook();
                }
                else if (Session["Button"].ToString() == "Google")
                {
                    GetJobSeekerInfoByGoogle();
                }
            }

        }



        protected void loginButton_Click(object sender, EventArgs e)
        {
            var email = emailTextBox.Text;

            var password = passwordTextBox.Text;

            //var jobSeekerPassword = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Password).ToList().LastOrDefault();
            //var personalPassword =
            //    db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Password).ToList().LastOrDefault();
            //var companyPassword =
            //    db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.Password).ToList().LastOrDefault();


            if (db.JobSeekers.Any(x => x.Email == email))
            {
                var jobSeekerPassword = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Password).ToList().LastOrDefault();

                if (jobSeekerPassword == password)
                {
                    Session["Email"] = email;
                    Session["JobId"] = "JobSeeker";
                    Response.Redirect("DashBoardJobSeeker.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Check your password!!!');</script>");
                }
            }
            else if (db.JobProviderPersonals.Any(x => x.Email == email))
            {
                var personalPassword =
                db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Password).ToList().LastOrDefault();

                if (personalPassword == password)
                {
                    Session["Email"] = email;
                    Session["JobId"] = "PersonalId";
                    Response.Redirect("DashBoardJobProvider.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Check your password!!!');</script>");
                }
            }
            else if (db.JobProviderCompanies.Any(x => x.CompanyEmail == email))
            {
                var companyPassword =
                db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.Password).ToList().LastOrDefault();

                if (companyPassword == password)
                {
                    Session["Email"] = email;
                    Session["JobId"] = "CompanyId";
                    Response.Redirect("DashBoardJobProvider.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Check your password!!!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Email or UserName is not valid!!!');</script>");
            }
        }

        protected void facebookLoginButton_Click(object sender, EventArgs e)
        {
            Session["Button"] = "Facebook";
            FaceBookConnect.Authorize("user_photos,email", Request.Url.AbsoluteUri.Split('?')[0]);
        }
        private void GetJobSeekerInfoByFaceBook()
        {
            FaceBookConnect.API_Key = "1718221581809102";
            FaceBookConnect.API_Secret = "9e80ca1949c480a76bae2087cea8dc78";
            if (!IsPostBack)
            {
                if (Request.QueryString["error"] == "access_denied")
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('User has denied access.')", true);
                    return;
                }

                string code = Request.QueryString["code"];
                if (!string.IsNullOrEmpty(code))
                {
                    string data = FaceBookConnect.Fetch(code, "me?fields=id,name,email,gender,birthday");
                    FaceBookUser faceBookUser = new JavaScriptSerializer().Deserialize<FaceBookUser>(data);
                    faceBookUser.PictureUrl = string.Format("https://graph.facebook.com/{0}/picture", faceBookUser.Id);
                    //pnlFaceBookUser.Visible = true;
                    //lblId.Text = faceBookUser.Id;
                    ////lblUserName.Text = faceBookUser.UserName;
                    //lblName.Text = faceBookUser.Name;
                    //lblEmail.Text = faceBookUser.Email;
                    //genderLabel.Text = faceBookUser.Gender;
                    //birthdayLabel.Text = faceBookUser.Birthday;
                    //ProfileImage.ImageUrl = faceBookUser.PictureUrl;
                    //btnLogin.Enabled = false;
                    //MessageBox.Show(faceBookUser.Email + faceBookUser.Name + faceBookUser.UserName);
                    Session["FaceBookUser"] = faceBookUser;
                    Response.Redirect("FaceBookLogin.aspx");
                }
            }
        }

        protected void gmailLoginButton_Click(object sender, EventArgs e)
        {
            Session["Button"] = "Google";
            GoogleConnect.Authorize("profile", "email");
        }
        private void GetJobSeekerInfoByGoogle()
        {
            GoogleConnect.ClientId = "126813524212-ah32dmnbceakprf7j2u84rg9124la49c.apps.googleusercontent.com";
            GoogleConnect.ClientSecret = "xJ0yZij60f5XKKg3glvG05Hs";

            if (!IsPostBack)
            {
                GoogleConnect.RedirectUri = Request.Url.AbsoluteUri.Split('?')[0];

                if (!string.IsNullOrEmpty(Request.QueryString["code"]))
                {
                    string code = Request.QueryString["code"];
                    string json = GoogleConnect.Fetch("me", code);
                    GoogleProfile profile = new JavaScriptSerializer().Deserialize<GoogleProfile>(json);
                    //lblId.Text = profile.Id;
                    //lblName.Text = profile.DisplayName;
                    //lblEmail.Text = profile.Emails.Find(email => email.Type == "account").Value;
                    //lblGender.Text = profile.Gender;
                    //lblType.Text = profile.ObjectType;
                    //ProfileImage.ImageUrl = profile.Image.Url;
                    //pnlProfile.Visible = true;
                    //btnLogin.Enabled = false;
                    Session["GoogleUser"] = profile;
                    Response.Redirect("GoogleLogin.aspx");
                }
                if (Request.QueryString["error"] == "access_denied")
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Access denied would you like to try again.')", true);
                }
            }

        }


    }
}