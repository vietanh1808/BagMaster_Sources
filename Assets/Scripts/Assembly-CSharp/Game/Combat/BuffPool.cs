using System;
using System.Collections;
using System.Collections.Generic;

namespace Game.Combat
{
	public class BuffPool : IReadOnlyCollection<BuffPool.WeightedBuffGroup>, IEnumerable<BuffPool.WeightedBuffGroup>, IEnumerable
	{
		public struct WeightedBuffGroup : IEquatable<WeightedBuffGroup>
		{
			public BuffGroup BuffGroup;

			public float Weight;

			public readonly int Id => 0;

			public BuffData this[int index] => null;

			public readonly int Count => 0;

			public static implicit operator BuffGroup(in WeightedBuffGroup buffGroup)
			{
				return null;
			}

			public bool Equals(WeightedBuffGroup other)
			{
				return false;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		public static readonly BuffPool Empty;

		private readonly Dictionary<int, WeightedBuffGroup> _weightedBuffs;

		public readonly int Id;

		public readonly float TotalWeight;

		public int Count => 0;

		public static BuffPool Combine(int combinedId, params BuffPool[] buffPools)
		{
			return null;
		}

		public BuffPool(int id, IEnumerable<WeightedBuffGroup> buffGroups)
		{
		}

		public bool TryGetWeightedBuffGroup(BuffGroup buffGroup, out WeightedBuffGroup group)
		{
			group = default;
			return false;
		}

		public bool TryGetWeightedBuffGroup(int groupId, out WeightedBuffGroup group)
		{
			group = default;
			return false;
		}

		public float GetBuffRate(BuffData buff)
		{
			return 0f;
		}

		public float GetBuffGroupRate(in BuffGroup group)
		{
			return 0f;
		}

		public float GetBuffGroupRate(int groupId)
		{
			return 0f;
		}

		private float GeWeight(int groupId)
		{
			return 0f;
		}

		public IEnumerator<WeightedBuffGroup> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
