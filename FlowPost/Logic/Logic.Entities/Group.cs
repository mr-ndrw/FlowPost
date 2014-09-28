using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
    /// <summary>
    ///     Represents a Group of Users.
    /// </summary>
    /// <remarks>
    ///     No Entity Framework specific annotations were used.
    ///     For configuration purposes please refer to [ClassName]Configuration file in ~/Logic.Data/Configurations
    /// </remarks>
    public class Group
    {
        #region Properties

        /// <summary>
        ///     Group's unique identifier which serves as the Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Group's name.
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     Collection of Users which belong to this Group
        /// </summary>
        public virtual ICollection<User> Users { get; set; }

        /// <summary>
        ///     Collection of Categories which can be viewed by the members of the Group.
        /// </summary>
        public virtual ICollection<Category> CanViewCategories { get; set; }

        /// <summary>
        ///     Collection of Categories which can be viewed and edited by the members of the Group.  
        /// </summary>
        public virtual ICollection<Category> CanViewAndEditCategories { get; set; }

        /// <summary>
        ///     Collection of Users which can manage the group.
        /// </summary>
        public virtual ICollection<User> ModeratingUsers { get; set; } 

        #endregion
    }
}