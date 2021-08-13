namespace mluvii.ApiModels.Metrics
{
    public class MetricModel
    {
        public int Id { get; set; }

        public string BaseName { get; set; }

        public string Suffix { get; set; }

        public MetricGroupingFieldModel[] GroupingFields { get; set; }
    }
}
