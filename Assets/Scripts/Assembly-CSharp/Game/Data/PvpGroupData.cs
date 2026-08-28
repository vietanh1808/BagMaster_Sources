using System;
using UnityEngine;

namespace Game.Data
{
	[Serializable]
	public struct PvpGroupData
	{
		public int RankID;

		public int MinPlayer;

		public int MaxPlayer;

		[Obsolete]
		public int ExpectedRealPlayer;

		public string RankIcon;

		public string RankRibbon;

		public string RankBackground;

		[SerializeField]
		private string PromoteRank;

		[SerializeField]
		private string DemoteRank;

		public int PromoteUpRank => 0;

		public bool ShouldPromoteUpgradeRank(int topIndex)
		{
			return false;
		}

		public bool ShouldDemoteDowngradeRank(int topIndex)
		{
			return false;
		}
	}
}
