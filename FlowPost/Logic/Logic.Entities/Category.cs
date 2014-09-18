using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
    /// <summary>
    /// Structure which contains Posts and children Categories.
    /// </summary>
    /// <remarks>
    /// No Entity Framework specific annotations were used.
    /// For configuration purposes please refer to [ClassName]Configuration file in ~/Logic.Data/Configurations
    /// </remarks>
    public class Category
    {
        #region Properties
        /// <summary>
        /// Category's unique identifier which serves as the Key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Catergory's name.
        /// </summary>
        public string CategoryName { get; set; }

        public Category ParentCategory { get; set; }
        #endregion

        #region ForeignProperties

        /// <summary>
        /// Collection of Categories to which this Category is a parent.
        /// </summary>
        public List<Category> Categories { get; set; }

        /// <summary>
        /// List of posts which were posted to this Category.
        /// </summary>
        public List<Post> Posts { get; set; } 

        #endregion
    }
}
