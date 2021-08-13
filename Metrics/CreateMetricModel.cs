using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Metrics
{
    public class CreateMetricModel
    {
        [Required]
        public string BaseName { get; set; }

        [Required]
        public string Suffix { get; set; }

        public MetricGroupingFieldModel[] GroupingFields { get; set; }
    }
}
