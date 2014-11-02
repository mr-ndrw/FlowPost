using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.ForUser.Input
{
	public class RegisterViewModel
	{
		public string UserName { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public DateTime DateOfBirth { get; set; }

		public string Country { get; set; }
	}
}
