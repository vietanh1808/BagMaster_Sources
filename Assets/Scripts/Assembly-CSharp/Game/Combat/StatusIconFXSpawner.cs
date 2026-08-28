using UnityEngine;

namespace Game.Combat
{
	public class StatusIconFXSpawner : MonoBehaviour
	{
		[SerializeField]
		private GameObject _fxPrefab;

		[SerializeField]
		private StatusManager _statusManager;

		[SerializeField]
		private StatusIconProfiles _statusIconProfiles;

		[SerializeField]
		private Transform _overridePosition;

		[SerializeField]
		private Transform _container;

		[SerializeField]
		private Health _health;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnStatusAppied(StatusData statusData)
		{
		}

		private void OnStatusRemoved(StatusData statusData)
		{
		}

		private void ClearIcons()
		{
		}
	}
}
