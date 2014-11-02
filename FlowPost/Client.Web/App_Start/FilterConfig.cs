using System.Web.Mvc;

namespace en.AndrewTorski.FlowPost.Client.Web
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
