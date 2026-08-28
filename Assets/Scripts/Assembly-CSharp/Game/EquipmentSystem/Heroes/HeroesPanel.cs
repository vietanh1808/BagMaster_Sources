using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Heroes
{
	public class HeroesPanel : MonoBehaviour
	{
		[Header("Group")]
		[SerializeField]
		private Transform itemContainer;

		[SerializeField]
		private EquipmentInfo itemPrefab;

		[Header("UI")]
		[SerializeField]
		private TextMeshProUGUI CharacterNameTxt;

		[SerializeField]
		private Image CharacterIconImg;

		[SerializeField]
		private Button DetailsBtn;

		[SerializeField]
		private GameObject DetailTab;

		[SerializeField]
		private Button UnlockBtn;

		[SerializeField]
		private TextMeshProUGUI UnlockPriceTxt;

		[SerializeField]
		private string UnlockPriceStrFormat;

		[SerializeField]
		private Image UnlockPriceIconImg;

		private EquipmentInfo _equiping;

		private EquipmentInfo _selecting;

		private EquipmentPriceData _priceData;

		private Pool<EquipmentInfo> _pool;

		private List<EquipmentData> _characterDatas;

		public static EquipmentInfo Seleting;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRemoveItem(OwnedItemEntity item)
		{
		}

		private void Reload()
		{
		}

		private void CreateItem(EquipmentData data, Dictionary<int, EquipmentInfo> group)
		{
		}

		public void UpdateSelectingInfo(EquipmentInfo info)
		{
		}

		public void TryEquip(EquipmentInfo equipmentInfo)
		{
		}

		private void UnlockCharacter()
		{
		}

		private void OpenDetails()
		{
		}
	}
}
