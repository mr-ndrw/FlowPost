﻿using System.Data.Entity;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Data.Configurations;

namespace en.AndrewTorski.FlowPost.Persistance.Data
{
	public class FlowPostDataContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Topic> Topics { get; set; }
		public DbSet<Ban> Bans { get; set; }
		public DbSet<PostEdit> PostEdits { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<UserReport> UserReports { get; set; }
		public DbSet<PostReport> PostReports { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<CategoryGroup> CategoryGroups { get; set; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new UserConfiguration());
		}
	}
}