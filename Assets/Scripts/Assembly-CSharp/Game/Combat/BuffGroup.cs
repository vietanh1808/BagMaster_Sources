using System;
using System.Collections;
using System.Collections.Generic;

namespace Game.Combat
{
	public class BuffGroup : IEquatable<BuffGroup>, IReadOnlyCollection<BuffData>, IEnumerable<BuffData>, IEnumerable
	{
		public readonly int Id;

		private readonly BuffData[] _buffs;

		public BuffData this[int index] => null;

		public int Count => 0;

		public BuffGroup(int id, IEnumerable<BuffData> buffs)
		{
		}

		private BuffGroup(int id, BuffData[] buffs)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public bool Equals(BuffGroup other)
		{
			return false;
		}

		public IEnumerator<BuffData> GetEnumerator()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
