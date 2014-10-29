using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using en.AndrewTorski.FlowPost.Logic.Core.IServices;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForMessage;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForMessage.Output;
using en.AndrewTorski.FlowPost.Persistance.Data;

namespace en.AndrewTorski.FlowPost.Logic.Core.Services
{
	/// <summary>
	///     Gives access to methods operating on Message entity.
	/// </summary>
	public class MessageService : IMessageService
	{
		private readonly IFlowPostDataContext _dbContext;

		/// <summary>
		///     Initializes an object with an injection of data acces class object.
		/// </summary>
		/// <param name="dbContext">
		///     Injected object of class which implements IFlowPostDataContext interface.
		/// </param>
		public MessageService(IFlowPostDataContext dbContext)
		{
			_dbContext = dbContext;
		}

		/// <summary>
		///     Gets a single message with all needed infomration to correctly display said message.
		/// </summary>
		/// <param name="id">
		///     Id of the message to fetch.
		/// </param>
		/// <returns>
		///     Returns the message with specified Id.
		/// </returns>
		/// <remarks>
		///     If no such message exists with given Id, null will be return.
		/// </remarks>
		public MessageViewModel GetMessageById(int id)
		{
			var messageToFind = _dbContext.Messages.Find(id);

			if (messageToFind == null)
			{
				return null;
			}

			var result = new MessageViewModel(messageToFind);

			return result;
		}

		/// <summary>
		///     Gets messages based on the specified userName, and specified context(sent, received, all messages)
		/// </summary>
		/// <param name="userName">
		///     Name of the user for which the messages are fetched.
		/// </param>
		/// <param name="listingContext">
		///     Context for which we get the message listing.
		/// </param>
		/// <returns>
		///     Returns a list of ListedViewModel objects.
		/// </returns>
		/// <remarks>
		///     Returns an empty list(count ==), if no such messages were found.
		/// </remarks>
		public List<ListedMessageViewModel> GetMessages(string userName, MessageListingContext listingContext)
		{
			Expression<Func<Message, bool>> predicate;
			switch (listingContext)
			{
				case MessageListingContext.MessagesReceived:
				{
					predicate = message => message.ToUser.UserName == userName;
					break;
				}
				case MessageListingContext.MessagesSent:
				{
					predicate = message => message.FromUser.UserName == userName;
					break;
				}
				case MessageListingContext.MessagesAll:
				{
					predicate = message => message.FromUser.UserName == userName
					                       || message.ToUser.UserName == userName;
					break;
				}
				default:
				{
					//	Should never get here.
					predicate = model => false;
					//	Consider: exception?
					break;
				}
			}
			//	If we want firstly to filter the Messages(!!, not the ListedMessageViewModels)
			//	right after the DbSet, a Where() expression should follow. It should be strongly
			//	typed with Message.
			var result = _dbContext.Messages
				.Where(predicate)
				.Select(message => new ListedMessageViewModel(message))
				.OrderByDescending(listedMessageViewModel => listedMessageViewModel.DateTime)
				.ToList();

			return result;
		}
	}
}