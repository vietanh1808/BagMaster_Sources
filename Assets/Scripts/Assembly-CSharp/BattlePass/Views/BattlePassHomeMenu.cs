using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BattlePass.Views
{
	public class BattlePassHomeMenu : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitOpenTick_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BattlePassHomeMenu _003C_003E4__this;

			private long _003Csecond_003E5__2;

			private string _003Cformat_003E5__3;

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
			public _003CWaitOpenTick_003Ed__22(int _003C_003E1__state)
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

		[Header("Setting")]
		[SerializeField]
		private GameObject lockObject;

		[SerializeField]
		private GameObject unlockObject;

		[Header("Unlock")]
		[SerializeField]
		private GameObject icon;

		[SerializeField]
		private GameObject stageObject;

		[SerializeField]
		private TextMeshProUGUI textProgress;

		[SerializeField]
		private TextMeshProUGUI textStage;

		[SerializeField]
		private GameObject stageMaxObject;

		[SerializeField]
		private Image imageFill;

		[SerializeField]
		private GameObject notifyObject;

		[Header("Lock")]
		[SerializeField]
		private TextMeshProUGUI textTimeRemain;

		private Coroutine coroutine;

		public static BattlePassHomeMenu Instance { get; private set; }

		public GameObject Icon => null;

		private void Awake()
		{
		}

		private void RefreshEvent(string eventId)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Refresh()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitOpenTick_003Ed__22))]
		private IEnumerator WaitOpenTick()
		{
			return null;
		}

		private void UpdateEventInfo()
		{
		}
	}
}
