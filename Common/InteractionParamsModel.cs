using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Common
{
    public class InteractionParamsModel
    {
        /// <summary>
        /// Interaction params associated with e-mail thread.
        /// </summary>
        public ICollection<InteractionParam> InteractionParams { get; set; }
    }

    public class InteractionParam
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public bool ReadOnly { get; set; }

        [EnumDataType(typeof(InteractionParamSource))]
        public InteractionParamSource Source { get; set; }

        public DateTime UpdatedDate { get; set; }
    }

    public class UpdateInteractionParamsModel
    {
        public IDictionary<string, string> InteractionParams { get; set; }
    }
}
