using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	public class SupportUINavigation : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _tabLeft;

		[SerializeField]
		private RectTransform _tabRight;

		[SerializeField]
		private int _tabWidth;

		[SerializeField]
		private float _turnDuration;

		private Sequence _turnTween;

		private RectTransform _midTab;

		private RectTransform _otherTab;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		public void TurnLeft()
		{
		}

		public void TurnRight()
		{
		}

		private void StopLastTween()
		{
		}

		private void SwapTab()
		{
		}
	}
}
