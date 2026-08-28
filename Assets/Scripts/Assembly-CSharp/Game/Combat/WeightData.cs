using System;

namespace Game.Combat
{
	[Serializable]
	public class WeightData : IHasWeight<int>
	{
		public int Id;

		public float Weight { get; set; }

		public int Value => 0;
	}
}
