using System;
using UnityEngine;

namespace Game.GearUpgrade
{
	[CreateAssetMenu(fileName = "GearTagIconProfile", menuName = "Game/GearTagIconProfile")]
	public class GearTagIconProfile : ScriptableObject
	{
		[Serializable]
		public class Profile
		{
			[field: SerializeField]
			public string Tag { get; private set; }

			[field: SerializeField]
			public Sprite Icon { get; private set; }
		}

		[SerializeField]
		private Profile[] _profiles;

		public Sprite GetIcon(string tag)
		{
			return null;
		}
	}
}
