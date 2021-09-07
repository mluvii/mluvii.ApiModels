using System;

namespace mluvii.ApiModels.Companies
{
    public class CompanyModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Guid CompanyGuid { get; set; }

        public string Language { get; set; }

        public string Timezone { get; set; }
    }
}
