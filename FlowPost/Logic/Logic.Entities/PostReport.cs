using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
    /// <summary>
    /// Report made on Post.
    /// </summary>
    public class PostReport
    {
        #region Properties

        /// <summary>
        /// Unique identifier which also serves as a Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Message of the report.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Date and time of the report.
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Has the report been resolved by the moderating officers.
        /// </summary>
        public bool IsResolved { get; set; }

        /// <summary>
        /// Moderating officer's message to this report.
        /// </summary>
        public string ModeratorReply { get; set; }

        #endregion //Properties

        #region NavigationProperties

        /// <summary>
        /// Unique identifier of the reported Post.
        /// </summary>
        public int PostId { get; set; }

        /// <summary>
        /// Reported post in question.
        /// </summary>
        public Post Post { get; set; }

        /// <summary>
        /// Name of the reporting User.
        /// </summary>
        public string ReportingUserName { get; set; }

        /// <summary>
        /// Reporting User.
        /// </summary>
        public User ReportingUser { get; set; }

        /// <summary>
        /// Name of the moderator which has replied to this message.
        /// </summary>
        public string ModeratorUserName { get; set; }

        /// <summary>
        /// Moderator which has replied to this message.
        /// </summary>
        public User ModeratorUser { get; set; }

        #endregion //NavigationProperties
    }
}
