using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.EquipmentSystem.Data;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Inventory
{
	public class InfoPopup : EquipmentInfo
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CScrollToTopAfterLayout_003Ed__61 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public List<UniTask> heightTasks;

			public InfoPopup _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[Header("UI - General")]
		[SerializeField]
		private EquipmentInfoGeneralUI equipmentInfoView;

		[SerializeField]
		private TextMeshProUGUI equipmentNameTxt;

		[SerializeField]
		private TextMeshProUGUI equipmentTypeTxt;

		[SerializeField]
		private Image rarityLevelBg;

		[SerializeField]
		private Image rarityLevelBgSmall;

		[Header("UI - Rarity & Level")]
		[SerializeField]
		private Image rarityBg;

		[SerializeField]
		private TextMeshProUGUI rarityTxt;

		[SerializeField]
		private TextMeshProUGUI levelTxt;

		[SerializeField]
		private string levelTextStrFormat;

		[SerializeField]
		private RaritySpriteData _rarityHeader;

		[SerializeField]
		private RaritySpriteData _raritySubHeader;

		[Header("UI - Main Stat")]
		[SerializeField]
		private GameObject mainStatForUpgrade;

		[SerializeField]
		private Image mainStatIcon;

		[SerializeField]
		private TextMeshProUGUI mainStatNameTxt;

		[SerializeField]
		private TextMeshProUGUI mainStatValueTxt;

		[SerializeField]
		private TextMeshProUGUI mainStatNextValueTxt;

		[SerializeField]
		private string statValueStrFormat;

		[Space(10f)]
		[SerializeField]
		private GameObject mainStatMax;

		[SerializeField]
		private TextMeshProUGUI mainStatMaxValueTxt;

		[Header("UI - Sub Stats")]
		[SerializeField]
		private Transform subStatsContainer;

		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private SkillDataEntityUI subStatUIPrefab;

		[Header("UI - Upgrade Resources")]
		[SerializeField]
		private GameObject upgradeResourcesUI;

		[SerializeField]
		private Image blueprintIcon;

		[SerializeField]
		private TextMeshProUGUI blueprintProgressTxt;

		[SerializeField]
		private Image upgradeResourceIcon;

		[SerializeField]
		private TextMeshProUGUI upgradePriceTxt;

		[SerializeField]
		private MMF_Player upgradeFeedback;

		[Header("UI - Function Buttons")]
		[SerializeField]
		private Sprite[] UpgradeBtnSprites;

		[Obsolete]
		[SerializeField]
		private TextMeshProUGUI equipBtnText;

		[SerializeField]
		private Button equipBtn;

		[SerializeField]
		private Button unequipBtn;

		[SerializeField]
		private Button upgradeBtn;

		[SerializeField]
		private GameObject equipBtnSwapText;

		[SerializeField]
		private GameObject equipBtnEquipText;

		[SerializeField]
		private GameObject equipNotification;

		[Header("Sound")]
		[SerializeField]
		private string _availableUpgradeSound;

		[SerializeField]
		private string _notAvailableUpgradeSound;

		[Header("Details Info")]
		[SerializeField]
		private EquipmentDetailsInfo _detailsInfo;

		private List<SkillDataEntityUI> _subStatEntityUIs;

		private EquipmentLevelData _levelData;

		private EquipmentLevelData _nextLevelData;

		private int _level;

		private int _maxLevel;

		public IEnumerable<SkillDataEntityUI> SubStatEntityUIs => null;

		public Button GetEquipButton()
		{
			return null;
		}

		private void Start()
		{
		}

		protected override void UpdateInfo()
		{
		}

		private void UpdateEquipmentDetails()
		{
		}

		private void UpdateUpgradeBtnState()
		{
		}

		private void CheckShowUpgrade()
		{
		}

		private void CheckSwap()
		{
		}

		private void UpdateRarityLevelImage()
		{
		}

		private void UpdateOwned()
		{
		}

		private void UpdateLevelData()
		{
		}

		private void UpdateLevelText()
		{
		}

		private void UpdateUpgradeResourcesUI()
		{
		}

		private bool IsMaxLevel()
		{
			return false;
		}

		private void LoadMainStat()
		{
		}

		private void LoadSubStats()
		{
		}

		[AsyncStateMachine(typeof(_003CScrollToTopAfterLayout_003Ed__61))]
		private UniTaskVoid ScrollToTopAfterLayout(List<UniTask> heightTasks)
		{
			return default;
		}

		public void ScrollToTop()
		{
		}

		private void Equip()
		{
		}

		private void Unequip()
		{
		}

		private bool CanEquip()
		{
			return false;
		}

		private void Upgrade()
		{
		}

		private void Close()
		{
		}

		private void ToggleUpgrade(bool value)
		{
		}
	}
}
