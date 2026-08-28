using System;
using System.Collections.Generic;

namespace Game.MailBox
{
	public class Mail_Content_DTO
	{
		public int Id;

		public string Title;

		public string Content;

		public DateTime SentTime;

		public List<ResourceRewardData> Rewards;

		public bool Read;

		public bool Claimed;

		public static Mail_Content_DTO FromSaveData(MailSaveData data)
		{
			return null;
		}
	}
}
