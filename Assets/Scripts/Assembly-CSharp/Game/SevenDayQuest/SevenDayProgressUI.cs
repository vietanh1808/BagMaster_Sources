using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.ProgressPointSystem;
using UnityEngine;

namespace Game.SevenDayQuest
{
	public class SevenDayProgressUI : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateLastRewardPosition_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public SevenDayProgressUI _003C_003E4__this;

			public SevenDaysProgressItem item;

			public RectTransform rewardPanel;

			public List<ResourceView> resourceViews;

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
		private ProgressPointUI _progressPointUi;

		[SerializeField]
		private RewardBubbleView _rewardBubbleView;

		[SerializeField]
		private SevenDayProgressRewardBubble _rewardBubbleViewPrefab;

		[SerializeField]
		private RectTransform _rewardBubbleContainer;

		[SerializeField]
		private ResourceReturnUI _resourceReturnUI;

		private List<SevenDayProgressRewardBubble> _currentRewardBubbles;

		private List<SevenDayProgressRewardBubble> _bubblePool;

		public void Refresh()
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateLastRewardPosition_003Ed__8))]
		private UniTask UpdateLastRewardPosition(SevenDaysProgressItem item, RectTransform rewardPanel, List<ResourceView> resourceViews)
		{
			return default;
		}

		private void UpdateLastReward(SevenDaysProgressItem item, List<ResourceView> resourceViews)
		{
		}

		private SevenDayProgressRewardBubble GetOrCreateBubble()
		{
			return null;
		}

		private void ReturnBubblesToPool()
		{
		}

		public void SetProgressTokenId(int tokenId)
		{
		}
	}
}
