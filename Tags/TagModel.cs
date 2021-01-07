namespace mluvii.ApiModels.Tags
{
    public class TagModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Label { get; set; }

        public int DepartmentId { get; set; }

        public uint BackgroundArgb { get; set; }

        public uint TextArgb { get; set; }
    }
}
