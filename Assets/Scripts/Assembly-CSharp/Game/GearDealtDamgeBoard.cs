using System.Collections.Generic;
using Game.Combat;
using UnityEngine;

namespace Game
{
	public class GearDealtDamgeBoard : MonoBehaviour
	{
		[SerializeField]
		private List<GearLogItemUI> _items;

		[SerializeField]
		private int _maxItems;

		[SerializeField]
		private bool _sortBeforeRefresh;

		[SerializeField]
		private bool _autoSiblingIndex;

		[SerializeField]
		private float _updateCooldown;

		[SerializeField]
		private bool _refreshOnEnable;

		[SerializeField]
		private Sprite[] _trophySprites;

		protected List<GearLogItemUI> _actives;

		private bool _dirty;

		private float _updateTimer;

		private void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}

		protected virtual void UpdateItemPosition(float highest)
		{
		}

		public virtual void RefreshList()
		{
		}

		public void Hide()
		{
		}

		private void OnLog(float value)
		{
		}

		private int Sort(GearLogItemUI x, GearLogItemUI y)
		{
			return 0;
		}
	}
}
