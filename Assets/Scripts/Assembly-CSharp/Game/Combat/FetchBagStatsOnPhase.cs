using UnityEngine;

namespace Game.Combat
{
	public class FetchBagStatsOnPhase : MonoBehaviour
	{
		[SerializeField]
		private BagGeneralStats _bagGeneralStats;

		[SerializeField]
		private GamePhase _phase;

		private void Start()
		{
		}

		private void OnGamePhaseChanged(GamePhase phase)
		{
		}
	}
}
