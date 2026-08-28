using System.Collections.Generic;
using System.Linq;
using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class BagContentDropArea : DropArea
	{
		[SerializeField]
		private CounterDropArea _counterDropArea;

		[SerializeField]
		private BenchDropArea _benchDropArea;

		[SerializeField]
		private BagGeneralStats _bagGeneralStats;

		[SerializeField]
		private MMF_Player _gearPlaceFeedback;

		[SerializeField]
		private Transform _gearContainer;

		[Header("Events")]
		public UnityEvent<IBagGridItem> OnItemPlaced;

		private BagGridMap _gridMap;

		private BagGridMap _testGridMap;

		private BagGridMap _history;

		private BagUnityPositionService _bagUnityPositionService;

		private BagUnityPositionService _testBagUnityPositionService;

		private BagSynercyMap _synercyMap;

		private BagSynercyMap _testSynercyMap;

		public PlayerPassiveManager PlayerPassiveManager;

		public bool OnlyMerge;

		public bool LockMerge;

		public bool LastTryPlacingResult;

		private bool _intialized;

		public IReadOnlyDictionary<Vector2Int, IBagGridItem> GridMap => null;

		public IReadOnlyDictionary<IBagGridItem, List<Vector2Int>> GearPlacementPoints => null;

		public IReadOnlyCollection<Gear> Gears => null;

		public BagGeneralStats BagGeneralStats => null;

		public bool TestMode => false;

		public float AllGearsDps => 0f;

		public void Initialize()
		{
		}

		private void OnSynercyMapUpdated()
		{
		}

		private void OnTestSynercyMapUpdated()
		{
		}

		public void UnlockPosition(Vector2Int position)
		{
		}

		public bool IsUnlocked(Vector2Int position)
		{
			return false;
		}

		public bool TryGetGearAt(Vector2Int position, out IBagGridItem item)
		{
			item = null;
			return false;
		}

		public IReadOnlyCollection<BagSynercyMap.Data> GetSynercyRelatives(IBagGridItem item)
		{
			return null;
		}

		public IEnumerable<BagSynercyMap.Data> GetSynercyDatas()
		{
			return null;
		}

		public Vector3 GetWorldPositionOfItem(IBagGridItem item)
		{
			return default;
		}

		public IReadOnlyCollection<Gear> GetGears(bool includeTestMode)
		{
			return null;
		}

		public IOrderedEnumerable<Gear> GetGearsByTopDownLeftRight(bool includeTestMode)
		{
			return null;
		}

		public override bool CanAccept(DragDropHandler dragDropHandler)
		{
			return false;
		}

		private bool CanAccept(IBagGridItem item)
		{
			return false;
		}

		public override void Drop(DragDropHandler dragDropHandler)
		{
		}

		private void InternalDrop(IBagGridItem item)
		{
		}

		public Vector3 GetDropWorldPosition(IBagGridItem item, Vector2Int[] gridPositions)
		{
			return default;
		}

		public Vector3 GetWorldPosition(Vector2Int gridPosition)
		{
			return default;
		}

		private void PlaceGear(IBagGridItem placingItem)
		{
		}

		private bool TryMerging(IBagGridItem placingItem, IReadOnlyCollection<IBagGridItem> overlappingItems)
		{
			return false;
		}

		private bool TrySwapping(IBagGridItem placingItem, IReadOnlyCollection<IBagGridItem> overlappingItems)
		{
			return false;
		}

		private bool CanSwapPosition(IBagGridItem item, Vector2Int[] previousGearPositions, IReadOnlyCollection<IBagGridItem> overlappingItems, out IBagGridItem swappableItem)
		{
			swappableItem = null;
			return false;
		}

		private void SwapGearPositionTo(IBagGridItem item, Vector2Int[] newPositions)
		{
		}

		private bool TryRepositionToNearby(IBagGridItem item, BagGridMap gridMap)
		{
			return false;
		}

		private bool FindAnPlaceNearby(IBagGridItem item, BagGridMap gridMap, out Vector2Int direction)
		{
			direction = default;
			return false;
		}

		private bool CanMoveItemBy(IBagGridItem item, Vector2Int v, BagGridMap gridMap)
		{
			return false;
		}

		private void MoveItemToArea(IBagGridItem item, BagGridMap gridMap, DropArea dropArea)
		{
		}

		private void InvokeAItemDropped(IBagGridItem droppedItem)
		{
		}

		public override void Remove(DragDropHandler dragDropHandler)
		{
		}

		private void Remove(IBagGridItem item)
		{
		}

		public void TryPlacing(IBagGridItem placingItem)
		{
		}

		private void UpdateGearInfoStats()
		{
		}

		private void RefreshCounterItems()
		{
		}

		public void FetchBagGeneralStats()
		{
		}

		public void FetchPassiveSkills()
		{
		}

		public IReadOnlyCollection<Vector2Int> GetUnlockedPositions()
		{
			return null;
		}
	}
}
