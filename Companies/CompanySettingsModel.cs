using System.Collections.Generic;

namespace mluvii.ApiModels.Companies
{
    public class CompanySettingsModel
    {
        public int CompanyId { get; set; }

        public IDictionary<string, string> Settings { get; set; }
    }
}
