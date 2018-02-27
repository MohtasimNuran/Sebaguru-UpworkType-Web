using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class ChangePasswordJobProviderCompany : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        JobProviderCompany jobProviderCompany = new JobProviderCompany();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var email = Session["Email"].ToString();
                var jodId = Session["JobId"].ToString();
                if (jodId == "PersonalId")
                {
                    Response.Redirect("ChangePasswordJobProviderPersonal.aspx");
                }
            }
        }

        protected void changePasswordButton_OnClick(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();

            if (oldPasswordTextBox.Text == db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.Password).ToList().LastOrDefault())
            {
                jobProviderCompany = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x).First();

                jobProviderCompany.Password = passwordTextBox.Text;
                db.SaveChanges();
                Response.Redirect("UpdateProfileJobProviderCompany.aspx");
            }
            else
            {
                Response.Write("<script>alert('Your old password is not correct ! ! !');</script>");
            }
        }
    }
}