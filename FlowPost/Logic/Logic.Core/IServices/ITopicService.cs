using en.AndrewTorski.FlowPost.Logic.ViewModels.ForTopic.Output;

namespace en.AndrewTorski.FlowPost.Logic.Core.IServices
{
	/// <summary>
	///		Defines a contract for inher
	/// </summary>
	public interface ITopicService
	{
		/// <summary>
		///		Gets a topic specified by it's id.
		/// </summary>
		/// <param name="id">
		///		Topic's id.
		/// </param>
		/// <returns>
		///		<see cref="TopicViewModel"/> with all of topic's underlying data.
		/// </returns>
		/// <remarks>
		///		Returns null if no such topic was found.
		/// </remarks>
		TopicViewModel GetTopicById(int id);
	}
}
