using System.Collections.Generic;
using Game.Combat;
using UnityEngine;

namespace Game
{
	public class GearDealtDamgeBoardOneTime : MonoBehaviour
	{
		[SerializeField]
		private List<GearLogItemUI> _items;

		[SerializeField]
		private int _maxItems;

		[SerializeField]
		private bool _refreshOnEnable;

		[SerializeField]
		private Sprite[] _trophySprites;

		[SerializeField]
		private GameObject[] _disableWhenEmpty;

		[SerializeField]
		private bool _leaveEmpty;

		private void OnEnable()
		{
		}

		public void RefreshList()
		{
		}

		private void SetTrophy(GearLogItemUI itemUi, int index)
		{
		}

		protected void Empty()
		{
		}
	}
}
