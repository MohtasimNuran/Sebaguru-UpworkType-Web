﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class MessageJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        Message message = new Message();
        protected void Page_Load(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();
            var jobId = Session["JobId"].ToString();
            if (jobId == "PersonalId")
            {
                //profile image
                var profileImg = db.JobProviderPersonals.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
                //profieImage.ImageUrl = profileImg;
            }
            else if (jobId == "CompanyId")
            {
                //profile image
                var profileImg = db.JobProviderCompanies.Where(x => x.CompanyEmail == email).Select(x => x.CompanyLogo).ToList().LastOrDefault();
                //profieImage.ImageUrl = profileImg;
            }
        }

        protected void sendButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var email = Session["Email"].ToString();
                message.Sender = email;
                message.Receiver = receiverTextBox.Text;
                message.Msg = msgTextBox.Text;
                message.Status = "unread";
                db.Messages.Add(message);
                db.SaveChanges();
                Response.Write("<script>alert('Message sent successful!!!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Enter all data!!!');</script>");
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