using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class DashBoardJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        PostJob postJob = new PostJob();
        DateTime now = DateTime.Now.Date;
        private string jobId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["JobId"] as string))
            {
                jobId = Session["JobId"].ToString();

                if (jobId == "PersonalId")
                {
                    var email = Session["Email"].ToString();

                    //message count
                    var msgCount = db.Messages.Count(x => x.Receiver == email && x.Status == "unread");
                    msgCountLabel.Text = msgCount.ToString();
                    msgNotiLabel.Text = msgCount.ToString();

                    //job list
                    var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderBy(x => x.RegDate).ThenBy(x => x.DeadLineDate).ToList();

                    jobListRepeater.DataSource = jobList;
                    jobListRepeater.DataBind();

                    //job count
                    jobCountLabel.Text = jobList.Count.ToString();

                    //profile image
                    var profileImg = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
                    //profieImage.ImageUrl = profileImg;


                    //posted job list
                    var id = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Id).ToList().LastOrDefault();
                    ViewState["Id"] = id;
                    var postedJobList = db.PostJobs.Where(x => x.PersonalId == id).Select(x => new
                    {
                        JobCode = x.JobCode,
                        JobResponsibility = x.JobResponsibility,
                        Type = x.Type,
                        Location = x.Location,
                        CoverPhoto = x.CoverPhoto,
                        Category = x.Category,
                        Payment = x.Payment,
                        Count = x.AppliedJobSeekers.Count(y => y.PostJob.Id == y.PostJobId),
                        DeadLineDate = x.DeadLineDate,
                        RegDate = x.RegDate,
                        Per = x.Per

                    }).ToList();
                    postedJobListRepeater.DataSource = postedJobList;
                    postedJobListRepeater.DataBind();

                    //posted job count
                    postedLabel.Text = postedJobList.Count.ToString();
                    postedCountLabel.Text = postedJobList.Count.ToString();

                    //selected job seeker list
                    var selectedJobSeekerList =
                        db.SelectedJobSeekers.Where(x => x.PostJob.JobProviderPersonal.Email == email).Select(x => new
                        {
                            x.PostJob.JobCode,
                            x.JobSeeker.Full_Name,
                            x.JobSeeker.Email,
                            x.JobSeeker.Phone,
                            x.JobSeeker.Picture
                        }).ToList();

                    selectedJobSeekerListRepeater.DataSource = selectedJobSeekerList;
                    selectedJobSeekerListRepeater.DataBind();


                    //completed job list
                    var completedJobSeekerList =
                        db.SelectedJobSeekers.Where(x => x.PostJob.JobProviderPersonal.Email == email && x.Status == "complete").Select(x => new
                        {
                            JobCode = x.PostJob.JobCode,
                            JobTitle = x.PostJob.JobTitle,
                            Category = x.PostJob.Category,
                            FullName = x.JobSeeker.Full_Name,
                            Email = x.JobSeeker.Email,
                            Phone = x.JobSeeker.Phone,
                            Picture = x.JobSeeker.Picture
                        }).ToList();
                    completedJobListRepeater.DataSource = completedJobSeekerList;
                    completedJobListRepeater.DataBind();

                    //complete count
                    completeCountLabel.Text = completedJobSeekerList.Count.ToString();

                    //post job
                    var personalId = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Id).ToList().LastOrDefault();
                    ViewState["Id"] = personalId;

                    //name
                    var name = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.FullName).ToList().LastOrDefault();
                    nameLabel.Text = name;
                }
                else if (jobId == "CompanyId")
                {
                    var email = Session["Email"].ToString();

                    //message count
                    var msgCount = db.Messages.Count(x => x.Receiver == email && x.Status == "unread");
                    msgCountLabel.Text = msgCount.ToString();
                    msgNotiLabel.Text = msgCount.ToString();

                    //job list
                    var jobList = db.PostJobs.Where(x => x.DeadLineDate >= now).Select(x => x).OrderBy(x => x.RegDate).ThenBy(x => x.DeadLineDate).ToList();

                    jobListRepeater.DataSource = jobList;
                    jobListRepeater.DataBind();

                    //job count
                    jobCountLabel.Text = jobList.Count.ToString();

                    //profile image
                    var profileImg = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.CompanyLogo).ToList().LastOrDefault();
                    //profieImage.ImageUrl = profileImg;



                    //posted job list
                    var id = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.Id).ToList().LastOrDefault();
                    ViewState["Id"] = id;
                    //var postedJobList = db.PostJobs.Where(x => x.CompanyId == id).Select(x => x).ToList();
                    var postedJobList = db.PostJobs.Where(x => x.CompanyId == id).Select(x => new
                    {
                        JobCode = x.JobCode,
                        JobResponsibility = x.JobResponsibility,
                        Type = x.Type,
                        Location = x.Location,
                        CoverPhoto = x.CoverPhoto,
                        Category = x.Category,
                        Payment = x.Payment,
                        Count = x.AppliedJobSeekers.Count(y => y.PostJob.Id == y.PostJobId),
                        DeadLineDate = x.DeadLineDate,
                        RegDate = x.RegDate,
                        Per = x.Per

                    }).ToList();
                    postedJobListRepeater.DataSource = postedJobList;
                    postedJobListRepeater.DataBind();

                    //posted job count
                    postedLabel.Text = postedJobList.Count.ToString();
                    postedCountLabel.Text = postedJobList.Count.ToString();

                    //selected job seeker list
                    var selectedJobSeekerList =
                        db.SelectedJobSeekers.Where(x => x.PostJob.JobProviderCompany.CompanyEmail == email).Select(x => new
                        {
                            x.PostJob.JobCode,
                            x.JobSeeker.Full_Name,
                            x.JobSeeker.Email,
                            x.JobSeeker.Phone,
                            x.JobSeeker.Picture
                        }).ToList();
                    selectedJobSeekerListRepeater.DataSource = selectedJobSeekerList;
                    selectedJobSeekerListRepeater.DataBind();

                    //Completed job list
                    var completedJobSeekerList =
                        db.SelectedJobSeekers.Where(x => x.PostJob.JobProviderCompany.CompanyEmail == email && x.Status == "complete").Select(x => new
                        {
                            JobCode = x.PostJob.JobCode,
                            JobTitle = x.PostJob.JobTitle,
                            Category = x.PostJob.Category,
                            FullName = x.JobSeeker.Full_Name,
                            Email = x.JobSeeker.Email,
                            Phone = x.JobSeeker.Phone,
                            Picture = x.JobSeeker.Picture
                        }).ToList();
                    completedJobListRepeater.DataSource = completedJobSeekerList;
                    completedJobListRepeater.DataBind();

                    //complete count
                    completeCountLabel.Text = completedJobSeekerList.Count.ToString();

                    //post job
                    var companyId = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.Id).ToList().LastOrDefault();
                    ViewState["Id"] = companyId;

                    //name
                    var name = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.CompanyName).ToList().LastOrDefault();
                    nameLabel.Text = name;

                }
                else if (jobId == "JobSeeker")
                {
                    Response.Redirect("DashBoardJobSeeker.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('You need to log in to enter in your dashboard!!!');</script>");
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void onlineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (onlineRadioButton.Checked)
            {
                locationLabel.Visible = false;
                locationTextBox.Visible = false;
            }
        }

        protected void offlineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (offlineRadioButton.Checked)
            {
                locationLabel.Visible = true;
                locationTextBox.Visible = true;
            }
        }

        protected void postButton_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("Images/");
            FileUpload1.SaveAs(path + FileUpload1.FileName);
            string img = "Images/" + FileUpload1.FileName;

            if (Page.IsValid)
            {

                if (onlineRadioButton.Checked)
                {

                    if (jobId == "PersonalId")
                    {
                        postJob.Type = onlineRadioButton.Text;
                        postJob.JobTitle = jobTitleTextBox.Text;
                        postJob.Category = categoryDropDownList.SelectedValue;
                        postJob.JobResponsibility = jobResponseTextBox.Text;
                        postJob.Message = msgTextBox.Text;
                        postJob.DeadLineDate = Convert.ToDateTime(Request.Form["deadLineTextBox"]);
                        postJob.Payment = paymentTextBox.Text;
                        postJob.Per = perDropDownList.SelectedValue;
                        postJob.CoverPhoto = img;
                        postJob.RegDate = DateTime.Now;
                        postJob.PersonalId = Convert.ToInt32(ViewState["Id"].ToString());
                        var num = db.PostJobs.Select(x => x).ToList();
                        string code = string.Format("{0:D3}", num.Count + 1);
                        postJob.JobCode = postJob.Type + postJob.Category + code;
                        db.PostJobs.Add(postJob);
                        db.SaveChanges();
                        Response.Write("<script>alert('Succesful!!!');</script>");
                    }
                    else if (jobId == "CompanyId")
                    {
                        postJob.Type = onlineRadioButton.Text;
                        postJob.JobTitle = jobTitleTextBox.Text;
                        postJob.Category = categoryDropDownList.SelectedValue;
                        postJob.JobResponsibility = jobResponseTextBox.Text;
                        postJob.Message = msgTextBox.Text;
                        postJob.DeadLineDate = Convert.ToDateTime(Request.Form["deadLineTextBox"]);
                        postJob.Payment = paymentTextBox.Text;
                        postJob.Per = perDropDownList.SelectedValue;
                        postJob.CoverPhoto = img;
                        postJob.RegDate = DateTime.Now;
                        postJob.CompanyId = Convert.ToInt32(ViewState["Id"].ToString());
                        var num = db.PostJobs.Select(x => x).ToList();
                        string code = string.Format("{0:D3}", num.Count + 1);
                        postJob.JobCode = postJob.Type + postJob.Category + code;
                        db.PostJobs.Add(postJob);
                        db.SaveChanges();
                        Response.Write("<script>alert('Succesful!!!');</script>");
                    }
                }
                else if (offlineRadioButton.Checked)
                {

                    if (jobId == "PersonalId")
                    {
                        postJob.Type = offlineRadioButton.Text;
                        postJob.Location = locationTextBox.Text;
                        postJob.JobTitle = jobTitleTextBox.Text;
                        postJob.Category = categoryDropDownList.SelectedValue;
                        postJob.JobResponsibility = jobResponseTextBox.Text;
                        postJob.Message = msgTextBox.Text;
                        postJob.DeadLineDate = Convert.ToDateTime(Request.Form["deadLineTextBox"]);
                        postJob.Payment = paymentTextBox.Text;
                        postJob.Per = perDropDownList.SelectedValue;
                        postJob.CoverPhoto = img;
                        postJob.RegDate = DateTime.Now;
                        postJob.PersonalId = Convert.ToInt32(ViewState["Id"].ToString());
                        var num = db.PostJobs.Select(x => x).ToList();
                        string code = string.Format("{0:D3}", num.Count + 1);
                        postJob.JobCode = postJob.Type + postJob.Category + code;
                        db.PostJobs.Add(postJob);
                        db.SaveChanges();
                        Response.Write("<script>alert('Succesful!!!');</script>");
                    }
                    else if (jobId == "CompanyId")
                    {
                        postJob.Type = onlineRadioButton.Text;
                        postJob.Location = locationTextBox.Text;
                        postJob.JobTitle = jobTitleTextBox.Text;
                        postJob.Category = categoryDropDownList.SelectedValue;
                        postJob.JobResponsibility = jobResponseTextBox.Text;
                        postJob.Message = msgTextBox.Text;
                        postJob.DeadLineDate = Convert.ToDateTime(Request.Form["deadLineTextBox"]);
                        postJob.Payment = paymentTextBox.Text;
                        postJob.Per = perDropDownList.SelectedValue;
                        postJob.CoverPhoto = img;
                        postJob.RegDate = DateTime.Now;
                        postJob.CompanyId = Convert.ToInt32(ViewState["Id"].ToString());
                        var num = db.PostJobs.Select(x => x).ToList();
                        string code = string.Format("{0:D3}", num.Count + 1);
                        postJob.JobCode = postJob.Type + postJob.Category + code;
                        db.PostJobs.Add(postJob);
                        db.SaveChanges();
                        Response.Write("<script>alert('Succesful!!!');</script>");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('Enter all required data!!!');</script>");
            }

        }


        protected void jobListRepeater_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Session["JobCode"] = e.CommandArgument.ToString();
            Response.Redirect("JobDetails.aspx");
        }

        protected void postedJobListRepeater_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var jobCode = e.CommandName.ToString();
            if (jobCode != "")
            {
                Session["JobCode"] = jobCode;
                Response.Redirect("EditPostJobProvider.aspx");
                //Response.Write(jobCode);
            }
            else
            {
                Session["JobCode"] = e.CommandArgument.ToString();
                Response.Redirect("AppliedCandidateListForJobProvider.aspx");
            }
        }

        protected void selectedJobSeekerListRepeater_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var emailForReview = e.CommandName.ToString();
            if (emailForReview != "")
            {
                Session["EmailForReview"] = emailForReview;
                Response.Redirect("WriteReviewForJobProvider.aspx");
            }
            else
            {
                Session["EmailForProfile"] = e.CommandArgument.ToString();
                Response.Redirect("ProfileViewForOthers.aspx");
            }
        }

        protected void completedJobListRepeater_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {

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