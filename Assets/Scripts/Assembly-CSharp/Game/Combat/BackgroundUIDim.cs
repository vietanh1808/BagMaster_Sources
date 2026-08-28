using UnityEngine;

namespace Game.Combat
{
	public class BackgroundUIDim : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _rectTransform;

		[SerializeField]
		private int _onGearInfoPopupShowSiblingIndex;

		private int _originalIndex;

		private void Start()
		{
		}

		public void OnGearInfoPopupShow(bool show)
		{
		}
	}
}
