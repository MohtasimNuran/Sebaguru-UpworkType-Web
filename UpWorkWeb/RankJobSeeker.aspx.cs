using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpWorkWeb
{
    public partial class RankJobSeeker : System.Web.UI.Page
    {
        private UpWorkDBEntities db = new UpWorkDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<int?> maxRepeatedItemsListJobSeeker = new List<int?>();

            for (int i = 0; i < 3; i++)
            {
                var grouped = db.SelectedJobSeekers.Where(x => x.Status == "complete").ToLookup(x => x.JobSeekerSelectedId);
                var maxCount = grouped.Max(x => x.Skip(i).Count());
                var maxRepeatedItems = grouped.Where(x => x.Count() == maxCount).Select(x => x.Key).ToList();
                maxRepeatedItemsListJobSeeker.AddRange(maxRepeatedItems);

            }


            var profileList = db.JobSeekers.Where(x =>maxRepeatedItemsListJobSeeker.Contains(x.Id)).Select(x => new
            {
                x.Picture,
                x.Full_Name
            }).ToList();


        }
    }
}