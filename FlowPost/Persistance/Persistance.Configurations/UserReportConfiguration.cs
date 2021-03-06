﻿using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Configurations
{
	/// <summary>
	///		Configuration class for UserReport entity defining relationships between entities, column types and entity behaviours.
	/// </summary>
	public class UserReportConfiguration : EntityTypeConfiguration<UserReport>
	{
		public UserReportConfiguration()
		{
            /*  Inheritance configuration:
             */

            ToTable("UserReports");

            //----------------------------------------------------
			/*	Id:
			 *	Since UserReport entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			//	ReportedUser, ReportedUserId:
		    HasRequired(userReport => userReport.ReportedUser)
		        .WithMany(user => user.UserReports)
                .WillCascadeOnDelete(false);

			//----------------------------------------------------
		}
	}
}