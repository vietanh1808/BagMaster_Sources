using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	[RequireComponent(typeof(Toggle))]
	[RequireComponent(typeof(LayoutElement))]
	public class NavigationHomeButton : UIButtonMethods
	{
		[CompilerGenerated]
		private sealed class _003CDelayUnparentNotification_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NavigationHomeButton _003C_003E4__this;

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
			public _003CDelayUnparentNotification_003Ed__26(int _003C_003E1__state)
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

		private static float PREFERED_SELECTED_WIDTH;

		private static float PREFERED_UNSELECTED_WIDTH;

		private static float ANIMATION_TIME;

		[SerializeField]
		private GameObject _onUi;

		[SerializeField]
		private Transform _onUiParent;

		[SerializeField]
		private GameObject _notification;

		[SerializeField]
		private Transform _notificationParents;

		[SerializeField]
		private Animator _iconAnimator;

		[Tooltip("Icon Spine nhich len bao nhieu pixel khi tab duoc chon.")]
		[SerializeField]
		private float _iconSelectedOffsetY;

		public string featureName;

		private Vector3 _iconBasePosition;

		private Vector3 _onPosition;

		private LayoutElement layoutElement;

		private float _previousButtonWidth;

		private bool _previousButtonState;

		private Animator _animator;

		private Vector3 _notificationOffset;

		private const string ICON_STATE_ON = "on";

		private const string ICON_STATE_ON_LOOP = "on_loop";

		private const string ICON_STATE_OFF = "off";

		private const string ICON_STATE_OFF_LOOP = "off_loop";

		private const string HIGHLIGHT_BUTTON = "Start";

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayUnparentNotification_003Ed__26))]
		private IEnumerator DelayUnparentNotification()
		{
			return null;
		}

		private void Update()
		{
		}

		private void OnToggled(bool value)
		{
		}

		public void ToggleNoti(bool value)
		{
		}

		private void UpdateOnState(bool on)
		{
		}

		private void SnapIcon(bool on)
		{
		}

		private Vector3 GetIconPosition(bool on)
		{
			return default;
		}

		private void PlayIconTransition(bool on)
		{
		}

		private void TweenFloat(float tweeningNumber, float toNumber)
		{
		}

		private void OnSheetPushed(string path)
		{
		}
	}
}
