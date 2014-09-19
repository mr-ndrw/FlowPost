using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
    /// <summary>
    /// Represents a User of the FlowPost forum.
    /// </summary>
    /// <remarks>
    /// No Entity Framework specific annotations were used.
    /// For configuration purposes please refer to [ClassName]Configuration file in ~/Configurations/Logic.Data
    /// </remarks>
    public class User
    {
        #region Properties

        /// <summary>
        /// User's unique name/nick/handle which serves as the Key.
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// Collection of Groups to which the User belongs.
        /// </summary>
        public List<Group> Groups { get; set; }

        /// <summary>
        /// Collection of banishments issued for this User.
        /// </summary>
        public List<Ban> Bans { get; set; }

        /// <summary>
        /// Collection of Posts created by this User.
        /// </summary>
        public List<Post> Posts { get; set; }

        /// <summary>
        /// Collection of Reports comitted against this User.
        /// </summary>
        public List<UserReport> UserReports { get; set; }

        /// <summary>
        /// Collection of Categories moderated by the User.
        /// </summary>
        public List<Category> ModeratedCategories { get; set; }

        #endregion //NavigationProperties
    }
}
