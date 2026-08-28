using UnityEngine;

namespace Game.Combat
{
	public class FakeSlot : MonoBehaviour
	{
		[SerializeField]
		private Sprite _normalSprite;

		[SerializeField]
		private Sprite _hoverSprite;

		[SerializeField]
		private Sprite _hoverInvalidSprite;

		private SpriteRenderer _renderer;

		private bool _hover;

		private bool _valid;

		public SpriteRenderer Renderer => null;

		private void LateUpdate()
		{
		}

		public void Hover(bool valid)
		{
		}
	}
}
