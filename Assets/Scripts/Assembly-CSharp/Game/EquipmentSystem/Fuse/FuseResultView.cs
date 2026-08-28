using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Fuse
{
	public class FuseResultView : MonoBehaviour
	{
		[Header("Objects")]
		[SerializeField]
		private EquipmentInfo _equipmentView;

		[SerializeField]
		private GameObject _infoBoard;

		[Header("Name")]
		[SerializeField]
		private TextMeshProUGUI _nameText;

		[SerializeField]
		private string _nameTextFormat;

		[Header("Main Stat")]
		[SerializeField]
		private TextMeshProUGUI _mainStatNameText;

		[SerializeField]
		private string _mainStatNameTextFormat;

		[SerializeField]
		private Image _mainStatNameImage;

		[SerializeField]
		private TextMeshProUGUI _mainStatValueFromText;

		[SerializeField]
		private string _mainStatValueFromTextFormat;

		[SerializeField]
		private TextMeshProUGUI _mainStatValueToText;

		[SerializeField]
		private string _mainStatValueToTextFormat;

		[Header("Ascension")]
		[SerializeField]
		private SkillDataEntityUI _newAscensionSkillView;

		private PlayerInfo PInfo => null;

		public EquipmentData Data => null;

		public void UpdateInfo(EquipmentData resultData)
		{
		}

		public void UpdateCompare(EquipmentData baseData, EquipmentData resultData)
		{
		}

		private void UpdateAscension(EquipmentData resultData)
		{
		}

		public void Clear()
		{
		}
	}
}
