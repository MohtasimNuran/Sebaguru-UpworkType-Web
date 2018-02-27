using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class ProfileViewForOthers : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var emailForProfile = Session["EmailForProfile"].ToString();
            
            profileImage.ImageUrl = db.JobSeekers.Where(x => x.Email == emailForProfile).Select(x => x.Picture).ToList().LastOrDefault();
            fullNameLabel.Text = db.JobSeekers.Where(x => x.Email == emailForProfile).Select(x => x.Full_Name).ToList().LastOrDefault();
            genderLabel.Text = db.JobSeekers.Where(x => x.Email == emailForProfile).Select(x => x.Gender).ToList().LastOrDefault();
            nationalityLabel.Text = db.JobSeekers.Where(x => x.Email == emailForProfile).Select(x => x.Nationnality).ToList().LastOrDefault();
            categoryLabel.Text = db.JobSeekers.Where(x => x.Email == emailForProfile).Select(x => x.Category).ToList().LastOrDefault();
            emailLabel.Text = db.JobSeekers.Where(x => x.Email == emailForProfile).Select(x => x.Email).ToList().LastOrDefault();
            regDateLabel.Text = db.JobSeekers.Where(x => x.Email == emailForProfile).Select(x => x.RegDate).ToList().LastOrDefault();
            nameLabel.Text = db.JobSeekers.Where(x => x.Email == emailForProfile).Select(x => x.Full_Name).ToList().LastOrDefault();

            var email = Session["Email"].ToString();
            //profile image
            //profieImage.ImageUrl = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
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