using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Tags
{
    public class CreateTagModel
    {
        [Required]
        public string Name { get; set; }

        public string Label { get; set; }

        public string BackgroundArgb { get; set; }

        public string TextArgb { get; set; }
    }
}
