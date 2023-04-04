using System.ComponentModel.DataAnnotations;
using mluvii.ApiModels.Common;

namespace mluvii.ApiModels.Forms
{
    public class FormModel
    {
        public int ID { get; set; }

        [EnumDataType(typeof(FormEntrypoint))]
        public FormEntrypoint FormType { get; set; }

        [EnumDataType(typeof(Channel))]
        public Channel FormChannel { get; set; }

        public string Name { get; set; }

        public int? DepartmentId { get; set; }

        public bool Predefined { get; set; }
    }
}
