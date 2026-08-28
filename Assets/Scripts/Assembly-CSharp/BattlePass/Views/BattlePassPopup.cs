using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Game;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BattlePass.Views
{
	public class BattlePassPopup : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCheckEndSeasonTime_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BattlePassPopup _003C_003E4__this;

			private long _003Cduration_003E5__2;

			private WaitForSeconds _003Cwfs_003E5__3;

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
			public _003CCheckEndSeasonTime_003Ed__39(int _003C_003E1__state)
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
		private struct _003CStart_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public BattlePassPopup _003C_003E4__this;

			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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

		[Header("Settings")]
		[SerializeField]
		private RectTransform bannerRect;

		[SerializeField]
		private float bannerHeightOffset;

		[SerializeField]
		private float bannerMoveDuration;

		[SerializeField]
		private float levelDataHeightOffset;

		[SerializeField]
		private float levelDataMoveDuration;

		[Header("Element")]
		[SerializeField]
		private Transform panel;

		[SerializeField]
		private Button buttonBack;

		[SerializeField]
		private BattlePassUnlockPanel unlockPanel;

		[SerializeField]
		private BattlePassBottomMenuView bottomMenuView;

		[SerializeField]
		private BattlePassCurrencyView currencyView;

		[SerializeField]
		private PlayerCurrencyView coinView;

		[SerializeField]
		private CanvasGroup[] existedCanvasGroup;

		[Header("Season time")]
		[SerializeField]
		private TextMeshProUGUI textDescription;

		[SerializeField]
		private TextMeshProUGUI textSeasonRemainTime;

		[SerializeField]
		private LocalizationParamsManager textEndSeasonTimeParam;

		[Header("Tabs")]
		[SerializeField]
		private BattlePassQuestView passQuestView;

		[SerializeField]
		private GameObject activeButtonLevelObject;

		[SerializeField]
		private GameObject activeButtonQuestObject;

		private Action onUpdateNotify;

		private BattlePassLevelView passLevelView;

		private Coroutine autoCheckEndSeasonEnumertor;

		private Vector3 originBannerAnchor;

		private Vector3 originLevelDataAnchor;

		private Sequence sequenceLevelTab;

		public static BattlePassPopup Instance { get; private set; }

		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CStart_003Ed__29))]
		private void Start()
		{
		}

		private void DisplayCanvasGroupObjects()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void Back()
		{
		}

		private void ResourceChanged(OwnedResourceEntity source, int value)
		{
		}

		public void SelectLevelObject()
		{
		}

		public void SelectQuestObject()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckEndSeasonTime_003Ed__39))]
		private IEnumerator CheckEndSeasonTime()
		{
			return null;
		}
	}
}
