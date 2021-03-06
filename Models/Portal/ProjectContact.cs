﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InternalPortal.Models.Portal
{
    public class ProjectContact
    {
        public Guid ProjectContactId { get; set; }
        public Contact Contact { get; set; }
        public Project Project { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Guid? UpdatedByInternalUserId { get; set; }
        [ForeignKey("UpdatedByInternalUserId")]
        public InternalUser InternalUpdatedBy { get; set; }
        public Guid? CreatedByUserId { get; set; }
        public Guid? UpdatedByUserId { get; set; }
        [ForeignKey("CreatedByUserId")]
        public User CreatedBy { get; set; }
        [ForeignKey("UpdatedByUserId")]
        public User UpdatedBy { get; set; }
    }
}
