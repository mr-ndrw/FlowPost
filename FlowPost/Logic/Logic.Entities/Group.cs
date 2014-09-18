using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
    /// <summary>
    /// Represents a Group of Users.
    /// </summary>
    /// <remarks>
    /// No Entity Framework specific annotations were used.
    /// For configuration purposes please refer to [ClassName]Configuration file in ~/Logic.Data/Configurations
    /// </remarks>
    public class Group
    {
        #region Properties

        /// <summary>
        /// Group's unique identifier which serves as the Key.
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// Group's name.
        /// </summary>
        public string GroupName { get; set; }

        #endregion

        #region ForeignProperties

        /// <summary>
        /// Collection of Users which belong to this Group
        /// </summary>
        public List<User> Users { get; set; }

        #endregion
    }
}
