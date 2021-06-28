using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using mluvii.ApiModels.Common;

namespace mluvii.ApiModels.Sessions
{
    public class SessionModel
    {
        public long Id { get; set; }

        public int CompanyId { get; set; }

        public int DepartmentId { get; set; }

        /// <summary>
        /// Guest information
        /// </summary>
        public GuestInfo Guest { get; set; }

        /// <summary>
        /// The channel at the time of session creation
        /// </summary>
        [EnumDataType(typeof(SessionChannel))]
        public SessionChannel Channel { get; set; }

        /// <summary>
        /// The origin of the session creation
        /// </summary>
        [EnumDataType(typeof(SessionSource))]
        public SessionSource Source { get; set; }

        /// <summary>
        /// Status of the session
        /// </summary>
        [EnumDataType(typeof(SessionStatus))]
        public SessionStatus Status { get; set; }

        /// <summary>
        /// Guest A/V capabilities
        /// </summary>
        [EnumDataType(typeof(ClientAVSupport))]
        public ClientAVSupport AVSupport { get; set; }

        /// <summary>
        /// When guest enters via invitation, this is the generated number.
        /// </summary>
        public string DirectCallNumber { get; set; }

        /// <summary>
        /// Client's phone number for phone sessions
        /// Also when guest enters via phone callback, this is the phone number they enter.
        /// </summary>
        public string PhoneCallbackNumber { get; set; }

        /// <summary>
        /// The session was proactively created by operator and offered to a visiting guest.
        /// </summary>
        public bool IsDirectChat { get; set; }

        /// <summary>
        /// Entry URL at the time of session creation
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Name of entry widget
        /// </summary>
        public string Widget { get; set; }

        /// <summary>
        /// Operators who participated in the session
        /// </summary>
        public ICollection<SessionOperators> Operators { get; set; }

        /// <summary>
        /// Reviewers
        /// </summary>
        public ICollection<ReviewerInfo> Reviewers { get; set; }

        /// <summary>
        /// Obsolete, use <see cref="Created"/>
        /// </summary>
        [Obsolete("Use Created")]
        public DateTimeOffset EnteredQueue => Created;

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset? GuestJoined { get; set; }

        /// <summary>
        /// When first operator accepts the session.
        /// </summary>
        public DateTimeOffset? Started { get; set; }

        /// <summary>
        /// When operator or guest leaves the session.
        /// </summary>
        public DateTimeOffset? Ended { get; set; }

        /// <summary>
        /// ISO 8601 duration. From entering queue to start of session or leaving the queue.
        /// Whichever comes first.
        /// </summary>
        public string Waited { get; set; }

        /// <summary>
        /// ISO 8601 duration. Length of session or null if session never started.
        /// </summary>
        public string Length { get; set; }

        /// <summary>
        /// Whether the guest was blacklisted.
        /// </summary>
        public bool Blacklisted { get; set; }

        /// <summary>
        /// For callback session only.
        /// Time when operator dialed callback number.
        /// </summary>
        public DateTimeOffset? PhoneCallbackDialed { get; set; }

        /// <summary>
        /// Trail of all session activities.
        /// </summary>
        public ICollection<Activity> Activities { get; set; }

        /// <summary>
        /// Tags associated with this session.
        /// </summary>
        public ICollection<AssignedTag> Tags { get; set; }

        /// <summary>
        /// Chatbots which participated in the session
        /// </summary>
        public ICollection<ChatbotInfo> Chatbots { get; set; }

        /// <summary>
        /// Number of stars given by guest on feedback form.
        /// </summary>
        public int? GuestFeedbackStars { get; set; }

        /// <summary>
        /// Type of scale used to set feedback stars.
        /// </summary>
        [EnumDataType(typeof(FeedbackScale))]
        public FeedbackScale? GuestFeedbackScale { get; set; }

        /// <summary>
        /// Freeform textual feedback given by guest on feedback form.
        /// </summary>
        public string GuestFeedbackText { get; set; }

        /// <summary>
        /// Whether the session was auto-accepted
        /// </summary>
        public bool AutoAccepted { get; set; }

