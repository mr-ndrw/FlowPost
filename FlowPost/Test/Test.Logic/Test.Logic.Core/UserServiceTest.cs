using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using en.AndrewTorski.FlowPost.Logic.Core.IServices;
using en.AndrewTorski.FlowPost.Logic.Core.Services;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.Output;
using en.AndrewTorski.FlowPost.Persistance.Data;
using Moq;
using NUnit.Framework;

namespace Test.Logic.Core
{
	/// <summary>
	///     Test class for UserService class.
	/// </summary>
	[TestFixture]
	public class UserServiceTest
	{
		/// <summary>
		///     Service which is being tested in this Test.
		/// </summary>
		private IUserService _userService;

		/// <summary>
		///     Initializes the data for the test.
		/// </summary>
		[TestFixtureSetUp]
		public void InitialSetup()
		{
			//	Mock DbSets that we are going to use througout the tests.

			IQueryable<User> userData = new List<User>
			{
				// User id = 65 has no Groups nor Posts attached to him.
				new User
				{
					Id = 65,
					UserName = "Test",
					DateOfBirth = new DateTime(1993, 12, 13),
					Email = "test@test.test",
					PasswordHash = "test",
					NumberOfPosts = 0
				}
			}.AsQueryable();


			var mockUserSet = new Mock<DbSet<User>>();
			mockUserSet.As<IQueryable<User>>().Setup(m => m.Provider).Returns(userData.Provider);
			mockUserSet.As<IQueryable<User>>().Setup(m => m.Expression).Returns(userData.Expression);
			mockUserSet.As<IQueryable<User>>().Setup(m => m.ElementType).Returns(userData.ElementType);
			mockUserSet.As<IQueryable<User>>().Setup(m => m.GetEnumerator()).Returns(userData.GetEnumerator());

			//	~End of mocked DbSets.

			//	Mock FlowPostDataContext.
			var mockContext = new Mock<FlowPostDataContext>();
			mockContext.Setup(context => context.Users).Returns(mockUserSet.Object);
			//	~End of context mocking.

			//	Instantiate _userService

			_userService = new UserService(mockContext.Object);
		}

		[Test]
		public void GetUserByIdTestExists()
		{
			var foundUser = _userService.GetUserById(65);

			Assert.That(foundUser.Id, Is.EqualTo(65));
			Assert.That(foundUser.UserName, Is.EqualTo("Test"));
			Assert.That(foundUser.NumberOfPosts, Is.EqualTo(0));
		}

		[Test]
		public void GetUserByIdTestNull()
		{
		}
	}
}