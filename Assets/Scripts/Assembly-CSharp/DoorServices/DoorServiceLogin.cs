using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Nakama;

namespace DoorServices
{
	public class DoorServiceLogin
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateNewSessions_003Ed__44 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public DoorServiceLogin _003C_003E4__this;

			private ISession _003CdeviceSession_003E5__2;

			private TaskAwaiter<ISession> _003C_003Eu__1;

			private UniTask<string>.Awaiter _003C_003Eu__2;

			private TaskAwaiter _003C_003Eu__3;

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
		private struct _003CGetDeviceSession_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ISession> _003C_003Et__builder;

			public DoorServiceLogin _003C_003E4__this;

			private ISession _003Csession_003E5__2;

			private TaskAwaiter<ISession> _003C_003Eu__1;

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
		private struct _003CGetSocialSession_003Ed__39 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ISession> _003C_003Et__builder;

			public DoorServiceLogin _003C_003E4__this;

			private ISession _003Csession_003E5__2;

			private UniTask<string>.Awaiter _003C_003Eu__1;

			private TaskAwaiter<ISession> _003C_003Eu__2;

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
		private struct _003CLinkDeviceSessionToSocial_003Ed__43 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public DoorServiceLogin _003C_003E4__this;

			public ISession deviceSession;

			private UniTask<string>.Awaiter _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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
		private struct _003CLinkSocialSessionToDevice_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public DoorServiceLogin _003C_003E4__this;

			public ISession socialSession;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CLogin_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public DoorServiceLogin _003C_003E4__this;

			public bool forceAuthenticate;

			private UniTask.Awaiter _003C_003Eu__1;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

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
		private struct _003CLoginSayGame_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public DoorServiceLogin _003C_003E4__this;

			private ISession _003CsocialSession_003E5__2;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private UniTask<ISession>.Awaiter _003C_003Eu__2;

			private UniTask.Awaiter _003C_003Eu__3;

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
		private struct _003CResolveConflictSocialAndDeviceSession_003Ed__41 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public ISession socialSession;

			public ISession deviceSession;

			public DoorServiceLogin _003C_003E4__this;

			private TaskAwaiter<ISession> _003C_003Eu__1;

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
		private struct _003CRestoreSessions_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public DoorServiceLogin _003C_003E4__this;

			private TaskAwaiter<ISession> _003C_003Eu__1;

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

		public const string ProductionHost = "cloud.saygames.io";

		public const string DevelopmentHost = "dev.cloud.saygames.io";

		public const string ServerKey = "Yg8WT7O4MLDnrakoKakC9cmkQK1A5uVB";

		private bool _isAuthInProcess;

		private Client _client;

		[CompilerGenerated]
		private Action<string> m_OnPlayerIdUpdated;

		[CompilerGenerated]
		private Action<string> m_OnPlayerUserNameUpdated;

		private string _playerId;

		private string _userName;

		public IClient Client => null;

		public ISession GameSession { get; private set; }

		public string UserId => null;

		public string PlatformUserId => null;

		public string UserName => null;

		private string DeviceId => null;

		public string StoredAuthToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string StoredRefreshToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsAuthenticated => false;

		public event Action<string> OnPlayerIdUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<string> OnPlayerUserNameUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[AsyncStateMachine(typeof(_003CLogin_003Ed__35))]
		public UniTask Login(bool forceAuthenticate = false)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CLoginSayGame_003Ed__36))]
		private UniTask LoginSayGame()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CRestoreSessions_003Ed__37))]
		private UniTask<bool> RestoreSessions()
		{
			return default;
		}

		private void TrackRestoredUserId(string userId)
		{
		}

		[AsyncStateMachine(typeof(_003CGetSocialSession_003Ed__39))]
		private UniTask<ISession> GetSocialSession()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CGetDeviceSession_003Ed__40))]
		private UniTask<ISession> GetDeviceSession()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CResolveConflictSocialAndDeviceSession_003Ed__41))]
		private UniTask ResolveConflictSocialAndDeviceSession(ISession socialSession, ISession deviceSession)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CLinkSocialSessionToDevice_003Ed__42))]
		private UniTask LinkSocialSessionToDevice(ISession socialSession)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CLinkDeviceSessionToSocial_003Ed__43))]
		private UniTask LinkDeviceSessionToSocial(ISession deviceSession)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CCreateNewSessions_003Ed__44))]
		private UniTask CreateNewSessions()
		{
			return default;
		}

		private Client CreateClient()
		{
			return null;
		}

		private void Log(string message)
		{
		}

		private void LogWarning(string message)
		{
		}
	}
}
