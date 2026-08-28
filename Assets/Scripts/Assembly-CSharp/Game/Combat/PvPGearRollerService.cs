using System.Collections.Generic;

namespace Game.Combat
{
	public class PvPGearRollerService
	{
		private readonly List<int> _poolGearIds;

		private readonly List<int> _waveGearCounts;

		private int[] _p1;

		private int[] _p2;

		public IReadOnlyList<int> P1 => null;

		public IReadOnlyList<int> P2 => null;

		public PvPGearRollerService(List<int> poolGearIds, List<int> waveGearCounts)
		{
		}

		public void GetDistributeGearIds(int index, out int[] p1, out int[] p2)
		{
			p1 = null;
			p2 = null;
		}

		public void RandomGears()
		{
		}

		private int[] PickRandom(int count, List<int> availableIndices)
		{
			return null;
		}
	}
}
