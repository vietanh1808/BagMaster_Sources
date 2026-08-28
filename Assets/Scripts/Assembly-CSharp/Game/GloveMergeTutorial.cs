using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Game.Combat;

namespace Game
{
	public class GloveMergeTutorial
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoop_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GloveMergeTutorial _003C_003E4__this;

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
		private struct _003CRunTutorial_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GloveMergeTutorial _003C_003E4__this;

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
		private struct _003CWaitForNextStep_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GloveMergeTutorial _003C_003E4__this;

			private CancellationTokenSource _003CcancelSource_003E5__2;

			private UniTask<bool> _003Ctask_003E5__3;

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

		private const int GloveGearId = 41;

		private readonly FTUECanvasManager _ftueCanvasManager;

		private readonly Gear _bagGlove;

		private readonly Gear _counterGlove;

		private Tween _handTween;

		private CancellationToken CancelToken => default;

		private bool IsCounterGlovePlaceable => false;

		public static UniTask StartTutorial(FTUECanvasManager ftueCanvasManager)
		{
			return default;
		}

		public GloveMergeTutorial(FTUECanvasManager ftueCanvasManager)
		{
		}

		[AsyncStateMachine(typeof(_003CRunTutorial_003Ed__11))]
		public UniTask RunTutorial()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CLoop_003Ed__12))]
		private UniTask Loop()
		{
			return default;
		}

		private void PlayHandAnimForGears()
		{
		}

		[AsyncStateMachine(typeof(_003CWaitForNextStep_003Ed__14))]
		private UniTask WaitForNextStep()
		{
			return default;
		}

		private bool IsCounterGloveIdleOrMerged()
		{
			return false;
		}
	}
}
