using System.Collections.Generic;
using System.Linq;
using en.AndrewTorski.FlowPost.Logic.Core.IServices;
using en.AndrewTorski.FlowPost.Logic.Core.Services;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Data;
using en.AndrewTorski.FlowPost.Test.Data;
using NUnit.Framework;

namespace en.AndrewTorski.FlowPost.Test.Logic.Core
{
	/// <summary>
	///     Test class for UserService class.
	/// </summary>
	[TestFixture]
	public class UserServiceTest
	{
/*
 *		Consider: Unit Test strategy.
 *		1)	a.	Initialize the DbSets with an arbitrary number of entity with Random data. 
 *			b.	Upon entering the Unit Test [method] pick a random entity directly from the _dbContext and choose it for testing.
 *			c.	Make a deep copy of that entity.
 *			d.	Send the original entity to methods, operations, etc.
 *			e.	After the tested functionality has returned to the Unit Test compare the returned object values, behaviour etc.
 *				with modified EXPECTED values of the Deep Copied entity.
 *		
 *		2)	a.	?
 */

		/// <summary>
		///     Service which is being tested in this Test.
		/// </summary>
		private IUserService _userService;

		/// <summary>
		///		The database context.
		/// </summary>
		private IFlowPostDataContext _dbContext;

		/// <summary>
		///     Initializes the data for the test.
		/// </summary>
		[TestFixtureSetUp]
		public void InitialSetup()
		{
			//	Initialize mocked and preconfigured DataContext using MockedDbContextProvider instance.

			var user = new User
			{
				Id = 65,
				UserName =  "Test",
				NumberOfPosts = 0
			};

			var data = new List<User>{user};

			var dataProvider = new MockedDbContextProvider();

			//Register nonempty userList
			dataProvider.SetUpUserDbSet(data);

			_dbContext = dataProvider.MockedDbContext.Object;

			_userService = new UserService(_dbContext);
		}

		[Test]
		public void AssertUserDbSetIsNull()
		{
			Assert.That(_dbContext.Users, Is.Null);
		}

		[Test]
		public void GetUserByIdTestExists()
		{
			var foundUser = _userService.GetUserById(65);

			Assert.That(foundUser, Is.Not.Null);
			/*Assert.That(foundUser.Id, Is.EqualTo(65));
			Assert.That(foundUser.UserName, Is.EqualTo("Test"));
			Assert.That(foundUser.NumberOfPosts, Is.EqualTo(0));*/
		}

		[Test]
		public void GetUserByIdTestNull()
		{
			var notFoundUser = _userService.GetUserById(2345345);

			Assert.That(notFoundUser, Is.Null);
		}


		#region NonTestMembers

		private void InitializeContextWithData(IFlowPostDataContext mockedContext)
		{
			
		}

		#endregion
	}
}