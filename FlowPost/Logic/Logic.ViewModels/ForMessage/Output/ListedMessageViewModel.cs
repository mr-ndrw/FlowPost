using System;
using System.Threading;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForUser.Output;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.ForMessage.Output
{
	/// <summary>
	///		Contains simple data about messages, which is needed in listing contexts.
	/// </summary>
	public class ListedMessageViewModel
	{
		/// <summary>
		///		Initializes an object with data from the Message object.
		/// </summary>
		/// <param name="message">
		///		Message object for which we obtain the ViewModel.
		/// </param>
		public ListedMessageViewModel(Message message)
		{
			Id = message.Id;
			Subject = message.Subject;
			DateTime = message.DateTime;
			FromUser = new SimpleUserViewModel(message.FromUser);
			ToUser = new SimpleUserViewModel(message.ToUser);
		}

		/// <summary>
		///		Id of the message.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///		Subject of the message.
		/// </summary>
		public string Subject { get; set; }

		/// <summary>
		///		Date and time of the message dispatch.
		/// </summary>
		public DateTime DateTime { get; set; }

		//	Depending on the listing situation(whether the messages sent 
		//	or received are being viewed) one of the two SimpleUserViewModels
		//	will be null, depending on the described situation.

		/// <summary>
		///		Sender of the message.
		/// </summary>
		public SimpleUserViewModel FromUser { get; set; }

		/// <summary>
		///		Receiver of the message.
		/// </summary>
		public SimpleUserViewModel ToUser { get; set; }
	}
}
