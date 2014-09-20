using System;
using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
    /// <summary>
    /// Posted message on the forum. 
    /// </summary>
    /// 
    /// <remarks>
    /// 
    /// No Entity Framework specific annotations were used.
    /// For configuration purposes please refer to [ClassName]Configuration file in ~/Logic.Data/Configurations
    /// 
    /// </remarks>
    public class Post
    {
        #region Properties

        /// <summary>
        /// Unique identifier also serving as the Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The content of the Post.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Date and time of the message being posted.
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Hidden status.
        /// </summary>
        public bool IsHidden { get; set; }

        /// <summary>
        /// Closed status.
        /// </summary>
        public bool IsClosed { get; set; }

        /// <summary>
        /// Sticky status.
        /// </summary>
        public bool IsSticky { get; set; }

        /// <summary>
        /// Extraordinary status.
        /// </summary>
        public bool IsExtraordinary { get; set; }

        /// <summary>
        /// Number of strikes against the Post.
        /// </summary>
        public UInt16 Strikes { get; set; }

        /// <summary>
        /// The Post to which this post is a reply.
        /// </summary>
        public Post ParentPost { get; set; }

        #endregion //Properties

        #region NavigationProperties

        /// <summary>
        /// Name of the User which has posted this message.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// User which has posted this message.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Unique identifier of the catergory to which this Post belongs.
        /// </summary>       
        public int CategoryId { get; set; }

        /// <summary>
        /// The catergory to which this Post belongs.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Reports comitted to this Post.
        /// </summary>
        public virtual ICollection<PostReport> PostReports { get; set; }

        /// <summary>
        /// Collection of past PostEdits to this Post.
        /// </summary>
        public virtual ICollection<PostEdit> PostEdits { get; set; }

        #endregion //NavigationProperties
    }
}
