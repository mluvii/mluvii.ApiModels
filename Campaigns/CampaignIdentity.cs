using System;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Campaigns
{
    public class CampaignIdentity
    {
        public long Id { get; set; }

        [EnumDataType(typeof(CampaignIdentityState))]
        public CampaignIdentityState State { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? RetryScheduledDate { get; set; }

        public int RetryCount { get; set; }
    }
}
