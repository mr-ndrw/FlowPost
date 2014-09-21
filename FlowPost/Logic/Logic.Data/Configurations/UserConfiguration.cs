using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Logic.Data.Configurations
{
    /// <summary>
    ///     Configuration options for User entity.
    /// </summary>
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        /// <summary>
        ///     Configuration options constructor for User entity.
        /// </summary>
        public UserConfiguration()
        {
            HasKey(u => u.Name);
        }
    }
}