using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class SearchJobResultJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        private string jobId;
        DateTime now = DateTime.Now.Date;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["SearchText"] as string))
            {
                var searchText = Session["SearchText"].ToString();

                if (db.PostJobs.Any(x => x.JobCode == searchText))
                {
                    var jobList = db.PostJobs.Where(x => x.JobCode == searchText).Select(x => x).ToList();
                    Repeater2.DataSource = jobList;
                    Repeater2.DataBind();
                }
                else if (db.PostJobs.Any(x => x.JobTitle == searchText))
                {
                    var jobList = db.PostJobs.Where(x => x.JobTitle == searchText).Select(x => x).ToList();
                    Repeater2.DataSource = jobList;
                    Repeater2.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('No job found like that!!!');</script>");
                }
            }
        }
        protected void Repeater2_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var jobId1 = Session["JobId"].ToString();

            if (jobId1 == "PersonalId")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApplyJobProvider.aspx");
            }
            else if (jobId1 == "CompanyId")
            {
                Session["JobCodeDetails"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetailsWithoutApplyJobProvider.aspx");
            }
            else if (jobId1 == "JobSeeker")
            {
                Session["JobCode"] = e.CommandArgument.ToString();
                Response.Redirect("JobDetails.aspx");
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