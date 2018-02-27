using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class Search : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var search = Session["Search"].ToString();

            if (db.PostJobs.Any(x => x.JobCode == search))
            {

            }

            else if (db.PostJobs.Any(x => x.JobTitle == search))
            {

            }
            else if (db.JobSeekers.Any(x => x.Full_Name == search))
            {

            }
            else if (db.JobSeekers.Any(x => x.Email == search))
            {

            }
            else if (db.JobProviderPersonals.Any(x => x.FullName == search))
            {

            }
            else if (db.JobProviderPersonals.Any(x => x.Email == search))
            {

            }
            else if (db.JobProviderCompanies.Any(x => x.CompanyName == search))
            {

            }
            else if (db.JobProviderCompanies.Any(x => x.CompanyEmail == search))
            {

            }
        }
    }
}