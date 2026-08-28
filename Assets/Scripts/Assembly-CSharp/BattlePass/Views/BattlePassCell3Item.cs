using BattlePass.Share;
using Game.Data;
using UnityEngine;
using UnityEngine.UI;

namespace BattlePass.Views
{
	public class BattlePassCell3Item : BattlePassCellItem
	{
		[SerializeField]
		private Button buttonLuxuryClaim;

		[SerializeField]
		private EventCellRewardView luxuryView;

		private bool luxuryPurchased;

		private bool isLuxuryClaimed;

		protected override void Awake()
		{
		}

		private void LuxuryClaim()
		{
		}

		public override void UpdateData(BattlePassLevelData levelData, bool premiumPurchased, bool luxuryPurchased, bool stageUnlocked, bool isFreeClaimed, bool isPremiumClaimed, bool isLuxuryClaimed)
		{
		}
	}
}
