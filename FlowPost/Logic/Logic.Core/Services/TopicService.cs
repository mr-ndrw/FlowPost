using en.AndrewTorski.FlowPost.Logic.Core.IServices;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForTopic.Output;
using en.AndrewTorski.FlowPost.Persistance.Data;

namespace en.AndrewTorski.FlowPost.Logic.Core.Services
{
	/// <summary>
	///		Gives access to operations which manipulate around the Topic entity.
	/// </summary>
	public class TopicService : ITopicService
	{
		/// <summary>
		///		Data access reference.
		/// </summary>
		private readonly IFlowPostDataContext _dbContext;

		/// <summary>
		///		Initializes a service with an injection of Data access class.
		/// </summary>
		/// <param name="dbContext">
		///		Data access context.
		/// </param>
		public TopicService(IFlowPostDataContext dbContext)
		{
			_dbContext = dbContext;
		}

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
		public TopicViewModel GetTopicById(int id)
		{
			var topicToFind = _dbContext.Topics
				.Include("Posts")
				.Single(topic => topic.Id == id);

			if (topicToFind == null)
			{
				return null;
			}

			var result = new TopicViewModel(topicToFind);

			return result;
		}
	}
}
