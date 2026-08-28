using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Arena
{
	public class Modal_ArenaInfo : MonoBehaviour
	{
		[SerializeField]
		private Button buttonClose;

		[SerializeField]
		private Button areaClose;

		[SerializeField]
		private ArenaButtonMenu[] tabsButton;

		[SerializeField]
		private TextMeshProUGUI textUserName;

		[SerializeField]
		private TextMeshProUGUI textUserId;

		[SerializeField]
		private Button buttonCopy;

		[SerializeField]
		private TextMeshProUGUI textAttackPower;

		[SerializeField]
		private TextMeshProUGUI textChapterReached;

		[Header("Tab references")]
		[SerializeField]
		private ArenaInfoPlayerEquipmentView equipmentView;

		[SerializeField]
		private ArenaInfoPlayerGearView gearView;

		private ArenaSubTabType currentTab;

		private PlayerInfo playerInfo;

		private int userId;

		private void Awake()
		{
		}

		public void Show(int userId, PlayerInfo playerInfo)
		{
		}

		private void LoadTab(ArenaSubTabType subTabType)
		{
		}

		private void Refresh()
		{
		}

		private void Copy()
		{
		}

		private void Back()
		{
		}
	}
}
