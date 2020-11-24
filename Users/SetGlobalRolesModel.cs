using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Users
{
    public class SetGlobalRolesModel
    {
        [Required]
        public ICollection<GlobalRole> GlobalRoles { get; set; }
    }
}
