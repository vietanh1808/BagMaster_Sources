using UnityEngine;

namespace Game.Combat
{
	public class Square : MonoBehaviour
	{
		public Color CanPlaceColor;

		public Color CannotPlaceColor;

		public SlotBuffContainer BuffContainer;

		private SpriteRenderer _renderer;

		private Color _initialColor;

		private Color _color;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void Hover(bool canPlace)
		{
		}
	}
}
