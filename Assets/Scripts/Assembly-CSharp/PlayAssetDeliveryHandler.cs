using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

public class PlayAssetDeliveryHandler
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CTryDownloadPacksAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public IProgress<float> progress;

		public string[] packNames;

		public CancellationToken cancellationToken;

		private CancellationTokenRegistration _003C_003E7__wrap1;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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
	private struct _003CWaitForFastFollowPacksAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public IProgress<float> progress;

		public CancellationToken cancellationToken;

		public PlayAssetDeliveryHandler _003C_003E4__this;

		private string[] _003CpackNames_003E5__2;

		private int _003Cattempt_003E5__3;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private int _003CdelayMs_003E5__4;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private struct _003CWaitForNetworkAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken cancellationToken;

		public PlayAssetDeliveryHandler _003C_003E4__this;

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

	private readonly int _maxRetries;

	private readonly int _retryDelayMs;

	private readonly int _networkPollIntervalMs;

	public PlayAssetDeliveryHandler(int maxRetries = 5, int retryDelayMs = 2000, int networkPollIntervalMs = 3000)
	{
	}

	[AsyncStateMachine(typeof(_003CWaitForFastFollowPacksAsync_003Ed__4))]
	public UniTask<bool> WaitForFastFollowPacksAsync(IProgress<float> progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CWaitForNetworkAsync_003Ed__5))]
	private UniTask WaitForNetworkAsync(CancellationToken cancellationToken)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CTryDownloadPacksAsync_003Ed__6))]
	private UniTask<bool> TryDownloadPacksAsync(string[] packNames, IProgress<float> progress, CancellationToken cancellationToken)
	{
		return default;
	}
}
