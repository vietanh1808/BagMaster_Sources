using System.Collections.Generic;

namespace Game
{
	public static class ResoureViewExtensions
	{
		public static List<ResourceView> UpdateInfo(this List<ResourceView> resourceViews, IReadOnlyCollection<ResourceRewardData> datas, bool sort = true)
		{
			return null;
		}

		public static List<ResourceView> UpdateInfo(this List<ResourceView> resourceViews, IReadOnlyCollection<ResourceRewardDataRef> datas, bool sort = true)
		{
			return null;
		}

		public static void SortByRarity(this List<ResourceView> currencyViews)
		{
		}

		private static int SortByRarity(ResourceView x, ResourceView y)
		{
			return 0;
		}
	}
}
