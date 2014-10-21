using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Configurations
{
	/// <summary>
	///		Configuration class for Category entity defining relationships between entities, column types and entity behaviours.
	/// </summary>
	public class CategoryConfiguration : EntityTypeConfiguration<Category>
	{
		public CategoryConfiguration()
		{
			/*	Id:
			 *	Since Category entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			//	Name:
			Property(category => category.Name).IsRequired().HasMaxLength(50);

			//----------------------------------------------------

			/*	CategoryGroup:
			 *	By convention EF will associate Category and CategoryGroup with one-to-many relationship, because in both Entities contain properties
			 *	which map it as such. That is: Category contains a reference to CategoryGroup, while CategoryGroup contains a collection of Categories.
			 */

			//----------------------------------------------------

			//	Topics:

		    HasMany(category => category.Topics)
		        .WithRequired(topic => topic.Category);

			//----------------------------------------------------

			/*	LastPostDateTime, LastPosterUserName:
			 *	These do not depend on any property.
			 *	These exist as purely functional properties and will have to be updated as new Posts are added.
			 *	They are Required.
			 */
			Property(category => category.LastPostDateTime)
				.IsRequired();

			//----------------------------------------------------

			/*	LastPoster
			 */
			//TODO: Check if below is correct?
		    HasOptional(category => category.LastPoster)
		        .WithMany();

			//----------------------------------------------------

			/*	LastPost
			 */
			//TODO: Check if below is correct?
			//TODO: Map ForeignKey to Post?
			HasOptional(category => category.LastPost)
				.WithOptionalDependent();

			//----------------------------------------------------

			/*	Moderating Users:
			 *	Many-to-many.
			 *	Specified table name: ModeratorsCategories.
			 */
			HasMany(category => category.ModeratingUsers)
				.WithMany(user => user.ModeratedCategories)
				.Map(manyToMany => manyToMany.ToTable("ModeratorsCategories"));

			//----------------------------------------------------

			/*	ViewedByUsers:
			 *	Many-to-many.
			 *	Specified table name: UsersViewCategories
			 */
			HasMany(category => category.ViewedByUsers)
				.WithMany(user => user.ViewedCategories)
				.Map(manyToMany => manyToMany.ToTable("UsersViewCategories"));

			//----------------------------------------------------

			/*	EditedByUsers:
			 *	Many-to-many.
			 *	Specified table name: UsersEditCategory.
			 */
			HasMany(category => category.EditedByUsers)
				.WithMany(user => user.EditedCategories)
				.Map(manyToMany => manyToMany.ToTable("UsersEditCategories"));

			//----------------------------------------------------

			/*	ViewedByGroups:
			 *	Many-to-many.
			 *	Specified table name: GroupsViewCategories
			 */
			HasMany(category => category.ViewedByGroups).
				WithMany(group => group.ViewedCategories)
				.Map(manyToMany => manyToMany.ToTable("GroupsViewCategories"));

			//----------------------------------------------------

			/*	EditedByGroups:
			 *	Many-to-many.
			 *	Specified table name: GroupsEditCategories
			 */
			HasMany(category => category.EditedByGroups)
				.WithMany(group => group.EditedCategories)
				.Map(manyToMany => manyToMany.ToTable("GroupsEditCategories"));

			//----------------------------------------------------

		}
	}
}