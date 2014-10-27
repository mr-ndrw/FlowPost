using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.Output
{
	/// <summary>
	///		Contains very simple data about the user.
	/// </summary>
	/// <remarks>
	///		Used in a context where we need to create a reference to a user using his Id and UserName.
	/// </remarks>
	public class SimpleUserViewModel
	{
		/// <summary>
		///		Id of the user.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///		Name of the user.
		/// </summary>
		public string UserName { get; set; }
	}
}
