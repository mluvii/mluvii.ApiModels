using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Phones
{
    public class OutboundCallModel
    {
        [Required]
        public int OperatorId { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string CallerId { get; set; }
    }
}
