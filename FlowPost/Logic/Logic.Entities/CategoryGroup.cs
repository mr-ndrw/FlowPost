using System;
using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
    /// <summary>
    /// Groups multiple Categories into one entity.
    /// </summary>
    /// <remarks>
    /// No Entity Framework specific annotations were used.
    /// For configuration purposes please refer to [ClassName]Configuration file in ~/Logic.Data/Configurations
    /// </remarks>
    public class CategoryGroup
    {
        #region Properties

        /// <summary>
        /// Unique identifier which also serves as the Key.
        /// </summary>
        public UInt16 Id { get; set; }

        /// <summary>
        /// Name of the group.
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// Collection of Categories which belong to this group.
        /// </summary>
        public virtual ICollection<Category> Categories { get; set; } 

        #endregion
    }
}
