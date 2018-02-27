using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class ProfileViewSelfJobSeeker : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();

            var aJobSeeker = db.JobSeekers.Where(x => x.Email == email).Select(x => x).ToList().LastOrDefault();

            nameLabel.Text = aJobSeeker.Full_Name;
            profileImage.ImageUrl = aJobSeeker.Picture;
            fullNameLabel.Text = aJobSeeker.Full_Name;
            birthLabel.Text = aJobSeeker.Birthdate;
            emailLabel.Text = aJobSeeker.Email;
            phnLabel.Text = aJobSeeker.Phone;
            genderLabel.Text = aJobSeeker.Gender;
            nationalityLabel.Text = aJobSeeker.Nationnality;
            regDateLabel.Text = aJobSeeker.RegDate;
            categoryLabel.Text = aJobSeeker.Category;
            commentLabel.Text = aJobSeeker.CommentBox;
            locationLabel.Text = aJobSeeker.Location;
            typeLabel.Text = aJobSeeker.Type;
            paymentLabel.Text = aJobSeeker.PaymentProcedure;
            rateLabel.Text = aJobSeeker.Rate;
            availableTimeLabel.Text = aJobSeeker.AvailableStart + " to " + aJobSeeker.AvailableEnd;

            var reviewJobSeekerList =
                       db.SelectedJobSeekers.Where(x => x.JobSeeker.Email == email).Select(x => new
                       {
                           x.PostJob.JobTitle,
                           x.PostJob.JobCode,
                           x.PostJob.CoverPhoto,
                           x.PostJob.Category,
                           x.PostJob.CompanyId,
                           x.PostJob.JobProviderCompany.CompanyName,
                           x.PostJob.PersonalId,
                           x.PostJob.JobProviderPersonal.FullName,
                           x.ReviewForComplete,
                           x.ReviewForIncomplete,
                           x.Status
                       }).ToList();
            Repeater2.DataSource = reviewJobSeekerList;
            Repeater2.DataBind();

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

//        protected void editButton_OnClick(object sender, EventArgs e)
//        {
//            Response.Redirect("UpdateProfileJobSeeker.aspx");
//        }
    }
}