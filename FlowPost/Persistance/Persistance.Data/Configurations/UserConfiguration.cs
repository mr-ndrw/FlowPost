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
			/*	ViewedCategories, EditedCategories:
			 *	Configuration options between User and Category Entity are included in CategoryConfiguration class.
			 */

			//----------------------------------------------------

			/*	ModeratedCategories:
			 *	Configuration options between User and Category entity are included in CategoryConfiguration class.
			 */

			//----------------------------------------------------

		}
	}
}