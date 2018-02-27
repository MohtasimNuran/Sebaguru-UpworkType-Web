using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class ProfileViewOthersJobProviderCompany : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(Session["CompanyId"]);

            var aCompanyDetails = db.JobProviderCompanies.Where(x => x.Id == companyId).Select(x => x).ToList().LastOrDefault();

            companyNameLabel.Text = aCompanyDetails.CompanyName;
            nameLabel.Text = aCompanyDetails.CompanyName;
            emailLabel.Text = aCompanyDetails.CompanyEmail;
            phnLabel.Text = aCompanyDetails.Phone;
            locationLabel.Text = aCompanyDetails.Location;
            companyCodeLabel.Text = aCompanyDetails.CompanyCode;
            websiteLabel.Text = aCompanyDetails.CompanyWebsite;
            regDateLabel.Text = aCompanyDetails.RegDate;
            profileImage.ImageUrl = aCompanyDetails.CompanyLogo;

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