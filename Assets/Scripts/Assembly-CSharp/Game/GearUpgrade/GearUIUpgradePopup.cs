using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Combat;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Game.GearUpgrade
{
	public class GearUIUpgradePopup : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadGearPreview_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GearUIUpgradePopup _003C_003E4__this;

			public string assetName;

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

		[SerializeField]
		private Button _upgradeButton;

		[SerializeField]
		private Button _quickUpgradeButton;

		[SerializeField]
		private Button _notEnoughUpgradeButton;

		[SerializeField]
		private Button _notEnoughQuickUpgradeButton;

		[SerializeField]
		private Button _upgradeMaxedButton;

		[SerializeField]
		private Button _gotoButton;

		[SerializeField]
		private List<CurrencyPriceView> _upgradePriceViews;

		[SerializeField]
		private string _priceEnoughFormat;

		[SerializeField]
		private string _priceNotEnoughFormat;

		[SerializeField]
		private VideoPlayer _previewVideo;

		[SerializeField]
		private TextMeshProUGUI _previewDescriptionText;

		[SerializeField]
		private Button[] _proceedButtons;

		[SerializeField]
		private Button _shardProceedButton;

		[Header("References")]
		public GearUIMastery UIMastery;

		public GearUICollectionGroup CollectionGroup;

		public GearUIUpgradePopupCTANotification CTA;

		[Header("Events")]
		public UnityEvent OnUpgradedEvent;

		[Header("Runtime")]
		public GearUIItem OpenFrom;

		private GearData _gearData;

		private GearUpgradeData _upgradeData;

		private GearUIItem _uiItem;

		private GearUIPropertiesWithUpgradeCompare _properties;

		private AsyncOperationHandle _loadPreviewHandle;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnResourceChanged(OwnedResourceEntity entity, int arg2)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadGearPreview_003Ed__28))]
		public UniTask LoadGearPreview(string assetName)
		{
			return default;
		}

		private void UpdateButtons()
		{
		}

		private bool IsUpgradeResourceEnough()
		{
			return false;
		}

		private void OnNotEnoughUpgradeButtonClicked()
		{
		}

		private void OnShardProceedButtonClicked()
		{
		}

		private bool CheckShowNavigation(ResourceRequireData resourceRequire, bool ignoreEnough = false)
		{
			return false;
		}

		private void OnUpgradeButtonClicked()
		{
		}

		private void OnQuickUpgradeButtonClicked()
		{
		}

		public void UpdateInfo(GearData gearData)
		{
		}

		public void OnTogglePreviewTab(bool on)
		{
		}
	}
}
