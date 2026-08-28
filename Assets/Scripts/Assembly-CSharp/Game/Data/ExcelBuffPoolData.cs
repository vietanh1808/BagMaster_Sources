using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelBuffPoolData : IEquatable<ExcelBuffPoolData>
	{
		public int PoolID;

		public int BuffGroupID;

		public float Weight;

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(ExcelBuffPoolData other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
