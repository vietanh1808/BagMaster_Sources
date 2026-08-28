using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	public class CounterDropArea : DropArea
	{
		private class OrderData
		{
			public Transform Item;

			public float X;

			public float Width;
		}

		[SerializeField]
		private Camera _camera;

		[SerializeField]
		private Transform _contentContainer;

		[SerializeField]
		private float _spaceBetweenItems;

		[SerializeField]
		private float _itemMoveSpeed;

		[SerializeField]
		private float _padding;

		private List<OrderData> _orderDataList;

		private List<Tween> _refreshTweens;

		private bool _isDirty;

		public bool DontRefreshPosition;

		private float _screenWidth;

		public bool doneRefreshPosition;

		public bool InstantPosition;

		public bool LockMerge;

		public float LockMergeTime;

		public List<Transform> Items => null;

		public static CounterDropArea Instance { get; private set; }

		private void Awake()
		{
		}

		public override void Drop(DragDropHandler dragDropHandler)
		{
		}

		private bool TryMerge(DragDropHandler dragDropHandler)
		{
			return false;
		}

		private void CreateOrderData(ICounterItem counterItem)
		{
		}

		public void SafeRefreshItemPositions()
		{
		}

		public void RefreshItemPositionsNoAnim()
		{
		}

		private void RefreshItemPositions()
		{
		}

		public override void Remove(DragDropHandler dragDropHandler)
		{
		}

		public void RemoveAll()
		{
		}

		public void RemoveAllButNotDestroy()
		{
		}

		public override void DropGearHere(Gear gear)
		{
		}

		public void DropItemHere(ICounterItem item)
		{
		}

		public List<Transform> GetItemsHere()
		{
			return null;
		}

		public IEnumerable<Gear> GetAllGears()
		{
			return null;
		}

		public IEnumerable<Gear> FindGearsWithID(int id)
		{
			return null;
		}

		public Vector3 GetContainerCenter()
		{
			return default;
		}
	}
}
