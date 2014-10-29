using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
		
		/// <summary>
		///		Mocked FlowPostDataContext
		/// </summary>
		public Mock<FlowPostDataContext> MockedDbContext { get; private set; }

		#endregion

		#region Constructors

		public MockedDbContextProvider()
		{
			MockedDbContext = new Mock<FlowPostDataContext>();
		}

		#endregion

		//	It seems that for every Entity class in the project, we may have to provide
		//	a seperate SetUp[Entity]DbSet method to initialize our DbSet.
		//	TODO: Test whether the tracking functionality of EntityFramework will work with mocked  DbContext.
		//	http://fakedbconnection.codeplex.com/
		//	Above might be a viable solution and good substitution for the recent Mocking efforts.


		public void SetUpUserDbSet(List<User> dataSet)
		{
			var mockedDbSet = new Mock<IDbSet<User>>();
			var data = dataSet.AsQueryable();

			mockedDbSet.As<IQueryable>().Setup(m => m.Provider).Returns(data.Provider);
			mockedDbSet.As<IQueryable>().Setup(m => m.Expression).Returns(data.Expression);
			mockedDbSet.As<IQueryable>().Setup(m => m.ElementType).Returns(data.ElementType);
			mockedDbSet.As<IQueryable>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

			MockedDbContext
				.Setup(ctx => ctx.Users)
				.Returns(mockedDbSet.Object);
		}
	}
}