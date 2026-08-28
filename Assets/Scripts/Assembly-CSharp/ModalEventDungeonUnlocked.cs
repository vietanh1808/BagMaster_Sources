using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.EventDungeon;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityScreenNavigator.Runtime.Core.Modal;

public class ModalEventDungeonUnlocked : Modal
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CClose_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public ModalEventDungeonUnlocked _003C_003E4__this;

		private EventDungeonHandler _003CeventDungeonHandler_003E5__2;

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
	private struct _003CRenderView_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public ModalEventDungeonUnlocked _003C_003E4__this;

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
	private struct _003CSetRenderData_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EventDungeonUnlockViewState data;

		private TaskAwaiter<Sprite> _003C_003Eu__1;

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

	private static EventDungeonUnlockViewState renderData;

	[CompilerGenerated]
	private static Action<ModalEventDungeonUnlocked> m_onCloseCallback;

	private static Sprite edBanner;

	[SerializeField]
	private List<string> _featureDefaultSounds;

	[SerializeField]
	private PlayDefaultSound playDefaultSound;

	[Space]
	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private Image imageBackground;

	[SerializeField]
	private CanvasGroup contentGroup;

	[SerializeField]
	private MMF_Player unlockFeedback;

	[SerializeField]
	private Image banner;

	[SerializeField]
	private TMP_Text textDungeonName;

	[SerializeField]
	private Button buttonTapToClose;

	[SerializeField]
	private float animationJumpPower;

	[Space]
	[SerializeField]
	private float unlockSpeed;

	[SerializeField]
	private float closeTime;

	[SerializeField]
	private float delayLock;

	[SerializeField]
	private Image lockIcon;

	[SerializeField]
	private Sprite[] lockSprites;

	[SerializeField]
	private ParticleSystem burstVfx;

	private bool ableToClose;

	public static ModalEventDungeonUnlocked OpeningModal { get; private set; }

	public static event Action<ModalEventDungeonUnlocked> onCloseCallback
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

	[AsyncStateMachine(typeof(_003CSetRenderData_003Ed__26))]
	public static Task SetRenderData(EventDungeonUnlockViewState data)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(_003CRenderView_003Ed__30))]
	public UniTask RenderView()
	{
		return default;
	}

	private void PlayOpenSound()
	{
	}

	private void OnCloseButtonClicked()
	{
	}

	[AsyncStateMachine(typeof(_003CClose_003Ed__33))]
	private UniTaskVoid Close()
	{
		return default;
	}

	private void PlayCloseSound()
	{
	}
}
