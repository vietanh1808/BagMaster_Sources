using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Game.GUI.CampaignReward
{
	public class CampaignRewardBagPanel : UiBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CChangeBag_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CampaignRewardBagPanel _003C_003E4__this;

			public float animationDuration;

			public CampaignDifficultyMode difficultyMode;

			public int currentLevelIndex;

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

		private const int ActiveBagIndex = 1;

		[SerializeField]
		private Color _inactiveBagColor;

		[SerializeField]
		[HideInInspector]
		private List<CampaignRewardBag> _rewardBags;

		private Vector3[] _bagPositions;

		private CampaignRewardBag PreviousRewardBag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private CampaignRewardBag CurrentRewardBag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private CampaignRewardBag NextRewardBag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private CampaignRewardBag FutureRewardBag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void OnValidate()
		{
		}

		public void Init()
		{
		}

		[AsyncStateMachine(typeof(_003CChangeBag_003Ed__18))]
		public UniTask ChangeBag(CampaignDifficultyMode difficultyMode, int currentLevelIndex, float animationDuration)
		{
			return default;
		}

		private void ShiftBags()
		{
		}

		public void UpdateBagContents(CampaignDifficultyMode difficultyMode, int currentLevelIndex)
		{
		}

		private void InitBag(CampaignRewardBag rewardBag, int index, int wave, CampaignDifficultyMode difficultyMode)
		{
		}
	}
}
