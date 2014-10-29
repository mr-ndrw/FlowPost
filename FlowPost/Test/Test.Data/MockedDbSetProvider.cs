using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Moq;

namespace en.AndrewTorski.FlowPost.Test.Data
{
	/// <summary>
	///     Provides a clean way to get a Typed DbSet configuration to use with Moq.
	/// </summary>
	public static class MockedDbSetProvider
	{
		/// <summary>
		///     Gets a empty, configured Typed DbSet.
		/// </summary>
		/// <returns>
		///     Configured Typed DbSet
		/// </returns>
		public static Mock<DbSet<TEntity>> GetDbSet<TEntity>() where TEntity : class
		{
			var mockedDbSet = new Mock<DbSet<TEntity>>();
			var data = new List<TEntity>().AsQueryable();

			mockedDbSet.As<IQueryable<TEntity>>().Setup(m => m.Provider).Returns(data.Provider);
			mockedDbSet.As<IQueryable<TEntity>>().Setup(m => m.Expression).Returns(data.Expression);
			mockedDbSet.As<IQueryable<TEntity>>().Setup(m => m.ElementType).Returns(data.ElementType);
			mockedDbSet.As<IQueryable<TEntity>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

			return mockedDbSet;
		}




		/// <summary>
		///		Returns a typed, nonempty DbSet.
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="dataSet">
		///		Data for DbSet to include.
		/// </param>
		/// <returns>
		///		Typed, nonempty DbSet.
		///	</returns>
		public static Mock<DbSet<TEntity>> GetDbSet<TEntity>(List<TEntity> dataSet) where TEntity : class

		{
			var mockedDbSet = new Mock<DbSet<TEntity>>();
			var data = dataSet.AsQueryable();

			mockedDbSet.As<IQueryable<TEntity>>().Setup(m => m.Provider).Returns(data.Provider);
			mockedDbSet.As<IQueryable<TEntity>>().Setup(m => m.Expression).Returns(data.Expression);
			mockedDbSet.As<IQueryable<TEntity>>().Setup(m => m.ElementType).Returns(data.ElementType);
			mockedDbSet.As<IQueryable<TEntity>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

			return mockedDbSet;
		}
	}
}