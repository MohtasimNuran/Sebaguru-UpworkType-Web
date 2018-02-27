using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class EditProfileForJobSeeker : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        JobSeeker jobSeeker = new JobSeeker();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var email = Session["Email"].ToString();

                fullNameTextBox.Text = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Full_Name).ToList().LastOrDefault();
                emailTextBox.Text = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Email).ToList().LastOrDefault();
                birthDateTextBox.Text = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Birthdate).ToList().LastOrDefault();
                phnTextBox.Text = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Phone).ToList().LastOrDefault();
                genderDropDownList.Text = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Gender).ToList().LastOrDefault();
                nationnalityTextBox.Text = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Nationnality).ToList().LastOrDefault();
                profileImage.ImageUrl = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
                categoryDropDownList.Text = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Category).ToList().LastOrDefault();
                commentBoxTextBox.Text = db.JobSeekers.Where(x => x.Email == email).Select(x => x.CommentBox).ToList().LastOrDefault();
                passwordTextBox.Text = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Password).ToList().LastOrDefault();

            }
            
        }

        protected void editButton_OnClick(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();
            try
            {
                jobSeeker = db.JobSeekers.Where(x => x.Email == email).Select(x => x).First();

                //jobSeeker.Picture = img;
                //jobSeeker.Email = emailTextBox.Text;
                jobSeeker.Full_Name = fullNameTextBox.Text;
                jobSeeker.Birthdate = birthDateTextBox.Text;
                jobSeeker.Phone = phnTextBox.Text;
                jobSeeker.Gender = genderDropDownList.SelectedValue;
                jobSeeker.Nationnality = nationnalityTextBox.Text;
                jobSeeker.Category = categoryDropDownList.SelectedValue;
                jobSeeker.CommentBox = commentBoxTextBox.Text;
                jobSeeker.Password = passwordTextBox.Text;
                //db.Entry(jobSeeker).State = EntityState.Modified;
                //db.JobSeekers.AddOrUpdate(jobSeeker);
                db.SaveChanges();
                Response.Write("<script>alert('Updated  ! ! !');</script>");
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Something Went wrong !!! ');</script>");
            }








            //try
            //{
            //if (genderDropDownList.SelectedValue == "...Select One..." || fullNameTextBox.Text == "")
            //{
            //    Response.Write("<script>alert('Enter data for every input field!!!');</script>");
            //}
            //else
            //{
            //    if (FileUpload1.HasFile)
            //    {
            //        string path = Server.MapPath("Images/");
            //        FileUpload1.SaveAs(path + FileUpload1.FileName);
            //        string img = "Images/" + FileUpload1.FileName;

            //        jobSeeker = db.JobSeekers.Where(x => x.Email == email).Select(x => x).First();

            //        jobSeeker.Picture = img;
            //        //jobSeeker.Email = emailTextBox.Text;
            //        jobSeeker.Full_Name = fullNameTextBox.Text;
            //        jobSeeker.Birthdate = birthDateTextBox.Text;
            //        jobSeeker.Phone = phnTextBox.Text;
            //        jobSeeker.Gender = genderDropDownList.SelectedValue;
            //        jobSeeker.Nationnality = nationnalityTextBox.Text;
            //        jobSeeker.Category = categoryDropDownList.SelectedValue;
            //        jobSeeker.CommentBox = commentBoxTextBox.Text;
            //        jobSeeker.Password = passwordTextBox.Text;
            //        //db.Entry(jobSeeker).State = EntityState.Modified;
            //        db.JobSeekers.AddOrUpdate(jobSeeker);
            //        db.SaveChanges();
            //        Response.Write("<script>alert('Updated  ! ! !');</script>");
            //    }
            //    else
            //    {
            //        jobSeeker = db.JobSeekers.Where(x => x.Email == email).Select(x => x).First();

            //        //jobSeeker.Picture = img;
            //        //jobSeeker.Email = emailTextBox.Text;
            //        jobSeeker.Full_Name = fullNameTextBox.Text;
            //        jobSeeker.Birthdate = birthDateTextBox.Text;
            //        jobSeeker.Phone = phnTextBox.Text;
            //        jobSeeker.Gender = genderDropDownList.SelectedValue;
            //        jobSeeker.Nationnality = nationnalityTextBox.Text;
            //        jobSeeker.Category = categoryDropDownList.SelectedValue;
            //        jobSeeker.CommentBox = commentBoxTextBox.Text;
            //        jobSeeker.Password = passwordTextBox.Text;
            //        //db.Entry(jobSeeker).State = EntityState.Modified;
            //        db.JobSeekers.AddOrUpdate(jobSeeker);
            //        db.SaveChanges();
            //        Response.Write("<script>alert('Updated  ! ! !');</script>");
            //    }

            //}



            //}
            //catch (Exception)
            //{
            //    Response.Write("<script>alert('Something Went wrong !!! ');</script>");
            //}



            //if (genderDropDownList.SelectedValue == "...Select One..." || fullNameTextBox.Text == "" || emailTextBox.Text == "")
            //{
            //    Response.Write("<script>alert('Enter data for every input field!!!');</script>");
            //}
            //else
            //{
            //    string path = Server.MapPath("Images/");

            //    if (FileUpload1.HasFile)
            //    {
            //        string ext = Path.GetExtension(FileUpload1.FileName);

            //        if (ext == ".jpg" || ext == ".png")
            //        {
            //            FileUpload1.SaveAs(path + FileUpload1.FileName);
            //            string img = "Images/" + FileUpload1.FileName;
            //            jobSeeker.Full_Name = fullNameTextBox.Text;
            //            jobSeeker.Email = emailTextBox.Text;
            //            jobSeeker.Password = passwordTextBox.Text;
            //            jobSeeker.Birthdate = birthDateTextBox.Text;
            //            jobSeeker.Phone = phnTextBox.Text;
            //            jobSeeker.Gender = genderDropDownList.SelectedValue;
            //            jobSeeker.Nationnality = nationnalityTextBox.Text;
            //            jobSeeker.Picture = img;
            //            jobSeeker.Category = categoryDropDownList.SelectedValue;
            //            jobSeeker.CommentBox = commentBoxTextBox.Text;
            //            var num = db.JobSeekers.Select(x => x).ToList();
            //            string code = string.Format("{0:D3}", num.Count + 1);
            //            jobSeeker.JobSeekerCode = categoryDropDownList.SelectedValue + code;
            //            jobSeeker.RegDate = DateTime.Now.ToShortDateString();
            //            db.JobSeekers.Add(jobSeeker);
            //            db.SaveChanges();
            //            Response.Write("<script>alert('Saved Successfully!!!');</script>");
            //        }
            //        else
            //        {
            //            Response.Write("<script>alert('Upload jpg or png format!!!');</script>");
            //        }
            //    }

            //    else
            //    {
            //        Response.Write("<script>alert('Upload first!!!');</script>");
            //    }

            //}
        }
    }
}