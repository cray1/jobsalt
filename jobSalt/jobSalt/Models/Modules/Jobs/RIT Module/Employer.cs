//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jobSalt.Models.Modules.Jobs.RIT_Module
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employer
    {
        public Employer()
        {
            this.Contacts = new HashSet<Contact>();
            this.Jobs = new HashSet<Job>();
        }
    
        public string id { get; set; }
        public string name { get; set; }
        public string division { get; set; }
        public Nullable<System.DateTime> modifiedDate { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string website { get; set; }
        public string archiveStatus { get; set; }
        public Nullable<int> accountManagerId { get; set; }
        public string primaryContactId { get; set; }
    
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}