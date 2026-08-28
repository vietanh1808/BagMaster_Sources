using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Game.Newbie
{
	[Serializable]
	public class NewbieData
	{
		[SerializeField]
		[JsonProperty]
		private bool showUnlock;

		[SerializeField]
		[JsonProperty]
		private long unlockUnixTime;

		[SerializeField]
		[JsonProperty]
		private int groupId;

		[SerializeField]
		[JsonProperty]
		private int duration;

		[SerializeField]
		[JsonProperty]
		private bool isPurchased;

		[SerializeField]
		[JsonProperty]
		private bool claimedDay01;

		[SerializeField]
		[JsonProperty]
		private bool claimedDay02;

		[SerializeField]
		[JsonProperty]
		private bool claimedDay03;

		[SerializeField]
		[JsonProperty]
		private long _purchaseUnixTime;

		[JsonIgnore]
		public int GroupId => 0;

		[JsonIgnore]
		public bool IsPurchased => false;

		public NewbieData(int groupId, int duration, long unlockUnixTime)
		{
		}

		public void ShowUnlock()
		{
		}

		public bool IsShowedUnlock()
		{
			return false;
		}

		public void Purchase()
		{
		}

		public bool IsUnlockedDay(int index)
		{
			return false;
		}

		public bool IsExpired()
		{
			return false;
		}

		public int RemainDuration()
		{
			return 0;
		}

		public bool IsFullyClaimed()
		{
			return false;
		}

		public bool IsClaimedDay(int index)
		{
			return false;
		}

		public void Claim(int index)
		{
		}

		private bool IsOverlap(long offsetUnixTime)
		{
			return false;
		}

		public bool IsPreviousRewardUnlocked(int index)
		{
			return false;
		}

		public bool TryGetRewardUnlockRemainDuration(int index, out long seconds)
		{
			seconds = default;
			return false;
		}
	}
}
