using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Webhooks
{
    public class WebhookModel : WebhookAddEditModel
    {
        [Required]
        public int? ID { get; set; }
    }
}
