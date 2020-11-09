using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Users
{
    public class CreateInvitationModel
    {
        [Required]
        public int OperatorId { get; set; }

        [Required]
        public int DepartmentId { get; set; }
    }

    public class ResponseInvitationModel
    {
        public string Url { get; set; }

        public int Id { get; set; }
    }
}
