using System.Collections.Generic;
using System.Data.Entity;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Data;
using Moq;

namespace en.AndrewTorski.FlowPost.Test.Data
{
	/// <summary>
	///     Provides various entity data for unit testing.
	/// </summary>
	public class MockedDbContextProvider
	{
		#region Properties

		public Mock<FlowPostDataContext> MockedDbContext { get; private set; }

		#endregion

		#region Constructors

		public MockedDbContextProvider()
		{
			MockedDbContext = new Mock<FlowPostDataContext>();
			/*#region MoqDbConfig

			MockedDbContext
					.Setup(ctx => ctx.Users)
					.Returns(MockedDbSetProvider.GetDbSet<User>().Object);

			MockedDbContext
				.Setup(ctx => ctx.Posts)
				.Returns(MockedDbSetProvider.GetDbSet<Post>().Object);

			MockedDbContext
				.Setup(ctx => ctx.Categories)
				.Returns(MockedDbSetProvider.GetDbSet<Category>().Object);

			MockedDbContext
				.Setup(ctx => ctx.CategoryGroups)
				.Returns(MockedDbSetProvider.GetDbSet<CategoryGroup>().Object);

			MockedDbContext
				.Setup(ctx => ctx.Topics)
				.Returns(MockedDbSetProvider.GetDbSet<Topic>().Object);

			MockedDbContext
				.Setup(ctx => ctx.PostReports)
				.Returns(MockedDbSetProvider.GetDbSet<PostReport>().Object);

			MockedDbContext
				.Setup(ctx => ctx.UserReports)
				.Returns(MockedDbSetProvider.GetDbSet<UserReport>().Object);

			MockedDbContext
				.Setup(ctx => cC:\Users\andre_000\Source\Repos\FlowPost\FlowPost\Test\Test.Data\MockedDbContextProvider.cstx.Groups)
				.Returns(MockedDbSetProvider.GetDbSet<Group>().Object);

			MockedDbContext
				.Setup(ctx => ctx.Messages)
				.Returns(MockedDbSetProvider.GetDbSet<Message>().Object);

			MockedDbContext
				.Setup(ctx => ctx.Bans)
				.Returns(MockedDbSetProvider.GetDbSet<Ban>().Object);

			MockedDbContext
				.Setup(ctx => ctx.Bans)
				.Returns(MockedDbSetProvider.GetDbSet<Ban>().Object);

			MockedDbContext
				.Setup(ctx => ctx.PostEdits)
				.Returns(MockedDbSetProvider.GetDbSet<PostEdit>().Object); 
			#endregion
*/
		}

		#endregion

		public void SetUpDbSet<TEntity>(List<TEntity> dataSet) where TEntity : class
		{
			MockedDbContext
				.Setup(ctx => ctx.Users)
				.Returns(MockedDbSetProvider.GetDbSet(dataSet).Object as IDbSet<User>);
		}
	}
}