using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Widgets
{
    public class WidgetConfigModel
    {
        [EnumDataType(typeof(WidgetConfigType))]
        public WidgetConfigType ConfigType { get; set; }

        [EnumDataType(typeof(WidgetButtonType))]
        public WidgetButtonType? ButtonType { get; set; }

        public string PropertyName { get; set; }

        public string DefaultValue { get; set; }

        public string CurrentValue { get; set; }

        public string Language { get; set; }

        public int? FormId { get; set; }
    }
}
