using System.Collections.Generic;
using MoreMountains.Tools;
using TMPro;
using UnityEngine;

namespace Game.Combat
{
	public class PvPGameplayPlayerUI : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _playerNameText;

		[SerializeField]
		private MMProgressBar _playerHealthBar;

		[SerializeField]
		private List<PvPGameplayActiveSkillUIItem> _activeSkillItems;

		[SerializeField]
		private List<PvPGameplayBuffSkillUIItem> _buffSkillItems;

		[SerializeField]
		private List<PvPGameplayUltimateSkillUIItem> _ultimateSkillItems;

		private int _activeSkillIndex;

		private int _buffItemIndex;

		private int _ultimateSkillIndex;

		private int _transformSiblingIndex;

		public void UpdateInfoNameOnly(string playerName)
		{
		}

		public void UpdateInfo(PlayerProfile playerProfile)
		{
		}

		private void CreateBuffSkillItem(BuffData buffData, SimpleSkill skill)
		{
		}

		private void CreateActiveSkillItem(OwnedItemEntity itemEntity, SimpleSkill skill)
		{
		}

		private void CreateUltimateSkillItem(Gear gear, SimpleSkill skill)
		{
		}

		private void ReorderSkillItems()
		{
		}
	}
}
