using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Forms
{
    public class FormModel
    {
        public int ID { get; set; }

        [EnumDataType(typeof(FormEntrypoint))]
        public FormEntrypoint FormType { get; set; }

        public string Name { get; set; }

        public int? DepartmentId { get; set; }

        public bool Predefined { get; set; }
    }
}
