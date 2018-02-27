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
    public partial class RegisterJobSeeker : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        JobSeeker jobSeeker = new JobSeeker();
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
                            jobSeeker.Full_Name = fullNameTextBox.Text;
                            jobSeeker.Email = emailTextBox.Text;
                            jobSeeker.Password = passwordTextBox.Text;
                            //jobSeeker.Birthdate = Request.Form["birthDateTextBox"];
                            jobSeeker.Birthdate = birthDateTextBox.Text;
                            jobSeeker.Phone = phnTextBox.Text;
                            jobSeeker.Gender = genderDropDownList.SelectedValue;
                            jobSeeker.Nationnality = nationnalityDropDownList.SelectedValue;
                            jobSeeker.Picture = img;
                            //jobSeeker.Category = categoryDropDownList.SelectedValue;
                            jobSeeker.CommentBox = commentBoxTextBox.Text;
                            jobSeeker.AvailableStart = availableStartTextBox.Text;
                            jobSeeker.AvailableEnd = availableEndTextBox.Text;
                            jobSeeker.Location = locationTextBox.Text;
                            jobSeeker.Type = typeDropDownList.SelectedValue;
                            jobSeeker.PaymentProcedure = paymentProcedureDropDownList.SelectedValue;
                            jobSeeker.Rate = rateTextBox.Text;

                            var num = db.JobSeekers.Select(x => x).ToList();
                            string code = string.Format("{0:D3}", num.Count + 1);
                            //jobSeeker.JobSeekerCode = categoryDropDownList.SelectedValue + code;
                            jobSeeker.JobSeekerCode = code;
                            jobSeeker.RegDate = DateTime.Now.ToShortDateString();
                            db.JobSeekers.Add(jobSeeker);
                            db.SaveChanges();
                            Response.Write("<script>alert('Saved Successfully!!!');</script>");
                            Session["RegisterEmail"] = jobSeeker.Email;
                            Response.Redirect("CategoryRegisterForJobSeeker.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('Upload jpg or png format!!!');</script>");
                        }
                    }

                    else
                    {
                        Response.Write("<script>alert('Upload profile picture or this email already exists!!!');</script>");
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