using System;
using System.Collections.Generic;

public static class CollectionExtensions
{
	public static void AddRange<T>(this ISet<T> set, IEnumerable<T> enumerable)
	{
	}

	public static void AddRange<T>(this Queue<T> set, IEnumerable<T> enumerable)
	{
	}

	public static int FindIndex<T>(this IReadOnlyList<T> list, Predicate<T> predicate)
	{
		return 0;
	}
}
