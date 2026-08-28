using System.Collections.Generic;
using Game.Constant;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Game.Combat
{
	public class GameplayGearManager : MonoBehaviour
	{
		[SerializeField]
		private Unit _gearOwner;

		[Header("Events")]
		public UnityEvent<Gear> OnGearCreatedEvent;

		public UnityEvent<Gear> OnGearReceivedLuckEvent;

		private IGearSpawnService _normalService;

		private IGearSpawnService _fixService;

		private IReadOnlyCollection<Rarity> _gearRarities;

		private float _luck;

		private List<Gear> _newGearsThisFrame;

		private List<AsyncOperationHandle<Sprite>> _gearSpriteHandles;

		private LevelData LevelData => null;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void TrackGearCreated(Gear gear)
		{
		}

		private void PreloadGearSprites()
		{
		}

		private void OnDestroy()
		{
		}

		private void InitializeNormalPool()
		{
		}

		private void InitializeGearPoolByLevel(LevelData levelData)
		{
		}

		public List<Gear> Spawn()
		{
			return null;
		}

		public List<Gear> TutorialSpawnEpicShortSwordOnly(List<int> remainGears)
		{
			return null;
		}

		private float GetLuck()
		{
			return 0f;
		}

		public void AddToPool(GearData gearData)
		{
		}

		public void RemoveFromPool(GearData gearData)
		{
		}
	}
}
