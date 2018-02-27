using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class JobSeekerMasterPage : System.Web.UI.MasterPage
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();
            var jobId = Session["JobId"].ToString();
            //profile image
            profieImage.ImageUrl = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
        }

        protected void logOutButton_OnClick(object sender, EventArgs e)
        {
            Session["Email"] = "";
            Session["JobCode"] = "";
            Session["EmailForReview"] = "";
            Session["EmailForProfile"] = "";
            Response.Redirect("LoginPage.aspx");
        }

        protected void searchButton_OnClick(object sender, EventArgs e)
        {
            var searchText = searchTextBox.Text;
            Session["SearchText"] = searchText;
            Response.Redirect("SearchJobResultJobSeeker.aspx");
        }
    }
}