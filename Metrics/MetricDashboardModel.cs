namespace mluvii.ApiModels.Metrics
{
    public class MetricDashboardModel
    {
        public string Name { get; set; }

        public string Key { get; set; }

        public int[] MetricIds { get; set; }
    }
}
