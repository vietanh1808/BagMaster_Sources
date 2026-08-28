using Game.Constant;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class IntroSkillSlot : MonoBehaviour
	{
		public enum IntroSkillSlotState
		{
			Disable = 0,
			Locked = 1,
			Unlocked = 2
		}

		[SerializeField]
		private Image _backgroundIcon;

		[SerializeField]
		private Image _skillIcon;

		[SerializeField]
		private Image _borderIcon;

		[SerializeField]
		private Image _backgroundMask;

		[SerializeField]
		private BuffUIProfile _buffUIProfile;

		[SerializeField]
		private GameObject _lockUI;

		[SerializeField]
		private GameObject _unlockUI;

		[SerializeField]
		private GameObject _disabledUI;

		public IntroSkillSlotState SkillSlotState;

		public void UpdateInfo(Sprite skillIcon, Rarity rarity)
		{
		}

		public void UpdateInfo(string iconName, Rarity rarity)
		{
		}
	}
}
