using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class PostJobByJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        PostJob postJob = new PostJob();
        public string jobId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["Email"] as string))
            {
                var email = Session["Email"].ToString();
                jobId = Session["JobId"].ToString();
                if (jobId == "PersonalId")
                {
                    var id = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Id).ToList().LastOrDefault();
                    ViewState["Id"] = id;

                    //profile image
                    var profileImg = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
                    //profieImage.ImageUrl = profileImg;
                }
                else if (jobId == "CompanyId")
                {
                    var id = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.Id).ToList().LastOrDefault();
                    ViewState["Id"] = id;

                    //profile image
                    var profileImg = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.CompanyLogo).ToList().LastOrDefault();
                   // profieImage.ImageUrl = profileImg;
                }
            }
            else
            {
                Response.Write("<script>alert('You have to log in as a Job Provider to post a job!!!');</script>");
                Response.Redirect("LoginPage.aspx");
            }
            
        }

        protected void postButton_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("Images/");
            FileUpload1.SaveAs(path + FileUpload1.FileName);
            string img = "Images/" + FileUpload1.FileName;

            if (Page.IsValid)
            {
                if (!string.IsNullOrEmpty(Session["Email"] as string))
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
//                            postJob.DeadLineDate = Convert.ToDateTime(Request.Form["deadLineTextBox"]);
                            postJob.DeadLineDate = Convert.ToDateTime(deadLineTextBox.Text);
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
                            //postJob.DeadLineDate = Convert.ToDateTime(Request.Form["deadLineTextBox"]);
                            postJob.DeadLineDate = Convert.ToDateTime(deadLineTextBox.Text);
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
                            //postJob.DeadLineDate = Convert.ToDateTime(Request.Form["deadLineTextBox"]);
                            postJob.DeadLineDate = Convert.ToDateTime(deadLineTextBox.Text);
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
                            //postJob.DeadLineDate = Convert.ToDateTime(Request.Form["deadLineTextBox"]);
                            postJob.DeadLineDate = Convert.ToDateTime(deadLineTextBox.Text);
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
                    Response.Write("<script>alert('You have to log in as a Job Provider to post a job!!!');</script>");
                }
                
            }
            else
            {
                Response.Write("<script>alert('Enter all required data!!!');</script>");
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

        protected void onlineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (onlineRadioButton.Checked)
            {
                locationLabel.Visible = false;
                locationTextBox.Visible = false;
            }
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