using System.Collections.Generic;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForMessage;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForMessage.Output;

namespace en.AndrewTorski.FlowPost.Logic.Core.IServices
{
	/// <summary>
	///		Defines a contract for operations which manipulate around Message entity.
	/// </summary>
	public interface IMessageService
	{
		//List<ListedMessageViewModel> GetSentMessages(string userName);
		//List<ListedMessageViewModel> GetReceivedMessages(string userName);

		/// <summary>
		///		Gets a single message with all needed infomration to correctly display said message.
		/// </summary>
		/// <param name="id">
		///		Id of the message to fetch.
		/// </param>
		/// <returns>
		///		Returns the message with specified Id.
		/// </returns>
		/// <remarks>
		///		If no such message exists with given Id, null will be return.
		/// </remarks>
		MessageViewModel GetMessageById(int id);


		//	Consider: paged list for message view?
		/// <summary>
		///		Gets messages based on the specified userName, and specified context(sent, received, all messages)
		/// </summary>
		/// <param name="userName">
		///		Name of the user for which the messages are fetched.
		/// </param>
		/// <param name="listingContext">
		///		Context for which we get the message listing.
		/// </param>
		/// <returns>
		///		Returns a list of ListedViewModel objects.
		/// </returns>
		/// <remarks>
		///		Returns an empty list(count ==), if no such messages were found.
		/// </remarks>
		List<ListedMessageViewModel> GetMessages(string userName, MessageListingContext listingContext);
	}
}
