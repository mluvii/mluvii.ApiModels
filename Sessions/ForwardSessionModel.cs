namespace mluvii.ApiModels.Sessions
{
    public class ForwardSessionModel
    {
        public int? OperatorGroupId { get; set; }

        public int? UserId { get; set; }

        public int? ChatbotId { get; set; }

        public string PhoneNumber { get; set; }

        public string Note { get; set; }
    }
}
