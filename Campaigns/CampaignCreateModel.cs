using System;
using mluvii.ApiModels.Common;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Campaigns
{
    public class CampaignBaseModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Goal is either "no_contacts" or "empty".<br />
        /// <ul>
        ///     <li>"no_contacts" means that campaign will end when all current contacts are contacted. </li>
        ///     <li>"empty" means that campaign will never end and you can freely and new contacts which will be contacted. </li>
        /// </ul>
        /// </summary>
        [Required]
        public string Goal { get; set; }

        /// <summary>
        /// Deprecated, use <see cref="AddCampaignIdentitiesModel.ContactInfoField" /> when adding identities.
        /// </summary>
        [Obsolete]
        public string ContactInfoField { get; set; }

        /// <summary>
        /// Required if Channel = Phone. <br />
        /// List of phone numbers to be used as caller id. All numbers must be assigned in Phone gateway configuration. <br />
        /// At least one number is required. Using multiple numbers requires the "phones-multi-select" feature.
        /// </summary>
        public string[] CallerIds { get; set; }

        /// <summary>
        /// Required if Channel = Phone. <br />
        /// Id of the routing rule set to be used for the campaign.
        /// </summary>
        public int? RoutingRuleSetId { get; set; }

        /// <summary>
        /// Used if Channel = Phone.<br />
        /// Can be null when no call script is required.
        /// </summary>
        public int? CallScriptId { get; set; }

        /// <summary>
        /// Used if Channel = Phone.<br />
        /// Id of the Automatization rule. Can be used to determine what should happen when a client is unavailable.<br />
        /// Can be null when no such automatization is required.
        /// </summary>
        public int? RuleId { get; set; }

        /// <summary>
        /// Required if Channel = Phone and Mode = Predictive.
        /// </summary>
        public int? PickupRate { get; set; }

        /// <summary>
        /// Required if Channel = Phone and Mode = Preview. <br />
        /// Specifies how many seconds operator has for preparation before the call is called.
        /// </summary>
        public int? BcwSeconds { get; set; }

        /// <summary>
        /// Required if Channel = WhatsApp.
        /// </summary>
        public int? WhatsAppFormId  { get; set; }

        /// <summary>
        /// Required if Channel = WhatsApp.
        /// </summary>
        public string WhatsAppFormLanguage  { get; set; }

        /// <summary>
        /// Required if Channel = WhatsApp.
        /// </summary>
        public Guid? WhatsAppSubscriptionId  { get; set; }
    }

    public class CampaignCreateModel : CampaignBaseModel
    {
        /// <summary>
        /// Must be "Phone" or "WhatsApp."
        /// </summary>
        [Required]
        [EnumDataType(typeof(Channel))]
        public Channel Channel { get; set; }

        /// <summary>
        /// When Channel = Phone, then the Mode can be either "Preview" or "Predictive".  <br />
        /// When Channel = WhatsApp, then the Mode must be "Automated". <br />
        /// </summary>
        [Required]
        [EnumDataType(typeof(CampaignMode))]
        public CampaignMode Mode { get; set; }
    }

    public class CampaignUpdateModel : CampaignBaseModel
    {
    }
}
