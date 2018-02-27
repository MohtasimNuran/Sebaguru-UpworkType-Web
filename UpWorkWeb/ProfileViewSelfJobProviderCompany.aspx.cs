using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class ProfileViewSelfJobProviderCompany : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var email = Session["Email"].ToString();
                var jodId = Session["JobId"].ToString();
                if (jodId == "PersonalId")
                {
                    Response.Redirect("ProfileViewSelfJobProviderPersonal.aspx");
                }
                else if (jodId == "CompanyId")
                {
                    var aJobProviderCompany =
                    db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x).ToList().LastOrDefault();

                    profileImage.ImageUrl = aJobProviderCompany.CompanyLogo;
                    nameLabel.Text = aJobProviderCompany.CompanyName;
                    companyNameLabel.Text = aJobProviderCompany.CompanyName;
                    emailLabel.Text = aJobProviderCompany.CompanyEmail;
                    regLabel.Text = aJobProviderCompany.RegistrationNumber;
                    phnLabel.Text = aJobProviderCompany.Phone;
                    countryLabel.Text = aJobProviderCompany.Country;
                    companyCodeLabel.Text = aJobProviderCompany.CompanyCode;
                    regImage.ImageUrl = aJobProviderCompany.RegistrationCopy;
                    websiteLabel.Text = aJobProviderCompany.CompanyWebsite;
                    regDateLabel.Text = aJobProviderCompany.RegDate;
                    locationLabel.Text = aJobProviderCompany.Location;
                    typeLabel.Text = aJobProviderCompany.Type;
                    paymentLabel.Text = aJobProviderCompany.PaymentProcedure;
                    rateLabel.Text = aJobProviderCompany.Rate;


                }

            }
        }

    }
}