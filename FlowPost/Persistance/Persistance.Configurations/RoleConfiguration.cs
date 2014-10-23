using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Configurations
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
	        Property(role => role.Name)
		        .IsRequired()
		        .HasMaxLength(256)
		        .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("RoleNameIndex") {IsUnique = true}));

	        HasMany(role => role.Users)
		        .WithRequired()
		        .HasForeignKey(ur => ur.RoleId);
        }
    }
}
