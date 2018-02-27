using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class Index : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        DateTime now = DateTime.Now.Date;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderBy(x => x.RegDate).ThenBy(x => x.DeadLineDate).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
        }
        protected void Repeater2_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["Email"] as string)) //not null
            {
                if (Session["JobId"].ToString() == "PersonalId")
                {
                    Session["JobCodeDetails"] = e.CommandArgument.ToString();
                    Response.Redirect("JobDetailsWithoutApplyJobProvider.aspx");
                }
                else if (Session["JobId"].ToString() == "CompanyId")
                {
                    Session["JobCodeDetails"] = e.CommandArgument.ToString();
                    Response.Redirect("JobDetailsWithoutApplyJobProvider.aspx");
                }
                else if (Session["JobId"].ToString() == "JobSeeker")
                {
                    Session["JobCode"] = e.CommandArgument.ToString();
                    Response.Redirect("JobDetails.aspx");
                }
            }


            else
            {
                Response.Write("<script>alert('Sorry u have to log in to know further more!!!');</script>");
            }

        }

        protected void categoryDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (categoryDropDownList.SelectedValue == "Category")
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
            else
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now && x.Category == categoryDropDownList.SelectedValue).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
        }

        protected void typeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeDropDownList.SelectedValue == "Type")
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
            else
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now && x.Type == typeDropDownList.SelectedValue).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
        }

        protected void timeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (timeDropDownList.SelectedValue == "Time")
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
            else
            {
                var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now && x.Per == timeDropDownList.SelectedValue).Select(x => x).ToList();

                Repeater2.DataSource = jobList;
                Repeater2.DataBind();
            }
        }
    }
}