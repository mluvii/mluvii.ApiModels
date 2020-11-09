using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Widgets
{
    public class WidgetFormsModel
    {
        [Required]
        public ICollection<WidgetFormModel> ConfigRecords { get; set; }
    }
}
