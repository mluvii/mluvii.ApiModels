using mluvii.ApiModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Emails
{
    public class EmailThreadParamsModel
    {
        /// <summary>
        /// Interaction params associated with e-mail thread.
        /// </summary>
        public ICollection<EmailThreadParam> Params { get; set; }
    }

    public class EmailThreadParam
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public bool ReadOnly { get; set; }

        [EnumDataType(typeof(InteractionParamSource))]
        public InteractionParamSource Source { get; set; }

        public DateTime UpdatedDate { get; set; }
    }

    public class UpdateEmailThreadParamsModel
    {
        public IDictionary<string, string> Params { get; set; }
    }
}
