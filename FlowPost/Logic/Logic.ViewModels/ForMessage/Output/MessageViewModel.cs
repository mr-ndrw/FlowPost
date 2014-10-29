using System;
using System.Net.Mime;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForUser.Output;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.ForMessage.Output
{
	/// <summary>
	///		Contains data about a message.
	/// </summary>
	public class MessageViewModel
	{
		/// <summary>
		///		Initializes an object with data from Message object.
		/// </summary>
		/// <param name="message">
		///		Message object for which we obtain the ViewModel.
		/// </param>
		public MessageViewModel(Message message)
		{
			Id = message.Id;
			Subject = message.Subject;
			DateTime = message.DateTime;
			RawContent = message.RawContent;
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
		///		Content of message.
		/// </summary>
		public string RawContent { get; set; }

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
