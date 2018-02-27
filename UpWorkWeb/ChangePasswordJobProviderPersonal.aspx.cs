using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class ChangePasswordJobProviderPersonal : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        JobProviderPersonal jobProviderPersonal = new JobProviderPersonal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void changePasswordButton_OnClick(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();

            if (oldPasswordTextBox.Text == db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Password).ToList().LastOrDefault())
            {
                jobProviderPersonal = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x).First();

                jobProviderPersonal.Password = passwordTextBox.Text;
                db.SaveChanges();
                Response.Redirect("UpdateProfileJobProviderPersonel.aspx");
            }
            else
            {
                Response.Write("<script>alert('Your old password is not correct ! ! !');</script>");
            }
        }
    }
}