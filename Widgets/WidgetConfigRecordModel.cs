using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Widgets
{
    public class WidgetConfigRecordModel
    {
        [Required]
        public WidgetConfigType ConfigType { get; set; }

        public WidgetButtonType? ButtonType { get; set; }

        [Required]
        public string PropertyName { get; set; }

        public string Language { get; set; }

        public string Value { get; set; }
    }
}
