using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Game.ChainPack
{
	[Serializable]
	public class ChainPackData
	{
		[SerializeField]
		[JsonProperty]
		private int groupId;

		[SerializeField]
		[JsonProperty]
		private int level;

		[SerializeField]
		[JsonProperty]
		private long endEventUnixTime;

		[SerializeField]
		[JsonProperty]
		private bool isExpired;

		[JsonIgnore]
		public int Level => 0;

		[JsonIgnore]
		public int GroupId => 0;

		public ChainPackData(int groupId, int duration)
		{
		}

		public ChainPackData()
		{
		}

		public void Claim()
		{
		}

		public bool IsExpired()
		{
			return false;
		}

		public void SetExpire()
		{
		}

		public long RemainDuration()
		{
			return 0L;
		}
	}
}
