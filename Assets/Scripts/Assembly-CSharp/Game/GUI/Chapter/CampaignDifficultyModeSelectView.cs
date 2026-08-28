using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using MoreMountains.Tools;
using UnityEngine;

namespace Game.GUI.Chapter
{
	public class CampaignDifficultyModeSelectView : SelectionView<CampaignDifficultyMode, CampaignDifficultyMode>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSelect_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<CampaignDifficultyMode> _003C_003Et__builder;

			public CampaignDifficultyModeSelectView _003C_003E4__this;

			public CampaignDifficultyMode selectedMode;

			public CancellationToken cancellationToken;

			private UniTask<CampaignDifficultyMode>.Awaiter _003C_003Eu__1;

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
		private MMSerializableDictionary<CampaignDifficultyMode, CampaignDifficultyModeOption> _modeMap;

		private readonly UniTaskCompletionSource<CampaignDifficultyMode> _completionSource;

		[AsyncStateMachine(typeof(_003CSelect_003Ed__2))]
		public override UniTask<CampaignDifficultyMode> Select(CampaignDifficultyMode selectedMode, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		private void OnModeSelected(CampaignDifficultyMode campaignMode)
		{
		}

		private static bool ShouldShowNotification(CampaignDifficultyMode campaignMode)
		{
			return false;
		}
	}
}
