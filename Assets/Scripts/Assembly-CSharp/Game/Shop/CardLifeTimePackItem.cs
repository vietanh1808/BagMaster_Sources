using TMPro;
using UnityEngine;

namespace Game.Shop
{
	public class CardLifeTimePackItem : SubscriptionNDailyBonusPackItem
	{
		[SerializeField]
		private GameObject _discountedUi;

		[SerializeField]
		private TextMeshProUGUI _discountRemainDurationText;

		[Header("Runtime")]
		[SerializeField]
		private bool _isDiscounted;

		private PlayerInfo PInfo => null;

		protected override void Start()
		{
		}

		private void CheckDiscount()
		{
		}

		public override int GetPackId()
		{
			return 0;
		}

		public override string GetDailyRewardPlacement()
		{
			return null;
		}

		protected override void UpdateDailyClaimButtons()
		{
		}

		private void CheckUpdateDiscountRemainDuration()
		{
		}
	}
}
