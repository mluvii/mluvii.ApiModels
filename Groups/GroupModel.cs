using System;
using System.Collections.Generic;
using System.Text;

namespace mluvii.ApiModels.Groups
{
    public class GroupModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        public OperatorGroupType Type { get; set; }

        public int DepartmentId { get; set; }

    }
}
