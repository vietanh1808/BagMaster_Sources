using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Heroes
{
	public class Item : EquipmentInfo
	{
		[SerializeField]
		private Image background;

		[SerializeField]
		private Image icon;

		[SerializeField]
		private TextMeshProUGUI nameTxt;

		[SerializeField]
		private Image progress;

		[SerializeField]
		private TextMeshProUGUI progressTxt;

		[SerializeField]
		private string progressStrFormat;

		[SerializeField]
		private GameObject checkmark;

		[SerializeField]
		private Color normalColor;

		[SerializeField]
		private Color disableColor;

		[SerializeField]
		private HeroesPanel heroesPanel;

		private ResourceRequireData _fragmentRequires;

		private Toggle _toggle;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnReceivedItem(OwnedItemEntity item)
		{
		}

		private void OnRemoveItem(OwnedItemEntity item)
		{
		}

		private void OnEquipped(OwnedItemEntity owned)
		{
		}

		private void OnUnequipped(OwnedItemEntity owned)
		{
		}

		private void OnToggle(bool value)
		{
		}

		private void RefreshProgress()
		{
		}

		protected override void UpdateInfo()
		{
		}
	}
}
