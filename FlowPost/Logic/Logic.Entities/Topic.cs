using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
    /// <summary>
    /// Topical Post - a post with no parent post.
    /// </summary>
    public class Topic : Post
    {
        #region Properties

        /// <summary>
        ///     Title of the Topic.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     Hidden status.
        /// </summary>
        public bool IsHidden { get; set; }

        /// <summary>
        ///     Closed status.
        /// </summary>
        public bool IsClosed { get; set; }

        /// <summary>
        ///     Sticky status.
        /// </summary>
        public bool IsSticky { get; set; }

        /// <summary>
        ///     Extraordinary status.
        /// </summary>
        public bool IsExtraordinary { get; set; }

        /// <summary>
        ///     Number of views this Topic has gotten.
        /// </summary>
        public int Views { get; set; }

        /// <summary>
        ///     Number of posted replies to this Topic.
        /// </summary>
        public int NumberOfReplies { get; set; }


        #endregion

        #region NavigationProperties

        /// <summary>
        ///     Collection of posts which are replies to this Topic.
        /// </summary>
        public virtual ICollection<Post> Posts { get; set; }

        #endregion
    }
}
