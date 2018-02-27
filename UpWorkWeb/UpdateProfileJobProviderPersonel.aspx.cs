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
    public partial class UpdateProfileJobProviderPersonel : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        JobProviderPersonal jobProviderPersonal = new JobProviderPersonal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                nationnalityDropDownList.DataSource = CountryList();
                nationnalityDropDownList.DataBind();

                var email = Session["Email"].ToString();
                var aJobProviderPersonal = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x).ToList().LastOrDefault();

                nameLabel.Text = aJobProviderPersonal.FullName;
                fullNameTextBox.Text = aJobProviderPersonal.FullName;
                nIDTextBox.Text = aJobProviderPersonal.NID;
                passportNumberTextBox.Text = aJobProviderPersonal.PassportNumber;
                birthDateTextBox.Text = aJobProviderPersonal.BirthDate;
                phnTextBox.Text = aJobProviderPersonal.Phone;
                genderDropDownList.SelectedValue = aJobProviderPersonal.Gender;
                nationnalityDropDownList.SelectedValue = aJobProviderPersonal.Nationnality;
                profileImage.ImageUrl = aJobProviderPersonal.Picture;
                emailTextBox.Text = aJobProviderPersonal.Email;
                locationTextBox.Text = aJobProviderPersonal.Location;
                typeDropDownList.SelectedValue = aJobProviderPersonal.Type;
                paymentProcedureDropDownList.SelectedValue = aJobProviderPersonal.PaymentProcedure;
                rateTextBox.Text = aJobProviderPersonal.Rate;

            }
        }

        protected void editButton_OnClick(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();
            jobProviderPersonal = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x).First();

            if (FileUpload1.HasFile)
            {
                string ext = Path.GetExtension(FileUpload1.FileName);

                if (ext == ".jpg" || ext == ".png")
                {
                    string path = Server.MapPath("Images/");
                    FileUpload1.SaveAs(path + FileUpload1.FileName);
                    string img = "Images/" + FileUpload1.FileName;
                    jobProviderPersonal.Picture = img;

                    jobProviderPersonal.FullName = fullNameTextBox.Text;
                    jobProviderPersonal.NID = nIDTextBox.Text;
                    jobProviderPersonal.PassportNumber = passportNumberTextBox.Text;
                    jobProviderPersonal.BirthDate = birthDateTextBox.Text;
                    jobProviderPersonal.Phone = phnTextBox.Text;
                    jobProviderPersonal.Gender = genderDropDownList.SelectedValue;
                    jobProviderPersonal.Nationnality = nationnalityDropDownList.SelectedValue;
                    jobProviderPersonal.Email = emailTextBox.Text;
                    jobProviderPersonal.Location = locationTextBox.Text;
                    jobProviderPersonal.Type = typeDropDownList.SelectedValue;
                    jobProviderPersonal.PaymentProcedure = paymentProcedureDropDownList.SelectedValue;
                    jobProviderPersonal.Rate = rateTextBox.Text;

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
                jobProviderPersonal.FullName = fullNameTextBox.Text;
                jobProviderPersonal.NID = nIDTextBox.Text;
                jobProviderPersonal.PassportNumber = passportNumberTextBox.Text;
                jobProviderPersonal.BirthDate = birthDateTextBox.Text;
                jobProviderPersonal.Phone = phnTextBox.Text;
                jobProviderPersonal.Gender = genderDropDownList.SelectedValue;
                jobProviderPersonal.Nationnality = nationnalityDropDownList.SelectedValue;
                jobProviderPersonal.Email = emailTextBox.Text;
                jobProviderPersonal.Location = locationTextBox.Text;
                jobProviderPersonal.Type = typeDropDownList.SelectedValue;
                jobProviderPersonal.PaymentProcedure = paymentProcedureDropDownList.SelectedValue;
                jobProviderPersonal.Rate = rateTextBox.Text;

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