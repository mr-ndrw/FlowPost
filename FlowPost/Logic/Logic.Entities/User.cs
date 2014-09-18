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

        #region ForeignProperties

        /// <summary>
        /// Collection of Groups to which the User belongs.
        /// </summary>
        public List<Group> Groups { get; set; } 

        #endregion

    }
}
