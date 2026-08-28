using UnityEngine;

namespace Game.GearUpgrade
{
	[CreateAssetMenu(fileName = "GearUITierUiProfile", menuName = "Game/GearUITierUiProfile", order = 0)]
	public class GearUITierUiProfile : ScriptableObject
	{
		[SerializeField]
		private Sprite[] _tierSprites;

		public Sprite GetTierSprite(int tier)
		{
			return null;
		}
	}
}
