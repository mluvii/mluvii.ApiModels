using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Companies
{
    public class CreateCompanyModel
    {
        [Required]
        public string Name { get; set; }

        public string Language { get; set; }

        public string Timezone { get; set; }
    }
}
