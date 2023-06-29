using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Contacts
{
    public class ContactModel
    {
        [Required]
        public long Id { get; set; }

        [Required]
        public IDictionary<string, string[]> Data { get; set; }
    }
}
