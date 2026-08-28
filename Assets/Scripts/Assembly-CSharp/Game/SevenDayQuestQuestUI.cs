using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.CodedAnimation;
using Game.ProgressPointSystem;
using Game.SevenDayQuest;
using I2.Loc;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game
{
	public class SevenDayQuestQuestUI : MonoBehaviour
	{
		private class ItemUiHook
		{
			public SevenDayQuestData Data;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAssignDayMethod_003Ed__61 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SevenDayQuestQuestUI _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitialize_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SevenDayQuestQuestUI _003C_003E4__this;

			public int eventId;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CTryAutoSwitchToRewardDay_003Ed__67 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SevenDayQuestQuestUI _003C_003E4__this;

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

		[Header("General")]
		[SerializeField]
		private Localize _headerText;

		[Header("Quests")]
		public bool QuestOn;

		[SerializeField]
		private ScrollRect _questScrollRect;

		[SerializeField]
		private SevenDayQuestUIItem _questItemPrefab;

		[SerializeField]
		private Transform _questItemContainer;

		[SerializeField]
		private DotweenAnimation2 _questItemAnimation;

		[SerializeField]
		private GameObject _questTabCTA;

		[SerializeField]
		private Toggle _questToggle;

		[Header("Bundles")]
		public bool BundleOn;

		[SerializeField]
		private ScrollRect _bundleScrollRect;

		[SerializeField]
		private SevenDayBundlePanel _bundlePanel;

		[SerializeField]
		private GameObject _bundleTabCTA;

		[SerializeField]
		private Toggle _bundleToggle;

		[Header("Progress")]
		[SerializeField]
		protected ProgressPointUI _questProgressUi;

		[SerializeField]
		protected ProgressPointUI _bundleProgressUi;

		[Header("Days")]
		[SerializeField]
		private ScrollRect _dayScrollRect;

		[SerializeField]
		private SevenDayQuestDay _dayItemPrefab;

		[SerializeField]
		private Transform _dayItemContainer;

		[SerializeField]
		private ToggleGroup _toggleGroup;

		[Header("Time")]
		[SerializeField]
		private GameObject _remainDurationText;

		[SerializeField]
		private GameObject _expiredText;

		[Header("Events")]
		public UnityEvent<SevenDayQuestData> OnAQuestClaimedEvent;

		public UnityEvent OnPriorityOpenQuestTab;

		public UnityEvent OnPriorityOpenBundleTab;

		[Header("Event Config")]
		[SerializeField]
		private int _eventId;

		[SerializeField]
		private bool _autoInitialized;

		private Dictionary<SevenDayQuestUIItem, ItemUiHook> _quests;

		private Dictionary<int, SevenDayQuestDay> _dayUi;

		private bool _questProgressDirty;

		private bool _bundleProgressDirty;

		private bool _dayCTADirty;

		private int _selectedDay;

		private float _latestQuestProgressChanged;

		private float _latestBundleProgressChanged;

		private bool _wasExpired;

		private SevenDayQuestManager _sdqm;

		private PlayerInfo PInfo => null;

		private SevenDayQuestManager SDQM => null;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		[AsyncStateMachine(typeof(_003CInitialize_003Ed__45))]
		public UniTaskVoid Initialize(int eventId)
		{
			return default;
		}

		private void SendTracking()
		{
		}

		private int GetCurrentDay()
		{
			return 0;
		}

		private void UpdateGeneralInfo()
		{
		}

		private void IntializePiorityDay()
		{
		}

		private void RefreshBundle()
		{
		}

		private void CreateDays()
		{
		}

		private void InitializeProgresses()
		{
		}

		public void RefreshQuest()
		{
		}

		private SevenDayQuestUIItem CreateNewUiItem(SevenDayQuestData sevenDayQuestData)
		{
			return null;
		}

		private void OnClaimable(SevenDayQuestUIItem uIItem)
		{
		}

		private void OnClaimed(SevenDayQuestUIItem uiItem)
		{
		}

		private void Clear()
		{
		}

		private void CheckHasBundle()
		{
		}

		private void RefreshDayCompleted()
		{
		}

		private void RefreshDayCTA()
		{
		}

		[AsyncStateMachine(typeof(_003CAssignDayMethod_003Ed__61))]
		private UniTaskVoid AssignDayMethod()
		{
			return default;
		}

		private void UpdateRemainTime()
		{
		}

		private void CheckTabCTA()
		{
		}

		private void OnResourceChanged(OwnedResourceEntity resource, int value)
		{
		}

		public void AnimateListQuests(bool animate)
		{
		}

		public void AnimateListBundles(bool animate)
		{
		}

		[AsyncStateMachine(typeof(_003CTryAutoSwitchToRewardDay_003Ed__67))]
		private UniTaskVoid TryAutoSwitchToRewardDay()
		{
			return default;
		}

		private void SwitchToDay(int day)
		{
		}

		public void SetDirtyDayCTA()
		{
		}

		private bool HasBundleData()
		{
			return false;
		}

		private int GetPriorityDay()
		{
			return 0;
		}

		public void SetQuestOn(bool on)
		{
		}

		public void SetBundleOn(bool on)
		{
		}

		private void SetProgressInteractable(bool interactable)
		{
		}
	}
}
