using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

namespace Game.Combat
{
	public class BossRedIntroduction : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			public BossRedIntroduction _003C_003E4__this;

			public float endLoopTime;

			internal bool _003CPlayAggressive_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BossRedIntroduction _003C_003E4__this;

			private bool _003CisTutorial_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CPlay_003Ed__18(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPlayAggressive_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public BossRedIntroduction _003C_003E4__this;

			private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

			private float _003CstartLoopTime_003E5__2;

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
		private struct _003CPlaySummonWeapon_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public BossRedIntroduction _003C_003E4__this;

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
		private GameObject _bossRedPrefab;

		[SerializeField]
		private Vector3 _bossRedPosition;

		[SerializeField]
		private PlayableAsset _appearTimeline;

		[SerializeField]
		private PlayableAsset _idleTimeline;

		[SerializeField]
		private PlayableAsset _summonWeaponTimeline;

		[SerializeField]
		private PlayableAsset _idleWeaponTimeline;

		[SerializeField]
		private PlayableAsset _aggressiveTimeline;

		[SerializeField]
		private PlayableAsset _aggressiveChanelingTimeline;

		[SerializeField]
		private PlayableAsset _aggressiveIdleTimeline;

		[SerializeField]
		private PlayableAsset _attackTimeline;

		[SerializeField]
		private float _startDelay;

		[SerializeField]
		private float _finalDelay;

		[SerializeField]
		private CanvasGroup[] _backgroundUis;

		private PlayableDirector _playableDirector;

		private bool _dialogueEnded;

		private bool _backToIdleAfterAggress;

		private CancellationTokenSource _cancellationToken;

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CPlay_003Ed__18))]
		public IEnumerator Play()
		{
			return null;
		}

		public void PlayAppear()
		{
		}

		public void PlayIdle()
		{
		}

		[AsyncStateMachine(typeof(_003CPlaySummonWeapon_003Ed__21))]
		public UniTaskVoid PlaySummonWeapon()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CPlayAggressive_003Ed__22))]
		public UniTaskVoid PlayAggressive()
		{
			return default;
		}

		public void PlayAttack()
		{
		}

		public void PlayBackToIdle()
		{
		}

		public void ShowBubble(bool active)
		{
		}

		private void StartDialogue()
		{
		}

		private void OnEndDialogue()
		{
		}

		private void CancelCancellationTokenSource()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
