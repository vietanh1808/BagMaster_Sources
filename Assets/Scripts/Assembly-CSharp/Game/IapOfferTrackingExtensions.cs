using DoorServices;
using Game.Shop;
using UnityEngine.Purchasing;

namespace Game
{
	public static class IapOfferTrackingExtensions
	{
		public static void TrackIapOfferImpression(this IIapOfferView iapOfferView, string placement)
		{
		}

		public static void TrackIapOfferImpression(this IIapOfferView iapOfferView, ShopPackData shopPackData)
		{
		}

		public static void TrackIapOfferImpression(this ShopPackData shopPackData, StoreEntryMethod storeEntryMethod)
		{
		}

		public static void TrackFailedPurchaseResult(this IIapOfferView iapOfferView, FailedOrder order)
		{
		}

		public static PurchaseResult GetFailedPurchaseResult(this FailedOrder order)
		{
			return PurchaseResult.Cancelled;
		}

		public static void TrackSuccessfulPurchaseResult(this IIapOfferView iapOfferView)
		{
		}

		public static void TrackSuccessfulPurchaseResult(this IIapOfferView iapOfferView, Order order)
		{
		}
	}
}
