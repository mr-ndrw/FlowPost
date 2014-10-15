﻿using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq.Expressions;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Data.Configurations
{
	/// <summary>
	///		Configuration class for Report entity defining relationships between entities, column types and entity behaviours.
	/// </summary>
	public class ReportConfiguration : EntityTypeConfiguration<Report>
	{
		public ReportConfiguration()
		{
			/*	Id:
			 *	Since Report entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			//	Content:
			Property(report => report.Content)
				.IsRequired()
				.HasMaxLength(500);

			//----------------------------------------------------

			// ModeratorReply:
			Property(report => report.ModeratorReply)
				.IsRequired()
				.HasMaxLength(500);

			//----------------------------------------------------

			//	DateTime:
			Property(report => report.DateTime)
				.IsRequired();

			//----------------------------------------------------

			//	IsResolved:
			Property(report => report.IsResolved)
				.IsRequired();

			//----------------------------------------------------

			//	ReportingUser, ReportingUserId
			HasRequired(report => report.ReportingUser)
				.WithMany(user => user.Reports)
				.HasForeignKey(report => report.ReportingUserId);

			//----------------------------------------------------

			//	ReportingUserName
			Property(report => report.ReportingUserName)
				.IsRequired();

			//----------------------------------------------------

			//	ModeratorUser, ModeratorUserId
			HasRequired(report => report.ModeratorUser)
				.WithMany(user => new List<Report>())
				.HasForeignKey(report => report.ModeratorUserId);

			//----------------------------------------------------

			//	ModeratorUserName
			Property(report => report.ModeratorUserName)
				.IsRequired();

			//----------------------------------------------------
		}
	}
}