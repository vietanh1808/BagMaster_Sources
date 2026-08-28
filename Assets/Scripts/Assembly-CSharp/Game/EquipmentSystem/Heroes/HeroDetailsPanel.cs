using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Heroes
{
	public class HeroDetailsPanel : EquipmentInfo
	{
		[SerializeField]
		private Image icon;

		[SerializeField]
		private TextMeshProUGUI nameTxt;

		[SerializeField]
		private TextMeshProUGUI levelTxt;

		[SerializeField]
		private string levelStrFormat;

		[SerializeField]
		private StatModifierGroupUI statModifierGroupUI;

		private void OnEnable()
		{
		}

		protected override void UpdateInfo()
		{
		}
	}
}
