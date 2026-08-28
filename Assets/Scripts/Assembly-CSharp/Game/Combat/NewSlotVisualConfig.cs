using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(menuName = "Game/NewSlotVisualConfig")]
	public class NewSlotVisualConfig : ScriptableObject
	{
		public Sprite[] NoUnlockedSlotNearby;

		public Sprite[] NoEnoughMoney;

		public Sprite[] EnoughMoney;

		public Sprite[] UnlockByAds;
	}
}
