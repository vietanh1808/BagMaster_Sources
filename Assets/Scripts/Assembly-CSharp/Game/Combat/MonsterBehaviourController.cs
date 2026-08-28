using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Game.Combat
{
	public class MonsterBehaviourController : MonoBehaviour
	{
		private class RuntimeBehaviourData
		{
			public float FinishCooldownTime;

			public MonsterBehaviourCondition Condition;

			public MonsterBehaviourAction Action;
		}

		[CompilerGenerated]
		private sealed class _003CPlayAction_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MonsterBehaviourController _003C_003E4__this;

			public MonsterBehaviourData behaviour;

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
			public _003CPlayAction_003Ed__15(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CWaitRecoveryTime_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MonsterBehaviourData behaviour;

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
			public _003CWaitRecoveryTime_003Ed__19(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CWaitSwingTime_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MonsterBehaviourData behaviour;

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
			public _003CWaitSwingTime_003Ed__17(int _003C_003E1__state)
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

		[SerializeField]
		private int _phase;

		[SerializeField]
		private CharacterModel _model;

		private Dictionary<MonsterBehaviourData, RuntimeBehaviourData> _behaviours;

		private bool _inAnAction;

		public CharacterModel Model
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Update()
		{
		}

		public void SetBehaviour(int id)
		{
		}

		public void ChangePhase(int phase)
		{
		}

		private bool InPhase(MonsterBehaviourData behaviour)
		{
			return false;
		}

		private bool InAnyAction()
		{
			return false;
		}

		private bool IsCooldownFinished(MonsterBehaviourData behaviour)
		{
			return false;
		}

		private bool IsConditionOk(MonsterBehaviourData behaviour)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CPlayAction_003Ed__15))]
		private IEnumerator PlayAction(MonsterBehaviourData behaviour)
		{
			return null;
		}

		private void PlayActiveAnimation(MonsterBehaviourData behaviour)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitSwingTime_003Ed__17))]
		private IEnumerator WaitSwingTime(MonsterBehaviourData behaviour)
		{
			return null;
		}

		private void ExecuteAction(MonsterBehaviourData behaviour)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitRecoveryTime_003Ed__19))]
		private IEnumerator WaitRecoveryTime(MonsterBehaviourData behaviour)
		{
			return null;
		}

		private void SetCooldown(MonsterBehaviourData behaviour)
		{
		}
	}
}
