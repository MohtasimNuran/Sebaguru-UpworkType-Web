using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["Email"] as string))
            {
                logOutButton.Visible = true;
                logInButton.Visible = false;
            }
            else
            {
                logOutButton.Visible = false;
            }
            
        }


        protected void logInButton_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("LoginPage.aspx");
        }

        protected void logOutButton_Click(object sender, EventArgs e)
        {
            logInButton.Visible = true;
            logOutButton.Visible = false;
        }
    }
}