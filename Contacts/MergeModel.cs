using System.Collections.Generic;

namespace mluvii.ApiModels.Contacts
{
    public class MergeModel
    {
        /// <summary>
        /// Identity ids to merge.
        /// </summary>
        public long[] Ids { get; set; }

        public IdentityDataModel ContactData { get; set; }
    }

    public class IdentityDataModel
    {
        /// <summary>
        /// Fullname of the final merged contact.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Data of the final merged contact.
        /// </summary>
        public IDictionary<string, HashSet<string>> Data { get; set; }
    }
}
