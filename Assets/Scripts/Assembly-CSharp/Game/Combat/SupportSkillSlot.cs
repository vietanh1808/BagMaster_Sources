using Game.Constant;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class SupportSkillSlot : MonoBehaviour
	{
		[SerializeField]
		protected Image _frameImg;

		[SerializeField]
		protected Image _iconImg;

		[SerializeField]
		protected Image _cooldownImg;

		[SerializeField]
		protected Sprite[] _frameByRarities;

		protected SimpleSkill _skill;

		public virtual void UpdateInfo(Sprite icon, SimpleSkill skill, Rarity rarity)
		{
		}

		public virtual void UpdateInfo(string iconName, SimpleSkill skill, Rarity rarity)
		{
		}

		public void Empty()
		{
		}

		private void Update()
		{
		}
	}
}
