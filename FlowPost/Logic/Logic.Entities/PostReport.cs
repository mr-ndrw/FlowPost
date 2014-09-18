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

        #region ForeignProperties

        /// <summary>
        /// Post which is reported.
        /// </summary>
        public Post Post { get; set; }

        /// <summary>
        /// Reporting User.
        /// </summary>
        public User ReportingUser { get; set; }

        /// <summary>
        /// Moderator which has replied to this message.
        /// </summary>
        public User ModeratorUser { get; set; }
        #endregion //ForeignProperties
    }
}
