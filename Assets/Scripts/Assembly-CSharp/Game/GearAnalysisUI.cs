using System.Collections.Generic;
using Game.Combat;
using UnityEngine;

namespace Game
{
	public class GearAnalysisUI : MonoBehaviour
	{
		[SerializeField]
		private List<GearLogItemUI> _items;

		[SerializeField]
		private float _spacing;

		[SerializeField]
		private float _paddingTop;

		[SerializeField]
		private float _paddingBot;

		[SerializeField]
		private RectTransform _container;

		[SerializeField]
		private float _updateCooldown;

		[SerializeField]
		private Sprite[] _trophySprites;

		[SerializeField]
		private RectTransform[] _trophies;

		private List<GearLogItemUI> _actives;

		private float[] _yPositions;

		private bool _dirty;

		private float _updateTimer;

		private void LateUpdate()
		{
		}

		public void RefreshList()
		{
		}

		public void Hide()
		{
		}

		private void UpdateContainerSize()
		{
		}

		private void UpdateLayout(List<GearLogItemUI> items)
		{
		}

		private void OnLog(float value)
		{
		}

		private int Sort(GearLogItemUI x, GearLogItemUI y)
		{
			return 0;
		}

		private void SetTrophyPositionY(int index, float y)
		{
		}
	}
}
