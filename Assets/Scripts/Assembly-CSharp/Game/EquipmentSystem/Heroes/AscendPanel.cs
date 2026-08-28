using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Heroes
{
	public class AscendPanel : EquipmentInfo
	{
		[SerializeField]
		private SkillDataEntityUI passiveInfoUI;

		[SerializeField]
		private Image fragmentIcon;

		[SerializeField]
		private Image fragmentProgress;

		[SerializeField]
		private TextMeshProUGUI fragmentProgressTxt;

		[SerializeField]
		private string progressStrFormat;

		[SerializeField]
		private Button ascendBtn;

		[SerializeField]
		private TextMeshProUGUI ascendPriceTxt;

		[SerializeField]
		private string ascendPriceStrFormat;

		[SerializeField]
		private Image ascendPriceIcon;

		[SerializeField]
		private EquipmentInfo heroDetailsTab;

		private AscendData _ascendData;

		private EquipmentData _ascendResult;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		protected override void UpdateInfo()
		{
		}

		private void Ascend()
		{
		}
	}
}
