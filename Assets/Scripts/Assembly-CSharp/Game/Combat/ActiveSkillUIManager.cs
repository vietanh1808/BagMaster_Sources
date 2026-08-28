using System.Collections.Generic;
using Game.Constant;
using UnityEngine;

namespace Game.Combat
{
	public class ActiveSkillUIManager : MonoBehaviour
	{
		[SerializeField]
		private List<GameObject> _buttons;

		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private float _delayAppear;

		public IEnumerable<GameObject> Buttons => null;

		private void Start()
		{
		}

		public void ShowActiveSkillUI(IEnumerable<Gear> gears)
		{
		}

		public void HideActiveSkillUI()
		{
		}

		private void CreateButtonFromItem(OwnedItemEntity item, SimpleSkill skill, ref int index)
		{
		}

		private void CreateButtonFromGear(Gear gear, ref int index)
		{
		}

		private void CreateButtonFromSkill(SimpleSkill skill, string iconName, Rarity rarity, int index)
		{
		}

		private void CreateButton(SimpleSkill skill, int index, string iconName, Rarity rarity)
		{
		}
	}
}
