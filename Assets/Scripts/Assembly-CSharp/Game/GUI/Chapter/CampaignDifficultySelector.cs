using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Combat;
using Game.GUI.CampaignReward;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.GUI.Chapter
{
	public class CampaignDifficultySelector : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnHardModeToggle_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CampaignDifficultySelector _003C_003E4__this;

			private UniTask<(bool IsCanceled, CampaignDifficultyMode Result)>.Awaiter _003C_003Eu__1;

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
		private CampaignDifficultyModeSettings _settings;

		[SerializeField]
		private CampaignDifficultyButton _campaignModeButton;

		[SerializeField]
		private Image _levelTypeIcon;

		[SerializeField]
		private Image _levelTypeShadowIcon;

		[SerializeField]
		private TMP_Text _levelNameText;

		[SerializeField]
		private Button _rewardPageButton;

		[SerializeField]
		private LocalizationParamsManager _lockTextParamManager;

		private readonly Dictionary<CampaignDifficultyMode, int> _campaignModeIndexMap;

		public UnityEvent<Campaign> SelectedChapterChanged;

		public UnityEvent<CampaignDifficultyMode> SelectedModeChanged;

		public CampaignDifficultyMode SelectedMode { get; private set; }

		public int ProgressIndex => 0;

		public int MaxProgressIndex => 0;

		public Campaign SelectedCampaign => null;

		public bool IsSelectedCampaignLocked => false;

		public int SelectedCampaignIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private Campaign PrecursorCampaign => null;

		private void Start()
		{
		}

		private void OnRewardPageButtonClicked()
		{
		}

		private void OnRewardPageLoaded(CampaignRewardPage campaignRewardPage)
		{
		}

		[AsyncStateMachine(typeof(_003COnHardModeToggle_003Ed__30))]
		private UniTask OnHardModeToggle()
		{
			return default;
		}

		public void Refresh(bool showLockedCampaigns = true)
		{
		}

		private void SetCampaignMode(CampaignDifficultyMode selectedMode, bool invokeEvent = true)
		{
		}

		private void SetSelectedCampaignIndex(int value, bool invokeEvent = true)
		{
		}

		private void PropagateChanges()
		{
		}

		private void UpdateUi(in CampaignDifficultyModeSetting setting)
		{
		}
	}
}
