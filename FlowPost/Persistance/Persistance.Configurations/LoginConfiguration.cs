using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Configurations
{
    public class LoginConfiguration : EntityTypeConfiguration<Login>
    {
        public LoginConfiguration()
        {
			//	Primary Key;
	        HasKey(login => new {login.LoginProvider, login.ProviderKey, login.UserId});
        }
    }
}
