using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpWorkWeb.Model
{
    public class FaceBookUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string PictureUrl { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
    }
}