        /// <summary>
        /// Contents of feedback form custom fields.
        /// </summary>
        [Obsolete]
        public IDictionary<string, object> GuestFeedbackCustomFields { get; set; }

        /// <summary>
        /// Null if there are no recordings.
        /// </summary>
        public ICollection<Recording> Recordings { get; set; }

        /// <summary>
        /// Represents how guest left the session
        /// </summary>
        [EnumDataType(typeof(GuestLeftSessionInState))]
        public GuestLeftSessionInState GuestLeftSession { get; set; }

        /// <summary>
        /// Result of outbound call dialing
        /// </summary>
        [EnumDataType(typeof(DialNumberState))]
        public DialNumberState? OutboundDialResult { get; set; }

        public class GuestInfo
        {
            /// <summary>
            /// Temporary ID, generated when guest starts a new session and enters queue.
            /// </summary>
            public long TempId { get; set; }

            /// <summary>
            /// Guest IP address
            /// </summary>
            public string IpAddress { get; set; }

            /// <summary>
            /// GUID is generated for each unique guest and saved to cookie.
            /// </summary>
            public Guid? TrackedId { get; set; }

            /// <summary>
            /// Identity numeric key converted to string
            /// </summary>
            public string Identity { get; set; }

            /// <summary>
            /// Relation between guest's cookie and the identity
            /// </summary>
            public long? ChannelIdentity { get; set; }

            /// <summary>
            /// Guest's OS
            /// </summary>
            [EnumDataType(typeof(GuestOSType))]
            public GuestOSType OS { get; set; }

            /// <summary>
            /// Guest's OS
            /// </summary>
            [EnumDataType(typeof(GuestBrowserType))]
            public GuestBrowserType Browser { get; set; }

            /// <summary>
            /// Guest's language
            /// </summary>
            public string Language { get; set; }

            /// <summary>
            /// Collection of attributes associated with the session.
            /// Includes system as well as user keys.
            /// </summary>
            public IDictionary<string, string> CallParams { get; set; }

            /// <summary>
            /// Version of GDPR agreement the user agreed with.
            /// </summary>
            public string GDPRVersion { get; set; }
        }

        public class ReviewerInfo
        {
            public int UserId { get; set; }

            public string UserName { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            /// <summary>
            /// Obsolete, use <see cref="Note"/>
            /// </summary>
            [Obsolete("Use Note")]
            public string FeedbackText => Note;

            /// <summary>
            /// Freeform note by operator.
            /// </summary>
            public string Note { get; set; }
        }

        public class Activity
        {
            public long ActivityId { get; set; }

            /// <summary>
            /// Timestamp of activity
            /// </summary>
            public DateTimeOffset Time { get; set; }

            /// <summary>
            /// Type of activity
            /// </summary>
            public SessionActivityType Type { get; set; }

            /// <summary>
            /// Sender of activity
            /// </summary>
            public ClientType? Client { get; set; }

            /// <summary>
            /// Operator who initiated the activity.
            /// </summary>
            public int? UserId { get; set; }

            /// <summary>
            /// Chatbot who initiated the activity.
            /// </summary>
            public int? ChatbotId { get; set; }

            public ActivityFile File { get; set; }

            public string Text { get; set; }

            public object ChatbotMessageContent { get; set; }

            public SessionAVRequestState? Response { get; set; }

            public GetMediaResult? Result { get; set; }

            public bool? StreamAvailable { get; set; }

            /// <summary>
            /// "Forwarding to operator" activity only.
            /// User ID of recipient.
            /// </summary>
            public int? ToOperatorUserId { get; set; }

            /// <summary>
            /// "Forwarding to operator" activity only.
            /// Full name of recipient.
            /// </summary>
            public string ToOperatorFullName { get; set; }

            /// <summary>
            /// "Forwarding to group" activity only.
            /// ID of recipient operator group.
            /// </summary>
            public int? ToGroupId { get; set; }

            /// <summary>
            /// "Forwarding to group" activity only.
            /// Name recipient operator group.
            /// </summary>
            public string ToGroupName { get; set; }

