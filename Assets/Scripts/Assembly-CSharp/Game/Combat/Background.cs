using Game.AssetManager;
using UnityEngine;

namespace Game.Combat
{
	public class Background : MonoBehaviour
	{
		[SerializeField]
		private GameObject _defaultBackgroundPrefab;

		[SerializeField]
		private PrefabAddressable _backgroundLoader;

		private void Start()
		{
		}

		private void OnBackgroundPrefabLoaded(GameObject prefab)
		{
		}

		private void RebindSpawnPoints(GameObject backgroundInstance)
		{
		}

		private void SetupFeedbacks(GameObject instance)
		{
		}
	}
}
