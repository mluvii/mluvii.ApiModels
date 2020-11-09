using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Sessions
{
    public class CallParamsModel
    {
        /// <summary>
        /// Call params associated with this session.
        /// </summary>
        public ICollection<CallParam> CallParams { get; set; }
    }

    public class CallParam
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public bool ReadOnly { get; set; }

        [EnumDataType(typeof(ClientCallParamSource))]
        public ClientCallParamSource Source { get; set; }

        public DateTime UpdatedDate { get; set; }
    }

    public class UpdateCallParamsModel
    {
        public IDictionary<string, string> CallParams { get; set; }
    }
}
