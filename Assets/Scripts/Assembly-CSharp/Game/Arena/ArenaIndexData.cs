using System;

namespace Game.Arena
{
	[Serializable]
	public struct ArenaIndexData : IEquatable<ArenaIndexData>
	{
		public string userName;

		public int userId;

		public int point;

		public bool Equals(ArenaIndexData other)
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
}
