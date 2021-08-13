using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Metrics
{
    public class MetricGroupingFieldModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string EmptyPlaceholder { get; set; }
    }
}
