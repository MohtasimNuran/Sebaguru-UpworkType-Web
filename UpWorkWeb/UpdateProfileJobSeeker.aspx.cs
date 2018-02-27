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
    public partial class UpdateProfileJobSeeker : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        JobSeeker jobSeeker = new JobSeeker();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                nationnalityDropDownList.DataSource = CountryList();
                nationnalityDropDownList.DataBind();

                var email = Session["Email"].ToString();

                var aJobSeeker = db.JobSeekers.Where(x => x.Email == email).Select(x => x).ToList().LastOrDefault();

                //profileImage.ImageUrl = aJobSeeker.Picture;
                nameLabel.Text = aJobSeeker.Full_Name;
                profileImage.ImageUrl = aJobSeeker.Picture;
                fullNameTextBox.Text = aJobSeeker.Full_Name;
                birthDateTextBox.Text = aJobSeeker.Birthdate;
                emailTextBox.Text = aJobSeeker.Email;
                phnTextBox.Text = aJobSeeker.Phone;
                genderDropDownList.SelectedValue = aJobSeeker.Gender;
                nationnalityDropDownList.SelectedValue = aJobSeeker.Nationnality;
                //categoryLabel.Text = aJobSeeker.Category;
                commentTextBox.Text = aJobSeeker.CommentBox;
                locationTextBox.Text = aJobSeeker.Location;
                typeDropDownList.SelectedValue = aJobSeeker.Type;
                paymentProcedureDropDownList.SelectedValue = aJobSeeker.PaymentProcedure;
                rateTextBox.Text = aJobSeeker.Rate;
                availableStartTextBox.Text = aJobSeeker.AvailableStart;
                availableEndTextBox.Text = aJobSeeker.AvailableEnd;
            }

        }

        protected void editButton_OnClick(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();
            jobSeeker = db.JobSeekers.Where(x => x.Email == email).Select(x => x).First();

            if (FileUpload1.HasFile)
            {
                string ext = Path.GetExtension(FileUpload1.FileName);

                if (ext == ".jpg" || ext == ".png")
                {
                    string path = Server.MapPath("Images/");
                    FileUpload1.SaveAs(path + FileUpload1.FileName);
                    string img = "Images/" + FileUpload1.FileName;
                    jobSeeker.Picture = img;

                    jobSeeker.Full_Name = fullNameTextBox.Text;
                    jobSeeker.Birthdate = birthDateTextBox.Text;
                    jobSeeker.Email = emailTextBox.Text;
                    jobSeeker.Phone = phnTextBox.Text;
                    jobSeeker.Gender = genderDropDownList.SelectedValue;
                    jobSeeker.Nationnality = nationnalityDropDownList.SelectedValue;
                    jobSeeker.CommentBox = commentTextBox.Text;
                    jobSeeker.Location = locationTextBox.Text;
                    jobSeeker.Type = typeDropDownList.SelectedValue;
                    jobSeeker.PaymentProcedure = paymentProcedureDropDownList.SelectedValue;
                    jobSeeker.Rate = rateTextBox.Text;
                    jobSeeker.AvailableStart = availableStartTextBox.Text;
                    jobSeeker.AvailableEnd = availableEndTextBox.Text;
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
                jobSeeker.Full_Name = fullNameTextBox.Text;
                jobSeeker.Birthdate = birthDateTextBox.Text;
                jobSeeker.Email = emailTextBox.Text;
                jobSeeker.Phone = phnTextBox.Text;
                jobSeeker.Gender = genderDropDownList.SelectedValue;
                jobSeeker.Nationnality = nationnalityDropDownList.SelectedValue;
                jobSeeker.CommentBox = commentTextBox.Text;
                jobSeeker.Location = locationTextBox.Text;
                jobSeeker.Type = typeDropDownList.SelectedValue;
                jobSeeker.PaymentProcedure = paymentProcedureDropDownList.SelectedValue;
                jobSeeker.Rate = rateTextBox.Text;
                jobSeeker.AvailableStart = availableStartTextBox.Text;
                jobSeeker.AvailableEnd = availableEndTextBox.Text;
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