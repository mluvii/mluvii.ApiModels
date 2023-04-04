using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Campaigns
{
    public class AddCampaignIdentitiesModel
    {
        /// <summary>
        /// Ids of contact directory identities.
        /// </summary>
        [Required]
        public long[] Ids { get; set; }

        /// <summary>
        /// Name of the callparam in the Contact Directory that stores the phone number. <br />
        /// Example: "oo1_guest_phone". <br />
        /// Used for all campaign channels.
        /// </summary>
        [Required]
        public string ContactInfoField { get; set; }

        public string[] WhatsAppFormContactFields { get; set; }

        public string[] WhatsAppFormDefaultValues { get; set; }
    }
}
