using System;
using System.Runtime.InteropServices;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Data;

namespace en.AndrewTorski.FlowPost.Client.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new FlowPostDataContext())
            {
                var user = new User
                {
                    UserName = "MaxPower",
                    Country = "Poland",
                    PasswordHash = "qwerty",
                    Email = "max@max.com",
                    DateOfBirth = new DateTime(2000, 12, 30),
                    NumberOfPosts = 2
                };

                db.Users.Add(user);
                db.SaveChanges();

                foreach (var oneUser in db.Users)
                {
                    System.Console.WriteLine("{0}", oneUser.UserName);
                }

                System.Console.ReadKey();
            }
        }
    }
}
