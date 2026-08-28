using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game;
using Game.Shop;
using UnityEngine;
using UnityEngine.Purchasing;

namespace DoorServices
{
	public class IAPManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeIap_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public Awaitable.AwaitableAsyncMethodBuilder _003C_003Et__builder;

			public IAPManager _003C_003E4__this;

			private List<ProductDefinition> _003CproductsToFetch_003E5__2;

			private object _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private TaskAwaiter _003C_003Eu__1;

			private UniTask<bool>.Awaiter _003C_003Eu__2;

			private UniTask.Awaiter _003C_003Eu__3;

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
		private struct _003COnConfirmedOrderUpdatedAsync_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Order confirmedOrder;

			private SwitchToMainThreadAwaitable.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

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
		private struct _003COnFetchedPurchasesAsync_003Ed__51 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Orders orders;

			public IAPManager _003C_003E4__this;

			private SwitchToMainThreadAwaitable.Awaiter _003C_003Eu__1;

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
		private struct _003COnPendingOrderUpdatedAsync_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public PendingOrder pendingOrder;

			public IAPManager _003C_003E4__this;

			private SwitchToMainThreadAwaitable.Awaiter _003C_003Eu__1;

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
		private struct _003COnPurchaseDeferredAsync_003Ed__49 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public DeferredOrder deferredOrder;

			private SwitchToMainThreadAwaitable.Awaiter _003C_003Eu__1;

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
		private struct _003COnPurchaseFailedAsync_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public FailedOrder failedOrder;

			private SwitchToMainThreadAwaitable.Awaiter _003C_003Eu__1;

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

		public const string ADS_REMOVAL_1 = "offer_ad_removal_1";

		public const string ADS_REMOVAL_1_0 = "offer_ad_removal_1_0";

		public const string ADS_REMOVAL_1_1 = "offer_ad_removal_1_1";

		public const string ADS_REMOVAL_1_2 = "offer_ad_removal_1_2";

		public const string ADS_REMOVAL_1_0_NC = "offer_ad_removal_1_0_nc";

		public const string ADS_REMOVAL_1_1_NC = "offer_ad_removal_1_1_nc";

		public const string ADS_REMOVAL_1_2_NC = "offer_ad_removal_1_2_nc";

		public const string QUICK_AID_1 = "quick_aid_1";

		[CompilerGenerated]
		private static Action<Order> m_OnPurchaseSuccessEvent;

		[CompilerGenerated]
		private static Action<FailedOrder> m_OnPurchaseFailedEvent;

		[CompilerGenerated]
		private static Action<bool, List<RewardPack>> m_OnRestoreCompletedEvent;

		private static bool _isRestoringManually;

		private const int RETRY_DELAY_MS = 5000;

		private StoreController _storeController;

		private IStoreService _storeService;

		private IPurchaseService _purchaseService;

		private IProductService _productService;

		private UniTaskCompletionSource<bool> _productsFetchTcs;

		private UniTaskCompletionSource<bool> _purchasesFetchTcs;

		private bool _initialized;

		private bool IsFirstOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool AlreadyRestored
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static event Action<Order> OnPurchaseSuccessEvent
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

		public static event Action<FailedOrder> OnPurchaseFailedEvent
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

		public static event Action<bool, List<RewardPack>> OnRestoreCompletedEvent
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

		[AsyncStateMachine(typeof(_003CInitializeIap_003Ed__33))]
		public Awaitable InitializeIap()
		{
			return null;
		}

		private static List<ProductDefinition> BuildProductList()
		{
			return null;
		}

		private void ConfigureCallbacks()
		{
		}

		private static void LogDebug(string message)
		{
		}

		private static void LogError(string message)
		{
		}

		private void OnTransactionsRestored(bool success, string arg2)
		{
		}

		private void OnPendingOrderUpdated(PendingOrder pendingOrder)
		{
		}

		[AsyncStateMachine(typeof(_003COnPendingOrderUpdatedAsync_003Ed__40))]
		private UniTaskVoid OnPendingOrderUpdatedAsync(PendingOrder pendingOrder)
		{
			return default;
		}

		private void OnConfirmedOrderUpdated(Order confirmedOrder)
		{
		}

		[AsyncStateMachine(typeof(_003COnConfirmedOrderUpdatedAsync_003Ed__42))]
		private UniTaskVoid OnConfirmedOrderUpdatedAsync(Order confirmedOrder)
		{
			return default;
		}

		private static void CheckRemoveAds(string productId)
		{
		}

		private static void CheckRewardPack(string productId)
		{
		}

		private static void CheckBattlePassPack(string productId)
		{
		}

		private void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		[AsyncStateMachine(typeof(_003COnPurchaseFailedAsync_003Ed__47))]
		private UniTaskVoid OnPurchaseFailedAsync(FailedOrder failedOrder)
		{
			return default;
		}

		private void OnPurchaseDeferred(DeferredOrder deferredOrder)
		{
		}

		[AsyncStateMachine(typeof(_003COnPurchaseDeferredAsync_003Ed__49))]
		private UniTaskVoid OnPurchaseDeferredAsync(DeferredOrder deferredOrder)
		{
			return default;
		}

		private void OnFetchedPurchases(Orders orders)
		{
		}

		[AsyncStateMachine(typeof(_003COnFetchedPurchasesAsync_003Ed__51))]
		private UniTaskVoid OnFetchedPurchasesAsync(Orders orders)
		{
			return default;
		}

		private static void RestoreProduct(string productId)
		{
		}

		private static RewardPack RestoreProductWithReward(string productId)
		{
			return null;
		}

		private void OnFetchPurchasesFailed(PurchasesFetchFailureDescription description)
		{
		}

		private void OnCheckEntitlement(Entitlement checkEntitlementAction)
		{
		}

		private void OnAppleEntitlementsRevoked(string data)
		{
		}

		private void OnProductsFetchFailed(ProductFetchFailed failed)
		{
		}

		private void OnProductsFetchSuccess(List<Product> products)
		{
		}

		private void OnStoreDisconnected(StoreConnectionFailureDescription description)
		{
		}

		public static Product GetProduct(string productId)
		{
			return null;
		}

		public static decimal GetPrice(string productId)
		{
			return 0m;
		}

		public static string GetPriceString(string productId)
		{
			return null;
		}

		public static void SetAdsRemoval1()
		{
		}

		public static bool IsAdsRemoval1(string productId)
		{
			return false;
		}

		public static bool IsAdsRemoval1Discount(string productId)
		{
			return false;
		}

		public static bool CompareProductId(string productId, string targetId)
		{
			return false;
		}

		private static ProductType ResolveProductType(string productId)
		{
			return ProductType.Consumable;
		}

		private static ProductType ResolveProductType(ShopPackData packData)
		{
			return ProductType.Consumable;
		}

		public static void Purchase(string productId)
		{
		}

		public static void RestorePurchases()
		{
		}

		private static void OnUserRestoreComplete(bool success, string error)
		{
		}
	}
}
