using System;

namespace Game.EventDungeon
{
	public readonly struct CategoryData : IEquatable<CategoryData>
	{
		public readonly string Category;

		public readonly string Name;

		public CategoryData(string category, string name)
		{
			Category = null;
			Name = null;
		}

		public bool Equals(CategoryData other)
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
