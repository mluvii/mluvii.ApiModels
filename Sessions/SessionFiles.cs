using System.Collections.Generic;

namespace mluvii.ApiModels.Sessions
{
    public class SessionFiles
    {
        public ICollection<int> FileIds { get; set; }
    }

    public enum SessionFileRemovalState
    {
        UNKNOWN = 0,
        REMOVED = 1,
        ALREADY_REMOVED = 2,
        INACCESSIBLE = 4,
    }

    public class SessionFileResponse
    {
        public int FileId { get; set; }
        public SessionFileRemovalState State { get; set; }
    }

}
