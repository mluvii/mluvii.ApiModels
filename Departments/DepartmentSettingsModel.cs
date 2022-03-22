using System.Collections.Generic;

namespace mluvii.ApiModels.Departments
{
    public class DepartmentSettingsModel
    {
        public int DepartmentId { get; set; }

        public IDictionary<string, string> Settings { get; set; }
    }
}
