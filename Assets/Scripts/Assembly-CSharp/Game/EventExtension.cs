using System;
using UnityEngine.Events;

namespace Game
{
	public static class EventExtension
	{
		public static void TryInvoke(this UnityEvent unityEvent)
		{
		}

		public static void TryInvoke<T>(this UnityEvent<T> unityEvent, T arg)
		{
		}

		public static void TryInvoke<T1, T2>(this UnityEvent<T1, T2> unityEvent, T1 arg1, T2 arg2)
		{
		}

		public static void TryInvoke(this Action action)
		{
		}

		public static void TryInvoke<T>(this Action<T> action, T arg)
		{
		}

		public static void TryInvoke<T1, T2>(this Action<T1, T2> action, T1 arg1, T2 arg2)
		{
		}
	}
}
