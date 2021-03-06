//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UpWorkWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class PostJob
    {
        public PostJob()
        {
            this.AppliedJobSeekers = new HashSet<AppliedJobSeeker>();
            this.SelectedJobSeekers = new HashSet<SelectedJobSeeker>();
            this.CompleteJobs = new HashSet<CompleteJob>();
            this.Notifications = new HashSet<Notification>();
        }
    
        public int Id { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string JobResponsibility { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> DeadLineDate { get; set; }
        public string CoverPhoto { get; set; }
        public string Payment { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
        public Nullable<int> PersonalId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string JobCode { get; set; }
        public string Per { get; set; }
        public string JobTitle { get; set; }
    
        public virtual JobProviderCompany JobProviderCompany { get; set; }
        public virtual JobProviderPersonal JobProviderPersonal { get; set; }
        public virtual ICollection<AppliedJobSeeker> AppliedJobSeekers { get; set; }
        public virtual ICollection<SelectedJobSeeker> SelectedJobSeekers { get; set; }
        public virtual ICollection<CompleteJob> CompleteJobs { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
