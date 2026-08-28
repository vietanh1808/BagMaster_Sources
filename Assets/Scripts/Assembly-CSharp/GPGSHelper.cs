using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GooglePlayGames.BasicApi;

public static class GPGSHelper
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public SignInStatus? status;

		internal void _003CAuthenticateInternalAsync_003Eb__0(SignInStatus s)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public string token;

		internal void _003CRequestUserTokenAsync_003Eb__0(string s)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAuthenticateInternalAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<SignInStatus> _003C_003Et__builder;

		public Action<Action<SignInStatus>> authMethod;

		public CancellationToken cancellationToken;

		private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

		private System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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
	private struct _003CInitializeAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken cancellationToken;

		public bool forceAuthenticate;

		private UniTask<SignInStatus>.Awaiter _003C_003Eu__1;

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
	private struct _003CRequestUserTokenAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<string> _003C_003Et__builder;

		public CancellationToken cancellationToken;

		private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

		private System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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

	[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__0))]
	public static UniTask InitializeAsync(bool forceAuthenticate, CancellationToken cancellationToken)
	{
		return default;
	}

	public static UniTask<SignInStatus> RestoreLastSessionAsync(CancellationToken cancellationToken)
	{
		return default;
	}

	public static UniTask<SignInStatus> AuthenticateAsync(CancellationToken cancellationToken)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CAuthenticateInternalAsync_003Ed__3))]
	private static UniTask<SignInStatus> AuthenticateInternalAsync(Action<Action<SignInStatus>> authMethod, CancellationToken cancellationToken)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CRequestUserTokenAsync_003Ed__4))]
	public static UniTask<string> RequestUserTokenAsync(CancellationToken cancellationToken)
	{
		return default;
	}
}
