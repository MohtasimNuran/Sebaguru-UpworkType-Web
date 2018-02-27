using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class MessageJobSeeker : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        Message message = new Message();
        protected void Page_Load(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();
            //profile image
            //profieImage.ImageUrl = db.JobSeekers.Where(x => x.Email == email).Select(x => x.Picture).ToList().LastOrDefault();
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
            
        }
    }
}