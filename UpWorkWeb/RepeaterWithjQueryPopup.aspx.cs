using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class RepeaterWithjQueryPopup : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindEmployees();
            }
        }
        private void BindEmployees()
        {
            var email = Session["Email"].ToString();
            if (Session["JobId"].ToString() == "CompanyId")
            {
                var selectedJobSeekerList =
                    db.SelectedJobSeekers.Where(x => x.PostJob.JobProviderCompany.CompanyEmail == email).Select(x => new
                    {
                        x.PostJob.JobCode,
                        x.JobSeeker.Full_Name,
                        x.JobSeeker.Email,
                        x.JobSeeker.Phone,
                        x.JobSeeker.Picture
                    }).ToList();

                rptEmployees.DataSource = selectedJobSeekerList;
                rptEmployees.DataBind();
            }
            else if (Session["JobId"].ToString() == "PersonalId")
            {
                var selectedJobSeekerList =
                    db.SelectedJobSeekers.Where(x => x.PostJob.JobProviderPersonal.Email == email).Select(x => new
                    {
                        x.PostJob.JobCode,
                        x.JobSeeker.Full_Name,
                        x.JobSeeker.Email,
                        x.JobSeeker.Phone,
                        x.JobSeeker.Picture
                    }).ToList();

                rptEmployees.DataSource = selectedJobSeekerList;
                rptEmployees.DataBind();
            }
        }
    }
}