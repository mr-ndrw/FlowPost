using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Data.Configurations
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

		}
	}
}