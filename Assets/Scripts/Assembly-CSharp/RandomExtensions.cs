using System.Collections.Generic;

public static class RandomExtensions
{
	public static T GetRandomByWeight<T>(IEnumerable<T> list) where T : IHasWeight
	{
		return default;
	}

	public static T GetRandomByWeight<T>(IList<T> list) where T : IHasWeight
	{
		return default;
	}
}
