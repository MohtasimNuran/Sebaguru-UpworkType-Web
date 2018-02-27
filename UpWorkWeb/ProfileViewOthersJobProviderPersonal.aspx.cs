using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class ProfileViewOthersJobProviderPersonal : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var personalId = Convert.ToUInt32(Session["PersonalId"]);

            var aJobProviderPersonal = db.JobProviderPersonals.Where(x => x.Id == personalId).Select(x => x).ToList().LastOrDefault();

            nameLabel.Text = aJobProviderPersonal.FullName;
            personalNameLabel.Text = aJobProviderPersonal.FullName;
            regLabel.Text = aJobProviderPersonal.RegDate;
            phnLabel.Text = aJobProviderPersonal.Phone;
            genderCodeLabel.Text = aJobProviderPersonal.Gender;
            nationLabel.Text = aJobProviderPersonal.Nationnality;
            profileImage.ImageUrl = aJobProviderPersonal.Picture;
            jobProviderCodeLabel.Text = aJobProviderPersonal.JobProviderCode;
            emailLabel.Text = aJobProviderPersonal.Email;

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