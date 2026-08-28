using UnityEngine;

namespace Game
{
	public class UiFollower : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _target;

		[SerializeField]
		private Vector3 _offset;

		private Camera _mainCamera;

		private Camera _uiCamera;

		public RectTransform Target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
