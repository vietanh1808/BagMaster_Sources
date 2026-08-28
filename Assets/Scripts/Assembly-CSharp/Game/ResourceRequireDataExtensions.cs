using System.Collections.Generic;

namespace Game
{
	public static class ResourceRequireDataExtensions
	{
		public static bool IsEnough(this List<ResourceRequireData> requires)
		{
			return false;
		}

		public static void Cost(this List<ResourceRequireData> requires, string source)
		{
		}

		public static List<ResourceRequireData> ToIngameCost(this string rawData)
		{
			return null;
		}
	}
}
