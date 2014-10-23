using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Moq;

namespace en.AndrewTorski.FlowPost.Test.Data
{

	/// <summary>
	///		Provides a clean way to get a Typed DbSet configuration to use with Moq.
	/// </summary>
	/// <typeparam name="TEntity">The type of the entity.</typeparam>
	public static class MockedDbSetProvider<TEntity> 
		where TEntity : class
	{

		/// <summary>
		///		Gets a configured Typed DbSet.
		/// </summary>
		/// <returns>
		///		Configured Typed DbSet
		/// </returns>
		public static Mock<DbSet<TEntity>> GetDbSet()
		{
			var mockedUserSet = new Mock<DbSet<TEntity>>();
			var userData = new List<TEntity>().AsQueryable();

			mockedUserSet.As<IQueryable<TEntity>>().Setup(m => m.Provider).Returns(userData.Provider);
			mockedUserSet.As<IQueryable<TEntity>>().Setup(m => m.Expression).Returns(userData.Expression);
			mockedUserSet.As<IQueryable<TEntity>>().Setup(m => m.ElementType).Returns(userData.ElementType);
			mockedUserSet.As<IQueryable<TEntity>>().Setup(m => m.GetEnumerator()).Returns(userData.GetEnumerator());

			return mockedUserSet;
		}
	}
}
