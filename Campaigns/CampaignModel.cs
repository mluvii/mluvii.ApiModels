using mluvii.ApiModels.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Campaigns
{
    public class CampaignModel
    {
        public int Id { get; set; }

        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Goal { get; set; }

        [EnumDataType(typeof(Channel))]
        public Channel Channel { get; set; }

        [EnumDataType(typeof(CampaignMode))]
        public CampaignMode Mode { get; set; }

        public int? PickupRate { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Started { get; set; }

        public DateTime? Finished { get; set; }

        public string ContactInfoField { get; set; }

        public int? CallScriptId { get; set; }

        public int RoutingRuleSetId { get; set; }

        public int? RuleId { get; set; }

        public int? BcwSeconds { get; set; }

        public long[] IdentityIds { get; set; }

        public string[] CallerIds { get; set; }
    }
}
