using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem
{
	public class EquipmentInfoGeneralUI : MonoBehaviour, IInfoPopup
	{
		[SerializeField]
		private bool _manualAssign;

		[SerializeField]
		[Tooltip("can show info popup?")]
		private bool _canShowInfoPopup;

		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private Image _partBackgroundImage;

		[SerializeField]
		private Image _partIconImage;

		[SerializeField]
		private TextMeshProUGUI _levelText;

		[SerializeField]
		private Image _rarityLevelBackgroundImage;

		[SerializeField]
		private TextMeshProUGUI _rarityLevelText;

		[SerializeField]
		private Image _tierIconImage;

		[Header("UI Data")]
		[SerializeField]
		private EquipmentPartVisualData _partVisualData;

		[SerializeField]
		private EquipmentInfoRarityData _rarityData;

		private PlayerInfo _playerInfo;

		public EquipmentData Data { get; private set; }

		public PlayerInfo PInfo => null;

		public void SetPlayerInfo(PlayerInfo playerInfo)
		{
		}

		public void UpdateInfo(EquipmentData data)
		{
		}

		public void ShowInfoPopup()
		{
		}

		public void DisableShowInfoPopup()
		{
		}

		public void EnableShowInfoPopup()
		{
		}
	}
}
