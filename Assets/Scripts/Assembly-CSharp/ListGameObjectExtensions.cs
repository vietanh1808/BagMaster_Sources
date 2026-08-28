using System.Collections.Generic;
using UnityEngine;

public static class ListGameObjectExtensions
{
	public static GameObject GetOrAdd(this List<GameObject> list, int index)
	{
		return null;
	}

	public static void DeactivateAll(this IList<GameObject> list, int from = 0)
	{
	}

	public static void SetActiveAll(this IList<GameObject> list, bool isActive, int startIndex = 0)
	{
	}

	public static T GetOrAdd<T>(this List<T> list, int index) where T : Component
	{
		return null;
	}

	public static void DeactivateAll<T>(this IList<T> list, int from = 0) where T : Component
	{
	}

	public static void SetActiveAll<T>(this IList<T> list, bool isActive, int startIndex = 0) where T : Component
	{
	}

	public static T GetOrAdd<T>(this GameObject go) where T : Component
	{
		return null;
	}
}
