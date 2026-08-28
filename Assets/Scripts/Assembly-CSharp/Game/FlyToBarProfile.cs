using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu(fileName = "FlyToBarProfile", menuName = "Game/FlyToBarProfile", order = 0)]
	public class FlyToBarProfile : ScriptableObject
	{
		public int MaxNumber;

		public float InitialDelay;

		public float DelayIncreasement;

		public float ExtraDuration;

		public AudioClip DeliverySound;

		private DefaultSoundConfig.SoundData _deliverySound;

		public float Delivery(IEnumerable<(int Id, int Value, Vector3 Position)> source, bool ignoreTimescale = false)
		{
			return 0f;
		}
	}
}
