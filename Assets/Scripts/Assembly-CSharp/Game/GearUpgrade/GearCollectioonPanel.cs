using System.Collections.Generic;
using Game.Combat;
using SuperScrollView;
using UnityEngine;

namespace Game.GearUpgrade
{
	public class GearCollectioonPanel : MonoBehaviour
	{
		[SerializeField]
		private LoopListView2 _collectionView;

		[SerializeField]
		private GameObject _itemPrefab;

		private List<List<GearData>> _gearGroups;

		private void Start()
		{
		}

		private LoopListViewItem2 OnGetItem(LoopListView2 gridView, int itemIndex)
		{
			return null;
		}

		private int GetUICount()
		{
			return 0;
		}
	}
}
