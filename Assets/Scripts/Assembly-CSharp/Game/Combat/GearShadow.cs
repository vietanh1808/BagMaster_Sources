using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	public class GearShadow : MonoBehaviour
	{
		[SerializeField]
		private SpriteRenderer _shadowRenderer;

		[SerializeField]
		private Vector3 _dragggingOffset;

		[SerializeField]
		private Vector3 _onPlacingOffset;

		[SerializeField]
		private float _draggingSmoothTime;

		private Vector3 _initialPosition;

		private float _initialAlpha;

		public Vector3 DraggingOffset
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		private void OnDestroy()
		{
		}

		public void SetShadow(Sprite sprite)
		{
		}

		public void SetShadow(string spritePath)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void SetAlpha(float percent)
		{
		}

		public Tween SetAlpha(float percent, float duration)
		{
			return null;
		}

		public void StartDrag()
		{
		}

		public void EndDrag()
		{
		}

		public void OnPlacing()
		{
		}
	}
}
