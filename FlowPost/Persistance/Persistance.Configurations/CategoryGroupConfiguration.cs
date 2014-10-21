using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Configurations
{
	public class CategoryGroupConfiguration : EntityTypeConfiguration<CategoryGroup>
	{
		public CategoryGroupConfiguration()
		{
			/*	Id:
			 * Since CategoryGroup entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			//	Name:
			Property(categoryGroup => categoryGroup.Name).IsRequired().HasMaxLength(50);

			//----------------------------------------------------

			/*	Categories:
			 *	By convention EF will associate Category and CategoryGroup with one-to-many relationship, because in both Entities contain properties
			 *	which map it as such. That is: Category contains a reference to CategoryGroup, while CategoryGroup contains a collection of Categories.
			 */
		}
	}
}