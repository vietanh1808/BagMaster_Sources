using UnityEngine;

namespace Combat.Dungeon
{
	public class SpawnPointsContainer : MonoBehaviour
	{
		[SerializeField]
		private Transform[] _portalPoints;

		public Transform[] PortalPoints => null;
	}
}
