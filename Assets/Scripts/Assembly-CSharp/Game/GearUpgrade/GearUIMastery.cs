using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using EnhancedUI.EnhancedScroller;
using Game.Combat;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.GearUpgrade
{
	public class GearUIMastery : MonoBehaviour, IEnhancedScrollerDelegate
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GearUIMastery _003C_003E4__this;

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
		private Button _claimButton;

		[SerializeField]
		private Button _nonClaimableButton;

		[SerializeField]
		private Button _scrollToReachedButton;

		[Header("Checkpoints")]
		[SerializeField]
		private EnhancedScroller _checkPointsView;

		[SerializeField]
		private GearUIMasteryCheckPoint _checkPointPrefab;

		[Header("ProgressBar")]
		[SerializeField]
		private RectTransform _progressBar;

		[SerializeField]
		private RectTransform _progressBarContent;

		[SerializeField]
		private TextMeshProUGUI _progressBarText;

		[Header("Events")]
		public UnityEvent OnMasteryClaimedEvent;

		[Header("Runtime")]
		[SerializeField]
		private int _levelClaimed;

		[SerializeField]
		private float _currentMastery;

		private GearData _gearData;

		private GearMasteryData _masteryData;

		private bool _firstInited;

		private PlayerInfo PInfo => null;

		[AsyncStateMachine(typeof(_003CStart_003Ed__16))]
		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnScrollerScrolled(EnhancedScroller scroller, Vector2 val, float scrollPosition)
		{
		}

		private void Claim()
		{
		}

		private void ClaimResourceRewards(List<GearMasteryData.LevelData> claimDatas)
		{
		}

		private void UnlockBuffs(List<GearMasteryData.LevelData> claimDatas)
		{
		}

		public void UpdateInfo(GearData gearData)
		{
		}

		private void Refresh()
		{
		}

		private void ScrollToHighestReached()
		{
		}

		public int GetNumberOfCells(EnhancedScroller scroller)
		{
			return 0;
		}

		public float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
		{
			return 0f;
		}

		public EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
		{
			return null;
		}

		private void PopulateCheckPoint(GearUIMasteryCheckPoint cellView, int dataIndex)
		{
		}

		private void RefreshProgressBar()
		{
		}

		private void RefreshButton()
		{
		}

		private int GetCurrentMastery()
		{
			return 0;
		}
	}
}
