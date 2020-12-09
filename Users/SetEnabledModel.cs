using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Users
{
    public class SetEnabledModel
    {
        [Required]
        public bool IsEnabled { get; set; }
    }
}
