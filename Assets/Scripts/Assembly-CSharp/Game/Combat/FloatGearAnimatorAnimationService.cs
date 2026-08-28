using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Game.Combat
{
	public class FloatGearAnimatorAnimationService : IFloatGearAnimationStopable, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWaitToStop_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public FloatGearAnimatorAnimationService _003C_003E4__this;

			public string triggerName;

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

		[CompilerGenerated]
		private Action m_OnStopped;

		public readonly Animator Animator;

		private CancellationTokenSource _cancelToken;

		public event Action OnStopped
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

		public FloatGearAnimatorAnimationService(Animator animator)
		{
		}

		public bool IsPlaying()
		{
			return false;
		}

		public void Stop()
		{
		}

		public void Play(string triggerName)
		{
		}

		[AsyncStateMachine(typeof(_003CWaitToStop_003Ed__9))]
		private UniTaskVoid WaitToStop(string triggerName, CancellationToken cancellationToken)
		{
			return default;
		}

		public void Dispose()
		{
		}
	}
}
