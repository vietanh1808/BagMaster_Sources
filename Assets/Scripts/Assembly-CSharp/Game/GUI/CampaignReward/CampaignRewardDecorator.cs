using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Game.GUI.CampaignReward
{
	public class CampaignRewardDecorator : UiBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFadeIn_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CampaignRewardDecorator _003C_003E4__this;

			public bool isRewardClaimable;

			public float duration;

			public CancellationToken token;

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
		[Range(0f, 1f)]
		private float _fadeRatio;

		[SerializeField]
		private Image _summoningCircleImage;

		[SerializeField]
		private Image _inactiveCircleImage;

		[SerializeField]
		private Image _haloImage;

		[SerializeField]
		private CanvasGroup[] _fadeInCanvasGroup;

		[SerializeField]
		private CanvasGroup[] _claimableCanvasGroup;

		public void UpdateDifficultyModeSettings(in CampaignDifficultyModeSetting setting)
		{
		}

		public void UpdateClaimableState(bool isRewardClaimable)
		{
		}

		[AsyncStateMachine(typeof(_003CFadeIn_003Ed__8))]
		public UniTask FadeIn(float duration, bool isRewardClaimable, CancellationToken token = default(CancellationToken))
		{
			return default;
		}

		private void FadeInClaimableUi(Sequence sequence, float fadeDuration)
		{
		}
	}
}
