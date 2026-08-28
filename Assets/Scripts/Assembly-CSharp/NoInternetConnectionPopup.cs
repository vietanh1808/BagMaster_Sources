using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class NoInternetConnectionPopup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWait_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NoInternetConnectionPopup _003C_003E4__this;

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
		public _003CWait_003Ed__8(int _003C_003E1__state)
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

	private static NoInternetConnectionPopup _instance;

	private static bool _forceShow;

	[SerializeField]
	private GameObject _noConnectionPopup;

	[SerializeField]
	private Button _openNetworkSettingButton;

	public static void Show()
	{
	}

	public static void Hide()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CWait_003Ed__8))]
	private IEnumerator Wait()
	{
		return null;
	}

	public void OpenWifiSettings()
	{
	}
}
