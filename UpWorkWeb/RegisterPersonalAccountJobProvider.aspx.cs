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
    public partial class RegisterPersonalAccountJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        JobProviderPersonal jobProviderPersonal = new JobProviderPersonal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                nationnalityDropDownList.DataSource = CountryList();
                nationnalityDropDownList.DataBind();

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
                    if (FileUpload1.HasFile)
                    {
                        string ext = Path.GetExtension(FileUpload1.FileName);

                        if (ext == ".jpg" || ext == ".png")
                        {
                            FileUpload1.SaveAs(path + FileUpload1.FileName);
                            string img = "Images/" + FileUpload1.FileName;
                            jobProviderPersonal.FullName = fullNameTextBox.Text;
                            jobProviderPersonal.Email = emailTextBox.Text;
                            jobProviderPersonal.Password = passwordTextBox.Text;
                            jobProviderPersonal.NID = nIDTextBox.Text;
                            jobProviderPersonal.PassportNumber = passportNumberTextBox.Text;
//                            jobProviderPersonal.BirthDate = Request.Form["birthDateTextBox"];
                            jobProviderPersonal.BirthDate = birthDateTextBox.Text;
                            jobProviderPersonal.RegDate = DateTime.Now.ToShortDateString();
                            jobProviderPersonal.Phone = phnTextBox.Text;
                            jobProviderPersonal.Gender = genderDropDownList.SelectedValue;
                            jobProviderPersonal.Nationnality = nationnalityDropDownList.SelectedValue;
                            jobProviderPersonal.Picture = img;
                            jobProviderPersonal.Location = locationTextBox.Text;
                            jobProviderPersonal.Type = typeDropDownList.SelectedValue;
                            jobProviderPersonal.PaymentProcedure = paymentProcedureDropDownList.SelectedValue;
                            jobProviderPersonal.Rate = rateTextBox.Text;

                            var num = db.JobProviderPersonals.Select(x => x).ToList();
                            string code = string.Format("{0:D3}", num.Count + 1);
                            jobProviderPersonal.JobProviderCode = fullNameTextBox.Text + code;

                            db.JobProviderPersonals.Add(jobProviderPersonal);
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