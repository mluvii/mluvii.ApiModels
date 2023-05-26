using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Campaigns
{
    public class DeleteCampaignIdentitiesModel
    {
        /// <summary>
        /// Ids of contact directory identities.
        /// </summary>
        [Required]
        public long[] Ids { get; set; }
    }
}
