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
    
    public partial class Message
    {
        public int Id { get; set; }
        public Nullable<int> JobSeekerMessageId { get; set; }
        public Nullable<int> JobProviderPersonalMessageId { get; set; }
        public Nullable<int> JobProviderCompanyMessageId { get; set; }
        public string Msg { get; set; }
        public string Status { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public Nullable<System.DateTime> SendingDate { get; set; }
    
        public virtual JobProviderCompany JobProviderCompany { get; set; }
        public virtual JobProviderPersonal JobProviderPersonal { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
    }
}
