using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Users
{
    public class SetDepartmentMembershipModel
    {
        [Required]
        public ICollection<int> Departments { get; set; }
    }
}
