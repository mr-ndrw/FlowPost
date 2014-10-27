using en.AndrewTorski.FlowPost.Logic.ViewModels.ForCategory.Output;

namespace en.AndrewTorski.FlowPost.Logic.Core.IServices
{
	public interface ICategoryService
	{
		/// <summary>
		///		Gets a category by it's id.
		/// </summary>
		/// <param name="id">
		///		Category's Id.
		/// </param>
		/// <returns>
		///		<see cref="CategoryViewModel"/> with all of category's underlying data. 
		/// </returns>
		/// <remarks>
		///		Returns null, if no such Id was found.
		/// </remarks>
		CategoryViewModel GetCategoryById(int id);
	}
}
