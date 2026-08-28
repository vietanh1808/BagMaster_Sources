using System;
using System.Collections.Generic;

namespace Game
{
	[Serializable]
	public class MailSaveData
	{
		public int Id;

		public int MailConfigId;

		public long SentTimeEpoch;

		public List<ResourceRewardDataRef> Rewards;

		public bool Read;

		public bool Claimed;

		public bool Deleted;
	}
}
