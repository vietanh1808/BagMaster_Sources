using System;

namespace Game
{
	public class ResourceRewardData
	{
		public readonly int Id;

		public readonly int Value;

		public bool IsUp;

		public ResourceEntity ResourceEntity => null;

		public ResourceRewardData(int id, int number)
		{
		}

		public ResourceRewardData(int id, int number, bool isUp)
		{
		}

		public ResourceRewardData(ResourceRewardData data)
		{
		}

		[Obsolete]
		public void Reward()
		{
		}

		public void Reward(string source, bool isIap = false, string context = "")
		{
		}

		public bool IsVisualAvailable(out ResourceEntityHasVisual hasVisual)
		{
			hasVisual = null;
			return false;
		}
	}
}
