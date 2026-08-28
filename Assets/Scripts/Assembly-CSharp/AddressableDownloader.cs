using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableDownloader
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CClearOrphanDataAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken cancellationToken;

		private List<string> _003CcatalogsToUpdate_003E5__2;

		private AsyncOperationHandle<bool> _003CcleanHandle_003E5__3;

		private AsyncOperationHandle<List<string>> _003CcheckHandle_003E5__4;

		private UniTask<List<string>>.Awaiter _003C_003Eu__1;

		private AsyncOperationHandle<List<IResourceLocator>> _003CupdateHandle_003E5__5;

		private UniTask<List<IResourceLocator>>.Awaiter _003C_003Eu__2;

		private UniTask<bool>.Awaiter _003C_003Eu__3;

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
	private struct _003CDownloadGroupsAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string[] groupNames;

		public AddressableDownloader _003C_003E4__this;

		public CancellationToken cancellationToken;

		public IProgress<float> progress;

		private IEnumerable<object> _003Ckeys_003E5__2;

		private UniTask<long>.Awaiter _003C_003Eu__1;

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
	private struct _003CExecuteDownloadWithRetryAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken cancellationToken;

		public IEnumerable<object> keys;

		public IProgress<float> progress;

		public AddressableDownloader _003C_003E4__this;

		private int _003Cattempt_003E5__2;

		private AsyncOperationHandle _003CdownloadHandle_003E5__3;

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
	private struct _003CGetDownloadSizeWithRetryAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<long> _003C_003Et__builder;

		public CancellationToken cancellationToken;

		public IEnumerable<object> keys;

		public AddressableDownloader _003C_003E4__this;

		private int _003Cattempt_003E5__2;

		private AsyncOperationHandle<long> _003CsizeHandle_003E5__3;

		private UniTask<long>.Awaiter _003C_003Eu__1;

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

	private readonly int _maxRetries;

	private readonly int _retryDelayMs;

	private readonly PlayAssetDeliveryHandler _padHandler;

	public AddressableDownloader(int maxRetries = 3, int retryDelayMs = 2000)
	{
	}

	[AsyncStateMachine(typeof(_003CDownloadGroupsAsync_003Ed__4))]
	public UniTask DownloadGroupsAsync(string[] groupNames, IProgress<float> progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CGetDownloadSizeWithRetryAsync_003Ed__5))]
	private UniTask<long> GetDownloadSizeWithRetryAsync(IEnumerable<object> keys, CancellationToken cancellationToken)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CExecuteDownloadWithRetryAsync_003Ed__6))]
	private UniTask ExecuteDownloadWithRetryAsync(IEnumerable<object> keys, IProgress<float> progress, CancellationToken cancellationToken)
	{
		return default;
	}

	public UniTask<bool> WaitForFastFollowPacksAsync(IProgress<float> progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CClearOrphanDataAsync_003Ed__8))]
	public UniTask ClearOrphanDataAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return default;
	}
}
