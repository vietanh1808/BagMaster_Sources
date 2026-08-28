using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Combat
{
	public class EnterBattleView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitForReadyToEnterBattle_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EnterBattleView _003C_003E4__this;

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
			public _003CWaitForReadyToEnterBattle_003Ed__19(int _003C_003E1__state)
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
		private Button _enterBattleButton;

		[SerializeField]
		private Button _recycleNEnterBattleButton;

		[Header("Confirmation Popup")]
		[SerializeField]
		private string _emptyBagConfirmationTitle;

		[SerializeField]
		private string _emptyBagConfirmationDesc;

		[Header("Animation")]
		[SerializeField]
		private Animator _animator;

		[SerializeField]
		private string _swapTrigger;

		[Header("Events")]
		public UnityEvent OnEnterBattleEvent;

		[Header("Misc")]
		[SerializeField]
		private GameObject[] _showIfAnyActiveButtons;

		private bool _readyEnterBattle;

		private bool HasRecycle => false;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnterBattleButtonClicked()
		{
		}

		private void ContinueEnterBattle()
		{
		}

		private void OnRecycleNEnterBattleButtonClicked()
		{
		}

		private void EnterBattle()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForReadyToEnterBattle_003Ed__19))]
		public IEnumerator WaitForReadyToEnterBattle()
		{
			return null;
		}

		public void SetButtonVisible(bool visible)
		{
		}

		public void SetReadyEnterBattle()
		{
		}
	}
}
