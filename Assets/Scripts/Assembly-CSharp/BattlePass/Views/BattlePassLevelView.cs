using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Game;
using Game.Shop;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace BattlePass.Views
{
	public class BattlePassLevelView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCallback_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public Action callback;

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
			public _003CCallback_003Ed__66(int _003C_003E1__state)
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

		[Header("Prefab")]
		[SerializeField]
		private BattlePassExtraReward extraRewardPrefab;

		[SerializeField]
		private BattlePassUnlock passUnlockPrefab;

		[SerializeField]
		private BattlePassCellItem cellItemPrefab;

		[Header("Element")]
		[SerializeField]
		private GameObject[] lockPremiumObjects;

		[SerializeField]
		private GameObject[] lockLuxuryObjects;

		[SerializeField]
		private RectTransform ticketParent;

		[SerializeField]
		private float midPositionButtonClaim;

		[SerializeField]
		private string pageExtraRewardPanel;

		[SerializeField]
		private string pagePurchasePanel;

		[SerializeField]
		private GameObject blockInputObj;

		[Header("Scroll")]
		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private float offsetYItem;

		[SerializeField]
		private float spacing;

		[SerializeField]
		private float paddingTop;

		[SerializeField]
		private float paddingBottom;

		[Header("Purchases")]
		[SerializeField]
		private Button buttonClaim;

		[SerializeField]
		private Button buttonPremium;

		[SerializeField]
		private GameObject notifyClaimAll;

		[SerializeField]
		private TextMeshProUGUI textPremiumPrice;

		[SerializeField]
		private TextMeshProUGUI textDiscountPremiumPrice;

		[SerializeField]
		private GameObject premiumTagDiscount;

		[SerializeField]
		private Button buttonLuxury;

		[SerializeField]
		private TextMeshProUGUI textLuxuryPrice;

		[SerializeField]
		private TextMeshProUGUI textDiscountLuxuryPrice;

		[SerializeField]
		private GameObject luxuryTagDiscount;

		private Vector2 stageItemSizeDelta;

		private BattlePassUnlock instancePassUnlock;

		private BattlePassExtraReward instanceExtraReward;

		private List<BattlePassCellItem> allStageItems;

		private List<Vector2> allStageDefaultPositions;

		private static bool hasRegisterPool;

		private static GameObject cellItemPrefabStatic;

		private static GameObject instancePassUnlockStatic;

		private static GameObject instanceBigRewardStatic;

		private bool hasBuild;

		private bool canClaimAnyLevel;

		[CompilerGenerated]
		private Action m_OnUpdateNotify;

		[CompilerGenerated]
		private Action m_OnRefreshView;

		private BattlePassUnlockPanel unlockPanel;

		private BattlePassCurrencyView currencyView;

		private List<TweenerCore<Vector3, Vector3, VectorOptions>> tweeners;

		private static TweenerCore<Vector2, Vector2, VectorOptions> scrollTween;

		public PlayerCurrencyView CoinView { get; set; }

		public bool IsBlockInput => false;

		private event Action OnUpdateNotify
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

		private event Action OnRefreshView
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

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private static void InitBattlePass(int packId, TMP_Text priceText, TMP_Text discoutPriceText, GameObject discountTag, bool hasBeenPurchased)
		{
		}

		private static void TrackImpression(ShopPackData packData)
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public void Init(BattlePassUnlockPanel unlockPanel, BattlePassCurrencyView currencyView, Action onClickUnlockLevel, Action onRefreshView)
		{
		}

		private void OpenPurchase(bool isShowLuxury)
		{
		}

		private void OpenExtraReward()
		{
		}

		public void UpdateButtonStatus(float duration = 0f)
		{
		}

		private void UpdateButtonLayout(float duration)
		{
		}

		private void ClaimAll()
		{
		}

		private void Build(Action onComplete)
		{
		}

		public void RefreshProgress()
		{
		}

		private void RefreshProgress(int temp)
		{
		}

		[IteratorStateMachine(typeof(_003CCallback_003Ed__66))]
		private IEnumerator Callback(float duration, Action callback)
		{
			return null;
		}

		public void SetActiveAllLockPremiumObjects(bool purchased)
		{
		}

		public void SetActiveAllLockLuxuryObjects(bool purchased)
		{
		}

		public void PushPassUnlockToIndex(int stage, int currencyValue, float duration)
		{
		}

		private void ReturnToPool()
		{
		}

		public void JumpStageToIndex(int stage, float duration)
		{
		}

		public void ReloadData()
		{
		}

		private void ShowDefaultExtraStageData(float duration)
		{
		}

		private void UpdateExtraStageData(float duration)
		{
		}

		private void ClickUnlockLevel(int level)
		{
		}

		private void ReleaseInput()
		{
		}

		private void RefreshCell((int stage, int rewardId) tuple)
		{
		}

		private void PauseUpdateCoinView()
		{
		}

		private void UnPauseUpdateCoinView()
		{
		}

		public void UpdateNotify()
		{
		}

		private static void ScrollToItemVertical(ScrollRect scrollRect, RectTransform item, float duration)
		{
		}
	}
}
