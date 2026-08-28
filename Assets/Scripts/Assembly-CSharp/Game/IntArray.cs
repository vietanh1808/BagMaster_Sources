using Newtonsoft.Json;
using UnityEngine;

namespace Game
{
	public struct IntArray
	{
		public int[] Values;

		[JsonIgnore]
		public Vector2Int Vector2Int => default;

		public IntArray(params int[] values)
		{
			Values = null;
		}

		public IntArray(Vector2Int vector2Int)
		{
			Values = null;
		}
	}
}
