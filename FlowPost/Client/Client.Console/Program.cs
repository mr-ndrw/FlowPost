using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Data;

namespace en.AndrewTorski.FlowPost.Client.Console
{
	public class Program
	{
		private static void Main(string[] args)
		{
			using (var db = new FlowPostDataContext())
			{
				var maxUser = db.Users.SingleOrDefault();

				var catGro = new CategoryGroup
				{
					Name = "NiceCatGroup",
					Categories = new List<Category>()
				};

				db.Entry(catGro).State = EntityState.Added;

				var cat = new Category
				{
					Name = "NiceCat",
					ParentCategory = null,
					ModeratingUsers = new List<User>(),
					CategoryGroup = catGro
				};

				db.Entry(cat).State = EntityState.Added;

				cat.ModeratingUsers.Add(maxUser);

				var topic = new Topic
				{
					User = maxUser,
					Category = cat,
					Subject = "Nice Subject",
					RawContent = "LoremIpsum",
					HtmlContent = "LoremIpsum",
					BbCodeContent = "LoremIpsum",
					IsExtraordinary = true,
					ParentTopic = null,
					
				};

				db.Entry(topic).State = EntityState.Added;

				System.Console.WriteLine("1: ");
				System.Console.Write(maxUser.Posts.SingleOrDefault().HtmlContent);

				System.Console.WriteLine("2: {0}", cat.Topics.SingleOrDefault().Subject);

				System.Console.WriteLine("3: {0}", cat.ModeratingUsers.SingleOrDefault().UserName);

				//db.SaveChanges();

				System.Console.ReadKey();
			}
		}
	}
}