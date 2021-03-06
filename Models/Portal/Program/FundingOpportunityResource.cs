﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InternalPortal.Models.Portal.Program
{
    public class FundingOpportunityResource
    {
        public Guid FundingOpportunityResourceId { get; set; }
        public Guid FundingOpportunityId { get; set; }
        public FundingOpportunity FundingOpportunity { get; set; }
        public string TitleE { get; set; }
        public string TitleF { get; set; }
        public string UrlE { get; set; }
        public string UrlF { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Guid? CreatedByInternalUserId { get; set; }
        public Guid? UpdatedByInternalUserId { get; set; }
        [ForeignKey("CreatedByInternalUserId")]
        public InternalUser CreatedBy { get; set; }
        [ForeignKey("UpdatedByInternalUserId")]
        public InternalUser UpdatedBy { get; set; }
    }
}
