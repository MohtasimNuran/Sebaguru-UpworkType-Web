using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class JobDetailsWithoutApplyJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var joCodeDetails = Session["JobCodeDetails"].ToString();

            var ajobDeatils = db.PostJobs.Where(x => x.JobCode == joCodeDetails).Select(x => x).ToList().LastOrDefault();

            nameLabel.Text = ajobDeatils.JobTitle;
            typeLabel.Text = ajobDeatils.Type;
            loactionLabel.Text = ajobDeatils.Location;
            catLabel.Text = ajobDeatils.Category;
            responseLabel.Text = ajobDeatils.JobResponsibility;
            msgLabel.Text = ajobDeatils.Message;
            deadLineLabel.Text = ajobDeatils.DeadLineDate.ToString();
            profileImage.ImageUrl = ajobDeatils.CoverPhoto;
            paymentLabel.Text = ajobDeatils.Payment;
            regLabel.Text = ajobDeatils.RegDate.ToString();
            jobCodeLabel.Text = ajobDeatils.JobCode;
            perLabel.Text = ajobDeatils.Per;
            jobTitleLabel.Text = ajobDeatils.JobTitle;

            postedIdLinkButton.Text = db.PostJobs.Where(x => x.JobCode == joCodeDetails).Select(x => x.JobProviderCompany.CompanyName).ToList().LastOrDefault();
            postedIdPersonalLinkButton.Text = db.PostJobs.Where(x => x.JobCode == joCodeDetails).Select(x => x.JobProviderPersonal.FullName).ToList().LastOrDefault();

            var email = Session["Email"].ToString();
            var jobId = Session["JobId"].ToString();
            if (jobId == "PersonalId")
            {
                //profile image
                var profileImg = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
                //profieImage.ImageUrl = profileImg;
            }
            else if (jobId == "CompanyId")
            {
                //profile image
                var profileImg = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.CompanyLogo).ToList().LastOrDefault();
                //profieImage.ImageUrl = profileImg;
            }

        }

        protected void postedIdLinkButton_Click(object sender, EventArgs e)
        {
            var joCodeDetails = Session["JobCodeDetails"].ToString();
            Session["CompanyId"] = db.PostJobs.Where(x => x.JobCode == joCodeDetails).Select(x => x.CompanyId).ToList().LastOrDefault();
            Response.Redirect("ProfileViewOthersJobProviderCompanyJobProvider.aspx");
        }


        protected void postedIdPersonalLinkButton_OnClick(object sender, EventArgs e)
        {
            var joCodeDetails = Session["JobCodeDetails"].ToString();
            Session["PersonalId"] = db.PostJobs.Where(x => x.JobCode == joCodeDetails).Select(x => x.PersonalId).ToList().LastOrDefault();
            Response.Redirect("ProfileViewOthersJobProviderPersonalJobProvider.aspx");
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