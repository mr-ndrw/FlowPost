using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Configurations
{
	/// <summary>
	///		Configuration class for PostEdit entity defining relationships between entities, column types and entity behaviours.
	/// </summary>
	public class PostEditConfiguration : EntityTypeConfiguration<PostEdit>
	{
		public PostEditConfiguration()
		{
			/*	Id:
			 * Since Message entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			/*	Post:
			 *	Configuration logic already included in PostConfiguration class.
			 */

			//----------------------------------------------------

			//	HtmlContent, BbCodeContent, RawContent:
			Property(edit => edit.HtmlContent)
				.IsRequired()
				.HasMaxLength(40000);

			Property(edit => edit.BbCodeContent)
				.IsRequired()
				.HasMaxLength(40000);

			Property(edit => edit.RawContent)
				.IsRequired()
				.HasMaxLength(40000);

			//----------------------------------------------------

			//	DateTime:
			Property(edit => edit.DateTime)
				.IsRequired();

			//----------------------------------------------------
		}
	}
}