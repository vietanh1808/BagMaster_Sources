using System;
using UnityEngine;

namespace Game.Data
{
	[Serializable]
	public struct PvpPointData
	{
		[SerializeField]
		private string PointRange;

		public int VictoryPoint;

		public int LosePoint;

		public bool InsideRange(int point)
		{
			return false;
		}
	}
}
