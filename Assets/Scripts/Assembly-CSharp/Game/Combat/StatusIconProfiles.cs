using System;
using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(fileName = "StatusIconProfiles", menuName = "Game/StatusIconProfiles")]
	public class StatusIconProfiles : ScriptableObject
	{
		[Serializable]
		public class Profile
		{
			[field: SerializeField]
			public StatusType StatusType { get; private set; }

			[field: SerializeField]
			public Sprite Icon { get; private set; }
		}

		[field: SerializeField]
		public Profile[] Profiles { get; private set; }

		public Sprite GetIcon(StatusType statusType)
		{
			return null;
		}
	}
}
