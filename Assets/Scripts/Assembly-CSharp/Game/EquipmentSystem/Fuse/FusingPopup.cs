using System.Collections.Generic;
using Game.EquipmentSystem.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Fuse
{
	public class FusingPopup : MonoBehaviour
	{
		[SerializeField]
		private EquipmentInfo result;

		[SerializeField]
		private List<EquipmentInfo> materials;

		[SerializeField]
		private SkillDataEntityUI newPassive;

		[SerializeField]
		private TextMeshProUGUI _itemNameTxt;

		[SerializeField]
		private TextMeshProUGUI _mainStatsNameTxt;

		[SerializeField]
		private TextMeshProUGUI _itemRarityTxt;

		[SerializeField]
		private TextMeshProUGUI _oldStatsTxt;

		[SerializeField]
		private TextMeshProUGUI _newStatsTxt;

		[SerializeField]
		private Image _itemRarityBG;

		[SerializeField]
		private RaritySpriteData _headerSprites;

		[SerializeField]
		private string statValueStrFormat;

		public FusePanel FusePanel;

		private PlayerInfo PInfo => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateInfo(EquipmentData materialData, EquipmentData resultData)
		{
		}

		private void UpdateStatsText(EquipmentData materialData, EquipmentData resultData)
		{
		}
	}
}
