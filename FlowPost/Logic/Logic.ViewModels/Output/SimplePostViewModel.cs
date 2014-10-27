using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.Output
{
	/// <summary>
	///		Contains very simple data about a posted message.
	/// </summary>
	/// <remarks>
	///		Used in a context where we need to create a reference to a post(hence Id) and date of posting.
	/// </remarks>
	public class SimplePostViewModel
	{
		/// <summary>
		///		Id of the posted message.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///		Date when the message was posted.
		/// </summary>
		public DateTime DateOfPosting { get; set; }
	}
}
