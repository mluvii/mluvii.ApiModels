using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Webhooks
{
    public class WebhookAddEditModel
    {
        [Required]
        public ICollection<WebhookEventType> EventTypes { get; set; }

        [Required]
        [Url]
        public string CallbackUrl { get; set; }
    }
}
