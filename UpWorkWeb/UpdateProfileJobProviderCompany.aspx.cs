using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class UpdateProfileJobProviderCompany : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        JobProviderCompany jobProviderCompany = new JobProviderCompany();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //dropdown country
                countryDropDownList.DataSource = CountryList();
                countryDropDownList.DataBind();

                var email = Session["Email"].ToString();
                var jodId = Session["JobId"].ToString();
                if (jodId == "PersonalId")
                {
                    Response.Redirect("UpdateProfileJobProviderPersonel.aspx");
                }
                else if (jodId == "CompanyId")
                {
                    var aJobProviderCompany =
                    db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x).ToList().LastOrDefault();

                    profileImage.ImageUrl = aJobProviderCompany.CompanyLogo;
                    nameLabel.Text = aJobProviderCompany.CompanyName;
                    companyNameTextBox.Text = aJobProviderCompany.CompanyName;
                    emailTextBox.Text = aJobProviderCompany.CompanyEmail;
                    phnTextBox.Text = aJobProviderCompany.Phone;
                    countryDropDownList.SelectedValue = aJobProviderCompany.Country;
                    websiteTextBox.Text = aJobProviderCompany.CompanyWebsite;
                    locationTextBox.Text = aJobProviderCompany.Location;
                    typeDropDownList.SelectedValue = aJobProviderCompany.Type;
                    paymentProcedureDropDownList.SelectedValue = aJobProviderCompany.PaymentProcedure;
                    rateTextBox.Text = aJobProviderCompany.Rate;


                }

            }
        }

        protected void editButton_OnClick(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();
            jobProviderCompany = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x).ToList().LastOrDefault();

            if (FileUpload1.HasFile)
            {
                string ext = Path.GetExtension(FileUpload1.FileName);

                if (ext == ".jpg" || ext == ".png")
                {
                    string path = Server.MapPath("Images/");
                    FileUpload1.SaveAs(path + FileUpload1.FileName);
                    string img = "Images/" + FileUpload1.FileName;
                    jobProviderCompany.CompanyLogo = img;

                    jobProviderCompany.CompanyName = companyNameTextBox.Text;
                    jobProviderCompany.CompanyEmail = emailTextBox.Text;
                    jobProviderCompany.Phone = phnTextBox.Text;
                    jobProviderCompany.Country = countryDropDownList.SelectedValue;
                    jobProviderCompany.CompanyWebsite = websiteTextBox.Text;
                    jobProviderCompany.Location = locationTextBox.Text;
                    jobProviderCompany.Type = typeDropDownList.SelectedValue;
                    jobProviderCompany.PaymentProcedure = paymentProcedureDropDownList.SelectedValue;
                    jobProviderCompany.Rate = rateTextBox.Text;

                    db.SaveChanges();
                    Response.Write("<script>alert('Profile Updated  ! ! !');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Upload jpg or png format!!!');</script>");
                }
            }
            else
            {
                jobProviderCompany.CompanyName = companyNameTextBox.Text;
                jobProviderCompany.CompanyEmail = emailTextBox.Text;
                jobProviderCompany.Phone = phnTextBox.Text;
                jobProviderCompany.Country = countryDropDownList.SelectedValue;
                jobProviderCompany.CompanyWebsite = websiteTextBox.Text;
                jobProviderCompany.Location = locationTextBox.Text;
                jobProviderCompany.Type = typeDropDownList.SelectedValue;
                jobProviderCompany.PaymentProcedure = paymentProcedureDropDownList.SelectedValue;
                jobProviderCompany.Rate = rateTextBox.Text;

                db.SaveChanges();
                Response.Write("<script>alert('Profile Updated  ! ! !');</script>");
            }
            
        }

        public static List<string> CountryList()
        {
            //Creating list
            List<string> CultureList = new List<string>();

            //getting  the specific  CultureInfo from CultureInfo class
            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo getCulture in getCultureInfo)
            {
                //creating the object of RegionInfo class
                RegionInfo GetRegionInfo = new RegionInfo(getCulture.LCID);
                //adding each county Name into the arraylist
                if (!(CultureList.Contains(GetRegionInfo.EnglishName)))
                {
                    CultureList.Add(GetRegionInfo.EnglishName);
                }
            }
            //sorting array by using sort method to get countries in order
            CultureList.Sort();
            //returning country list
            return CultureList;
        }
    }
}