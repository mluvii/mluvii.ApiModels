using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Widgets
{
    public class WidgetFormModel
    {
        [Required]
        public string PropertyName { get; set; }

        public int? FormId { get; set; }
    }
}
