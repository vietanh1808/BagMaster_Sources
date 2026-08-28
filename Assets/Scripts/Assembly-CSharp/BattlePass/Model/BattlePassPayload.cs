using System;
using System.Collections.Generic;
using BattlePass.Share;
using UnityEngine;

namespace BattlePass.Model
{
	[Serializable]
	public class BattlePassPayload
	{
		public long cycleEndUtc;

		public long lastLoginUtc;

		[SerializeField]
		private int eventId;

		[SerializeField]
		private int prePoint;

		[SerializeField]
		private int extraPoint;

		[SerializeField]
		private int extraPointTemp;

		[SerializeField]
		private bool isSessionEnded;

		[SerializeField]
		private bool hasPremiumPurchased;

		[SerializeField]
		private bool hasLuxuryPurchased;

		[SerializeField]
		private List<int> freeRewardClaimed;

		[SerializeField]
		private List<int> premiumRewardClaimed;

		[SerializeField]
		private List<int> luxuryRewardClaimed;

		[SerializeField]
		private List<int> extraRewardClaimed;

		[SerializeField]
		private List<int> questClaimed;

		[SerializeField]
		private List<EventQuestRuntimeData> questProgression;

		public bool shouldOpenBanner;

		public int EventId => 0;

		public bool IsSessionEnded => false;

		public bool HasPremiumPurchased => false;

		public bool HasLuxuryPurchased => false;

		public int PrePoint
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public IReadOnlyList<EventQuestRuntimeData> QuestProgression => null;

		public int ExtraPoint => 0;

		public int ExtraPointTemp => 0;

		public bool CanEndSessionByTime => false;

		public BattlePassPayload()
		{
		}

		public BattlePassPayload(int eventId, long cycleStartUtc, long cycleEndUtc)
		{
		}

		public void PurchasePremium()
		{
		}

		public void PurchaseLuxury()
		{
		}

		private void TrackPurchase(string trackType)
		{
		}

		public bool HasFreeClaimed(int stage)
		{
			return false;
		}

		public bool HasPremiumClaimed(int stage)
		{
			return false;
		}

		public bool HasLuxuryClaimed(int stage)
		{
			return false;
		}

		public bool HasExtraClaimed(int stage)
		{
			return false;
		}

		public bool HasQuestClaimed(int questId)
		{
			return false;
		}

		public EventQuestRuntimeData GetQuestTracking(int questId)
		{
			return null;
		}

		public void AddExtraPoint(int point)
		{
		}

		public void AddExtraPointTemp(int point)
		{
		}

		public void BeginTriggerQuestProgress(int questId, int progress)
		{
		}

		public void ClaimExtra(int stage)
		{
		}

		public void ClaimPremium(int stage)
		{
		}

		public void ClaimLuxury(int stage)
		{
		}

		public void ClaimFree(int stage)
		{
		}

		private void TrackRewardClaimed(int stage, string trackType, bool isExtra)
		{
		}

		public bool ClaimQuest(int questId)
		{
			return false;
		}

		public void TriggerLastLoginUnix()
		{
		}

		public void CheckEndSession()
		{
		}
	}
}
