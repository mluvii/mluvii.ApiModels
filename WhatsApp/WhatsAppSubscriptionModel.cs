using System;

namespace mluvii.ApiModels.WhatsApp
{
    public class WhatsAppSubscriptionModel
    {
        public Guid ID { get; set; }

        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }
    }
}
