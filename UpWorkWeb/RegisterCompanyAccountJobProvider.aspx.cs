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
    public partial class RegisterCompanyAccountJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        JobProviderCompany jobProviderCompany = new JobProviderCompany();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                countryDropDownList.DataSource = CountryList();
                countryDropDownList.DataBind();

            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string path = Server.MapPath("Images/");
                if (db.JobSeekers.Any(x => x.Email == emailTextBox.Text || db.JobProviderCompanies.Any(y => y.CompanyEmail == emailTextBox.Text) || db.JobProviderPersonals.Any(z => z.Email == emailTextBox.Text)))
                {
                    Response.Write("<script>alert('This email already exists!!!');</script>");
                }
                else
                {


                    if (FileUpload1.HasFile && FileUpload2.HasFile)
                    {
                        string ext = Path.GetExtension(FileUpload1.FileName);
                        string extLogo = Path.GetExtension(FileUpload2.FileName);

                        if (ext == ".jpg" || ext == ".png" || extLogo == ".jpg" || extLogo == ".png")
                        {
                            FileUpload1.SaveAs(path + FileUpload1.FileName);
                            string img = "Images/" + FileUpload1.FileName;
                            FileUpload2.SaveAs(path + FileUpload2.FileName);
                            string imgLogo = "Images/" + FileUpload2.FileName;

                            jobProviderCompany.CompanyName = companyNameTextBox.Text;
                            jobProviderCompany.CompanyEmail = emailTextBox.Text;
                            jobProviderCompany.Password = passwordTextBox.Text;
                            jobProviderCompany.RegistrationNumber = regNoTextBox.Text;
                            jobProviderCompany.Phone = phnTextBox.Text;
                            jobProviderCompany.Country = countryDropDownList.SelectedValue;
                            jobProviderCompany.CompanyWebsite = websiteTextBox.Text;
                            jobProviderCompany.RegistrationCopy = img;
                            jobProviderCompany.CompanyLogo = imgLogo;
                            jobProviderCompany.Location = locationTextBox.Text;
                            jobProviderCompany.Type = typeDropDownList.SelectedValue;
                            jobProviderCompany.PaymentProcedure = paymentProcedureDropDownList.SelectedValue;
                            jobProviderCompany.Rate = rateTextBox.Text;

                            var num = db.JobProviderPersonals.Select(x => x).ToList();
                            string code = string.Format("{0:D3}", num.Count + 1);
                            jobProviderCompany.CompanyCode = companyNameTextBox.Text + countryDropDownList.SelectedValue + code;
                            jobProviderCompany.RegDate = DateTime.Now.ToShortDateString();
                            db.JobProviderCompanies.Add(jobProviderCompany);
                            db.SaveChanges();
                            Response.Write("<script>alert('Saved Successfully!!!');</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Upload jpg or png format!!!');</script>");
                        }
                    }

                    else
                    {
                        Response.Write("<script>alert('Upload first!!!');</script>");
                    }
                }
            }
            else
            {

                Response.Write("<script>alert('Enter data for every input field!!!');</script>");

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