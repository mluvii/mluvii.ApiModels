namespace mluvii.ApiModels.Tags
{
    public class TagModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Label { get; set; }

        public int DepartmentId { get; set; }

        public string BackgroundArgb { get; set; }

        public string TextArgb { get; set; }
    }
}
