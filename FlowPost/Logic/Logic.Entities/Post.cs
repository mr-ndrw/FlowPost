using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
    /// <summary>
    /// Posted message on the forum. 
    /// </summary>
    /// 
    /// <remarks>
    /// Post 
    /// 
    /// No Entity Framework specific annotations were used.
    /// For configuration purposes please refer to [ClassName]Configuration file in ~/Logic.Data/Configurations
    /// 
    /// </remarks>
    public class Post
    {
        #region Properties

        /// <summary>
        /// Post's unique identifier also serving as the Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The content of the Post.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Sticky status.
        /// </summary>
        public bool IsSticky { get; set; }

        /// <summary>
        /// Extraordinary status.
        /// </summary>
        public bool IsExtraordinary { get; set; }

        /// <summary>
        /// The Post to which this post is a reply.
        /// </summary>
        public Post ParentPost { get; set; }

        #endregion

        #region ForeignProperties

        /// <summary>
        /// User which has posted this message.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// List of past PostEdits to this Post.
        /// </summary>
        public List<PostEdit> PostEdits { get; set; }

        /// <summary>
        /// The catergory to which this Post belongs.
        /// </summary>
        public Category Category { get; set; }
        #endregion
    }
}
