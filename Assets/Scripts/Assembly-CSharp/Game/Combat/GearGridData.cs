using System;
using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(menuName = "ScriptableObjects/GearGridData")]
	public class GearGridData : ScriptableObject
	{
		public Vector2Int[] PlacementPoints;

		public Sprite GridIcon;

		public VerticalAlignment UiVerticalAlignment;

		public HorizontalAlignment UiHorizontalAlignment;

		public Sprite SelectionSprite;

		public Sprite OnBagSlot;

		public Sprite OnBagBorder;

		private Vector2Int _min;

		private Vector2Int _max;

		public Vector2Int Min => default;

		public Vector2Int Max => default;

		public Vector2 Offset => default;

		private void OnValidate()
		{
		}

		private void OnEnable()
		{
		}

		[Obsolete("Use Offset instead")]
		public Vector2 CalculateOffset()
		{
			return default;
		}
	}
}
