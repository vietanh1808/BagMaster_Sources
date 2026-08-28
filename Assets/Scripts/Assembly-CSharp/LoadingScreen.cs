using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DoorServices;
using MoreMountains.Tools;
using TMPro;
using UnityEngine;
using UnityScreenNavigator.Runtime.Core.Sheet;

public class LoadingScreen : MMAdditiveSceneLoadingManager, IProgress<float>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		[StructLayout((LayoutKind)3)]
		private struct _003C_003CLoadAddressable_003Eb__0_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass39_0 _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private UniTask<bool>.Awaiter _003C_003Eu__2;

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

		public AddressableDownloader assetDownloader;

		public IProgress<float> progress;

		[AsyncStateMachine(typeof(_003C_003CLoadAddressable_003Eb__0_003Ed))]
		internal UniTask _003CLoadAddressable_003Eb__0()
		{
			return default;
		}
	}

	[CompilerGenerated]
	private sealed class _003CInitializeIap_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CInitializeIap_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003CLoadAddressable_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IProgress<float> progress;

		private _003C_003Ec__DisplayClass39_0 _003C_003E8__1;

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
		public _003CLoadAddressable_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CLoadHomeUi_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private SheetContainer _003CsheetContainer_003E5__2;

		private List<string>.Enumerator _003C_003E7__wrap2;

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
		public _003CLoadHomeUi_003Ed__45(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoadSave_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<string> onStatus;

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
		public _003CLoadSave_003Ed__42(int _003C_003E1__state)
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
	private sealed class _003CLoadSequence_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadingScreen _003C_003E4__this;

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
		public _003CLoadSequence_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CLoadUnityServices_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<string> onStatus;

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
		public _003CLoadUnityServices_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003CWaitGameplayReady_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CWaitGameplayReady_003Ed__46(int _003C_003E1__state)
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
	private static Action m_onFadeEntered;

	[CompilerGenerated]
	private static Action m_onFadeExited;

	[SerializeField]
	private bool _ftueLoading;

	private static bool _loadUnityServices;

	private static IAPManager _iAPManager;

	private static bool _iApIntialized;

	private static bool _appLoadSent;

	[Header("Sound")]
	[SerializeField]
	private AudioClip _openGameplaySound;

	[SerializeField]
	private AudioClip _openHomeSound;

	[SerializeField]
	private AudioClip _openDungeonSound;

	[SerializeField]
	private AudioClip _defaultOpenSceneSound;

	[SerializeField]
	protected TextMeshProUGUI _statusText;

	[SerializeField]
	protected TextMeshProUGUI _addressableLoadingText;

	public static bool AssetLoaded { get; private set; }

	public static bool AlreadLoadSaveFile { get; private set; }

	public static bool InLoading { get; private set; }

	public static bool Visible { get; private set; }

	public static bool IsGoingHomeScene => false;

	public static event Action onFadeEntered
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

	public static event Action onFadeExited
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

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadSequence_003Ed__37))]
	protected override IEnumerator LoadSequence()
	{
		return null;
	}

	private static void DoSave()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadAddressable_003Ed__39))]
	public static IEnumerator LoadAddressable(IProgress<float> progress = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadUnityServices_003Ed__40))]
	public static IEnumerator LoadUnityServices(Action<string> onStatus = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CInitializeIap_003Ed__41))]
	public static IEnumerator InitializeIap()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadSave_003Ed__42))]
	public static IEnumerator LoadSave(Action<string> onStatus = null)
	{
		return null;
	}

	public static bool CheckAdsRemoval1()
	{
		return false;
	}

	private static void SendAppLoaded()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadHomeUi_003Ed__45))]
	public static IEnumerator LoadHomeUi()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitGameplayReady_003Ed__46))]
	private IEnumerator WaitGameplayReady()
	{
		return null;
	}

	private void PlayEnterSceneSound()
	{
	}

	private void SetStatusText(string text)
	{
	}

	public void Report(float value)
	{
	}
}
public enum LOADINGSCREEN
{
	Text_LoadingService = 0,
	Text_SigningService = 1,
	Text_LoadingSave = 2,
	Text_LoadingService_Error = 3,
	Text_LoadingService_Retry = 4
}
