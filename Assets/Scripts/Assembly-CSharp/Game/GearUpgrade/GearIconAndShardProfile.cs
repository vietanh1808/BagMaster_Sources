using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.GearUpgrade
{
	[CreateAssetMenu(fileName = "GearIconAndShardProfile", menuName = "Game/GearIconAndShardProfile")]
	public class GearIconAndShardProfile : ScriptableObject
	{
		[Serializable]
		public class GearDataProfile
		{
			[field: SerializeField]
			public int GearId { get; private set; }

			[field: SerializeField]
			public List<Sprite> Icon { get; private set; }
		}

		[SerializeField]
		private GearDataProfile[] _profiles;

		public Sprite GetIconProfile(int gearId)
		{
			return null;
		}

		public Sprite GetShardIconProfile(int gearId)
		{
			return null;
		}
	}
}
