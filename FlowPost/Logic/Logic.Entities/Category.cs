namespace en.AndrewTorski.FlowPost.Logic.Entities
{
    /// <summary>
    /// Structure which contains Posts and other subCategories in itself.
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
        public int CategoryId { get; set; }

        /// <summary>
        /// Catergory's name.
        /// </summary>
        public string CategoryName { get; set; }

        #endregion

        #region ForeignProperties



        #endregion
    }
}
