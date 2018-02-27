using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class MessageNotificationJobProvider : System.Web.UI.Page
    {
        UpWorkDBEntities db = new UpWorkDBEntities();
        Message message = new Message();
        protected void Page_Load(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();

            var unreadMsgList = db.Messages.Where(x => x.Receiver == email && x.Status == "unread").Select(x => new
            {
                x.Sender,
                x.Msg,
                x.SendingDate
            }).ToList();

            notificationRepeater.DataSource = unreadMsgList;
            notificationRepeater.DataBind();
        }

        protected void makeReadButton_Click(object sender, EventArgs e)
        {
            var email = Session["Email"].ToString();

            var notificationList = db.Messages.Where(x => x.Receiver == email && x.Status == "unread").Select(x => x).ToList();

            foreach (var aItem in notificationList)
            {
                aItem.Status = "read";
                db.SaveChanges();

            }
            Response.Redirect("MessageNotification.aspx");
        }
    }
}