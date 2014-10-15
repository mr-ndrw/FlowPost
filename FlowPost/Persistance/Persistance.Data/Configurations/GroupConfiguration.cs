using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Data.Configurations
{
	/// <summary>
	///		Configuration class for Group entity defining relationships between entities, column types and entity behaviours.
	/// </summary>
	public class GroupConfiguration : EntityTypeConfiguration<Group>
	{
		public GroupConfiguration()
		{
			/*	ViewCatergories, EditCategories:
			 *	Configuration options between Group and Category Entity are included in CategoryConfiguration class.
			 */

			//----------------------------------------------------

			/*	Id:
			 *	Since Message entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			//	Name:
			Property(group => group.Name)
				.IsRequired()
				.HasMaxLength(50);

			//----------------------------------------------------

			/*	Users:
			 *	Many-to-many:
			 *	Specified table name: UsersGroups
			 */
			HasMany(message => message.Users)
				.WithMany(user => user.Groups)
				.Map(manyToMany => manyToMany.ToTable("UsersGroups"));

			//----------------------------------------------------

			/*	ModeratingUsers:
			 *	Many-to-many.
			 *	Specified table name: ModeratorsGroups
			 */
			HasMany(message => message.ModeratingUsers)
				.WithMany(user => user.ModeratedGroups)
				.Map(manyToMany => manyToMany.ToTable("ModeratorsGroups"));

			//----------------------------------------------------

		}
	}
}