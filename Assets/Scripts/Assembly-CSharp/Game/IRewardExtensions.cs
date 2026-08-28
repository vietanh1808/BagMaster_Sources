using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace Game
{
	public static class IRewardExtensions
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			public List<ResourceRewardData> data;

			public bool completed;

			internal void _003CRewardAsyn_003Eb__0(List<ResourceRewardData> receive)
			{
			}

			internal bool _003CRewardAsyn_003Eb__1()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRewardAsyn_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<List<ResourceRewardData>> _003C_003Et__builder;

			public IReward reward;

			public int count;

			public string placement;

			public bool claim;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass0_0 _003C_003E8__1;

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

		[AsyncStateMachine(typeof(_003CRewardAsyn_003Ed__0))]
		public static UniTask<List<ResourceRewardData>> RewardAsyn(this IReward reward, int count, string placement, bool claim, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}
	}
}
