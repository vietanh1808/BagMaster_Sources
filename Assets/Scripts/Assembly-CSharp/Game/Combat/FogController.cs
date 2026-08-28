using UnityEngine;

namespace Game.Combat
{
	public class FogController : MonoBehaviour
	{
		[SerializeField]
		private GameObject _fogPrefab;

		private GameObject _fogInstance;

		private void Start()
		{
		}

		private void OnGamePhaseChanged(GamePhase phase)
		{
		}
	}
}
