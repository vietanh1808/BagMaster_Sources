using System.Collections.Generic;
using Game.Constant;
using UnityEngine;
using UnityEngine.Events;

namespace Game
{
	public class KingdomBuildingManager : MonoBehaviour
	{
		[SerializeField]
		private GameObject _prefab;

		[SerializeField]
		private Transform _spawnPosition;

		[Header("Events")]
		public UnityEvent<Building> OnBuildingCreatedEvent;

		private BuildingSpawnService _spawnService;

		private void Start()
		{
		}

		private void InitializePool()
		{
		}

		private Rarity GetRarityOnCreate()
		{
			return Rarity.Common;
		}

		private bool IsBuildingDataValid(KingdomBuildingData data)
		{
			return false;
		}

		public List<GameObject> Spawn()
		{
			return null;
		}

		private void TestSpawn()
		{
		}
	}
}
