using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Emails
{
    public class EmailThreadCreateModel
    {
        [Required]
        public int InboxId { get; set; }

        [Required]
        public int OperatorUserId { get; set; }

        [Required]
        public string To { get; set; }

        [Required]
        [MinLength(1)]
        public string Subject { get; set; }

        [Required]
        [MinLength(1)]
        public string Body { get; set; }
    }
}
