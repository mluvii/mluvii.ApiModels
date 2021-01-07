using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Tags
{
    public class CreateTagModel
    {
        [Required]
        public string Name { get; set; }

        public string Label { get; set; }

        public uint BackgroundArgb { get; set; }

        public uint TextArgb { get; set; }
    }
}
