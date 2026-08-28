using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Game.Combat
{
	public class PvPGameplayRoundResult : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CShowNormalResult_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public bool playerWin;

			public PvPGameplayRoundResult _003C_003E4__this;

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
		private struct _003CShowTimeoutResult_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public bool playerWin;

			public PvPGameplayRoundResult _003C_003E4__this;

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

		[Header("Normal")]
		[SerializeField]
		private GameObject _playerWin;

		[SerializeField]
		private GameObject _playerLose;

		[SerializeField]
		private float _normalDuration;

		[Header("Time out")]
		[SerializeField]
		private GameObject _timeOutPlayerWin;

		[SerializeField]
		private GameObject _timeOutPlayerLose;

		[SerializeField]
		private float _timeoutDuration;

		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CShowNormalResult_003Ed__7))]
		public UniTask ShowNormalResult(bool playerWin)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CShowTimeoutResult_003Ed__8))]
		public UniTask ShowTimeoutResult(bool playerWin)
		{
			return default;
		}
	}
}
