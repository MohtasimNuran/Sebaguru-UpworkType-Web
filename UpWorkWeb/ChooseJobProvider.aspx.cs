using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class ChooseJobProvider : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void companyAccountButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterCompanyAccountJobProvider.aspx");
        }

        protected void personalAccountButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPersonalAccountJobProvider.aspx");
        }
    }
}