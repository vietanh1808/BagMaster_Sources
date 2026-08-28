using System.Collections.Generic;
using Game.Constant;
using UnityEngine;

namespace Game.Combat
{
	public class SkillCooldownOfGearManager : MonoBehaviour
	{
		[SerializeField]
		private List<SupportSkillSlot> _items;

		private void Start()
		{
		}

		public void Show(IEnumerable<Gear> gears)
		{
		}

		public void Hide()
		{
		}

		private void CreateButtonFromGear(Gear gear, ref int index)
		{
		}

		private void CreateItem(SimpleSkill skill, int index, string iconName, Rarity rarity)
		{
		}
	}
}
