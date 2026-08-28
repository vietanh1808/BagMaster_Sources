using Game.AssetManager;
using UnityEngine;

namespace Game.Combat
{
	public class ElementalIcon : MonoBehaviour
	{
		[SerializeField]
		private ImageAddressable _icon;

		[SerializeField]
		[Tooltip("The offset to apply to offset targets when the icon is active")]
		private Vector2 _iconOffset;

		[SerializeField]
		private RectTransform[] _offsetTargets;

		private Vector2[] _originalPositions;

		public void SetElement(Elemental element)
		{
		}

		private void SetShownStatus(bool isShown)
		{
		}

		private void TryInit()
		{
		}
	}
}
