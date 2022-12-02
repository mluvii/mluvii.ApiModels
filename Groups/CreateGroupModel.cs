using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Groups
{
    public class CreateGroupModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int DepartmentId { get; set; }
    }
}