            /// <summary>
            /// "Forwarding to external phone" activity only.
            /// </summary>
            public string ToPhoneNumber { get; set; }

            /// <summary>
            /// Forwarding activity only.
            /// Note associated with forwarding.
            /// </summary>
            public string Note { get; set; }

            [Obsolete("Use OriginalFormId")]
            public int? CallScriptId { get; set; }

            [Obsolete("Use OriginalFormId")]
            public int? HeroCardId { get; set; }

            public int? OriginalFormId { get; set; }

            /// <summary>
            /// HeroCard activity only
            /// List of field definitions for given hero card.
            /// </summary>
            public ICollection<ActivityFormField> HeroCard { get; set; }

            /// <summary>
            /// CallScript activity only
            /// List of field definitions for given call script.
            /// </summary>
            public ICollection<ActivityFormField> CallScript { get; set; }

            /// <summary>
            /// "HeroCard submission" activity only
            /// Id of original HeroCard activity for this submission
            /// </summary>
            public long? SubmissionOfActivityId { get; set; }

            /// <summary>
            /// "HeroCard submission" activity only
            /// Id of operator who activates submission process of HeroCard
            /// </summary>
            public int? SubmissionByOperatorId { get; set; }

            /// <summary>
            /// "HeroCard submission" activity only
            /// Result of HeroCard submission
            /// </summary>
            public HeroCardSubmissionResult? SubmissionResult { get; set; }

            /// <summary>
            /// "HeroCard submission" activity only
            /// HeroCard submission parameters. None when HeroCard result is 'Cancelled'
            /// </summary>
            public IDictionary<string, string> SubmissionParams { get; set; }

            /// <summary>
            /// "HeroCard submission" activity only
            /// Guest identification when using authentication form field.
            /// &lt;identification&gt; ::= &lt;provider-id&gt; ":" &lt;user_name&gt;
            /// </summary>
            public string SubmissionIdentification { get; set; }

            /// <summary>
            /// "Session ended" activity only
            /// Session termination reason.
            /// </summary>
            public SessionTerminationReason? TerminationReason { get; set; }

            /// <summary>
            /// "Chatbot HeroCard submission" activity only
            /// </summary>
            public string ChatbotHeroCardSubmissionKey { get; set; }

            /// <summary>
            /// "Chatbot HeroCard submission" activity only
            /// </summary>
            public string ChatbotHeroCardSubmissionValue { get; set; }
        }

        public class ActivityFile
        {
            /// <summary>
            /// Operator-owned files only.
            /// Operator user ID.
            /// </summary>
            public int? OperatorOwner { get; set; }

            /// <summary>
            /// Department-owned files only.
            /// Department ID.
            /// </summary>
            public int? DepartmentOwner { get; set; }

            /// <summary>
            /// Name of stored file.
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// File storage url for downloading the file.
            /// It is generated after the structure is read from stat db and deserialized.
            /// </summary>
            public string DownloadUrl { get; set; }
        }

        public class ActivityFormField
        {
            public string Key { get; set; }
            public string Label { get; set; }
            public bool Required { get; set; }

            public FormFieldInputType InputType { get; set; }

            public ICollection<ExportedActivityFormChoiceOption> ChoiceOptions { get; set; }
        }

        public class ExportedActivityFormChoiceOption
        {
            public string Value { get; set; }
            public string Label { get; set; }
        }

        public class Recording
        {
            public int Id { get; set; }

            /// <summary>
            /// Name of stored file.
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Time when this recording started.
            /// </summary>
            public DateTimeOffset? Started { get; set; }

            public int? ServiceId { get; set; }

            /// <summary>
            /// File storage url for downloading the file.
            /// It is generated after the structure is read from stat db and deserialized.
            /// </summary>
            public string DownloadUrl { get; set; }
        }

        /// <summary>
        /// Chatbot information
        /// </summary>
        public class ChatbotInfo
        {
            public int ChatbotId { get; set; }

            public string Name { get; set; }

            public DateTimeOffset Joined { get; set; }

            /// <summary>
            /// Chatbot left session.
            /// </summary>
            public DateTimeOffset? Left { get; set; }
        }
    }
}
