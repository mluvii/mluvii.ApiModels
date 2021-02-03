﻿using mluvii.ApiModels.Common;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Campaigns
{
    public class CampaignCreateModel
    {
        public string Name { get; set; }

        [EnumDataType(typeof(Channel))]
        public Channel Channel { get; set; }

        [EnumDataType(typeof(CampaignMode))]
        public CampaignMode Mode { get; set; }

        public int? PickupRate { get; set; }

        public string ContactInfoField { get; set; }

        public int? CallScriptId { get; set; }

        public int RoutingRuleSetId { get; set; }

        public int? RuleId { get; set; }

        public int? BcwSeconds { get; set; }
    }

    public class CampaignUpdateModel : CampaignCreateModel
    {
        public int DepartmentId { get; set; }
    }
}