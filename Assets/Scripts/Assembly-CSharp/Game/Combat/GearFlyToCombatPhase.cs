using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Combat
{
	public class GearFlyToCombatPhase : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CHideAllOrbitters_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearFlyToCombatPhase _003C_003E4__this;

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
			public _003CHideAllOrbitters_003Ed__11(int _003C_003E1__state)
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
		private sealed class _003CRun_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearFlyToCombatPhase _003C_003E4__this;

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
			public _003CRun_003Ed__12(int _003C_003E1__state)
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
		private GearOrganizer _gearOrganizer;

		[SerializeField]
		private Camera _uiCamera;

		[SerializeField]
		private Camera _mainCamera;

		[SerializeField]
		private GameObject _gearFlyPrefab;

		[SerializeField]
		private float _startInterval;

		[SerializeField]
		private float _endInterval;

		[SerializeField]
		private AnimationCurve _intervalTween;

		[SerializeField]
		private MMF_Player _feedback;

		public float TimeScale;

		private PlayerCpUi _playerCpUi;

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CHideAllOrbitters_003Ed__11))]
		public IEnumerator HideAllOrbitters()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRun_003Ed__12))]
		public IEnumerator Run()
		{
			return null;
		}
	}
}
