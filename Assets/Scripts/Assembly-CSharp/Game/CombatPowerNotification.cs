using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Game
{
	public class CombatPowerNotification : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			public float oldCP;

			public CombatPowerNotification _003C_003E4__this;

			public float displayDiff;

			internal float _003CLateShowNotiCor2_003Eb__0()
			{
				return 0f;
			}

			internal void _003CLateShowNotiCor2_003Eb__1(float x)
			{
			}

			internal float _003CLateShowNotiCor2_003Eb__2()
			{
				return 0f;
			}

			internal void _003CLateShowNotiCor2_003Eb__3(float x)
			{
			}

			internal void _003CLateShowNotiCor2_003Eb__4()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInit_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CombatPowerNotification _003C_003E4__this;

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
		private sealed class _003CLateShowNotiCor2_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CombatPowerNotification _003C_003E4__this;

			public float newValue;

			private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

			public float offset;

			private float _003CcurrentCP_003E5__2;

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
			public _003CLateShowNotiCor2_003Ed__24(int _003C_003E1__state)
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

		private Animator _animator;

		private float _combatPower;

		private CombatPowerGetter _combatPowerGetter;

		[SerializeField]
		private TextMeshProUGUI _oldCombatPowerText;

		[Header("Animation 2")]
		[SerializeField]
		private GameObject _panel;

		[SerializeField]
		private TextMeshProUGUI _differentCombatPowerText;

		[SerializeField]
		private RectTransform _arrowImg;

		[SerializeField]
		private Sprite _arrowUp;

		[SerializeField]
		private Sprite _arrowDown;

		[SerializeField]
		private UISound _cpUpSound;

		[SerializeField]
		private UISound _cpDownSound;

		private Tween _combatPowerTween;

		private Tween _diffTextTween;

		private Coroutine LateShowNoti;

		public static CombatPowerNotification Instance => null;

		private static CombatPowerNotification _instance { get; set; }

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CInit_003Ed__23))]
		private UniTask Init()
		{
			return default;
		}

		[IteratorStateMachine(typeof(_003CLateShowNotiCor2_003Ed__24))]
		private IEnumerator LateShowNotiCor2(float offset, float newValue)
		{
			return null;
		}

		public void ShowNotification(float offset, float newValue)
		{
		}
	}
}
