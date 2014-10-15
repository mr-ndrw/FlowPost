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

			/*	Bans:
			 *	Configuration options between User and Ban entity are included in BanConfiguration class.
			 */

			//----------------------------------------------------

			/*	Groups:
			 *	Configuration options between User and Groups entity are included in GroupConfiguration class.
			 */

			//----------------------------------------------------

			/*	Id:
			 *	Since Category entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			//	UserName, Email:

			Property(user => user.UserName)
				.IsRequired()
				.HasMaxLength(20);

			Property(user => user.Email)
				.IsRequired()
				.HasMaxLength(340)
				.HasColumnType("VARCHAR");

			/*	Email MaxLength is dictated by the standard included in RFC-5321 http://tools.ietf.org/html/rfc5321.html.
			 *	- 64 characters for the "local part" (username).
			 *	- 1 character for the @ symbol.
			 *	- 255 characters for the domain name.
			 */

			//----------------------------------------------------

			//	DateOfBirth
			Property(user => user.DateOfBirth)
				.IsRequired();

			//----------------------------------------------------

			//	NumberOfPosts
			Property(user => user.NumberOfPosts)
				.IsRequired();

			//----------------------------------------------------

			//	Country:
			Property(user => user.Country)
				.IsRequired();

			//----------------------------------------------------
		}
	}
}