using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Users
{
    public class DepartmentRolesModel
    {
        [Required]
        public ICollection<DepartmentRole> Roles { get; set; }
    }
}
