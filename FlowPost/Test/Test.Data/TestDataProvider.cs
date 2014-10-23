using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Data;
using Moq;

namespace en.AndrewTorski.FlowPost.Test.Data
{
	/// <summary>
	///     Provides various entity data for unit testing.
	/// </summary>
	public class TestDataProvider
	{
		#region Properties

		public Mock<FlowPostDataContext> MockedDbContext { get; private set; }

		#endregion

		#region Constructors

		public TestDataProvider()
		{
			MockedDbContext = new Mock<FlowPostDataContext>();

			#region MoqDbConfig

			MockedDbContext
					.Setup(ctx => ctx.Users)
					.Returns(MockedDbSetProvider<User>.GetDbSet().Object);

			MockedDbContext
				.Setup(ctx => ctx.Posts)
				.Returns(MockedDbSetProvider<Post>.GetDbSet().Object);

			MockedDbContext
				.Setup(ctx => ctx.Categories)
				.Returns(MockedDbSetProvider<Category>.GetDbSet().Object);

			MockedDbContext
				.Setup(ctx => ctx.CategoryGroups)
				.Returns(MockedDbSetProvider<CategoryGroup>.GetDbSet().Object);

			MockedDbContext
				.Setup(ctx => ctx.Topics)
				.Returns(MockedDbSetProvider<Topic>.GetDbSet().Object);

			MockedDbContext
				.Setup(ctx => ctx.PostReports)
				.Returns(MockedDbSetProvider<PostReport>.GetDbSet().Object);

			MockedDbContext
				.Setup(ctx => ctx.UserReports)
				.Returns(MockedDbSetProvider<UserReport>.GetDbSet().Object);

			MockedDbContext
				.Setup(ctx => ctx.Groups)
				.Returns(MockedDbSetProvider<Group>.GetDbSet().Object);

			MockedDbContext
				.Setup(ctx => ctx.Messages)
				.Returns(MockedDbSetProvider<Message>.GetDbSet().Object);

			MockedDbContext
				.Setup(ctx => ctx.Bans)
				.Returns(MockedDbSetProvider<Ban>.GetDbSet().Object);

			MockedDbContext
				.Setup(ctx => ctx.Bans)
				.Returns(MockedDbSetProvider<Ban>.GetDbSet().Object);

			MockedDbContext
				.Setup(ctx => ctx.PostEdits)
				.Returns(MockedDbSetProvider<PostEdit>.GetDbSet().Object); 

			#endregion
		}

		#endregion
	}
}