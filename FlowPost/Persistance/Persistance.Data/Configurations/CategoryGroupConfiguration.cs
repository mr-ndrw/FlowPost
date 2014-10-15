using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Data.Configurations
{
	public class CategoryGroupConfiguration : EntityTypeConfiguration<CategoryGroup>
	{
		public CategoryGroupConfiguration()
		{
			/*	By convention EF will associate Category and CategoryGroup with one-to-many relationship, because in both Entities contain properties
			 *	which map it as such. That is: Category contains a reference to CategoryGroup, while CategoryGroup contains a collection of Categories.
			 */
		}
	}
}