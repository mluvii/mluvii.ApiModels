using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Widgets
{
    public class WidgetConfigRecordsModel
    {
        [Required]
        public ICollection<WidgetConfigRecordModel> ConfigRecords { get; set; }
    }
}
