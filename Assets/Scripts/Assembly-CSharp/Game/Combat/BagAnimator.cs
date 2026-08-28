using System.Collections.Generic;
using DG.Tweening;
using Game.CodedAnimation;
using UnityEngine;

namespace Game.Combat
{
	public class BagAnimator : MonoBehaviour
	{
		private enum ExpandDirection
		{
			Up = 0,
			Down = 1,
			Left = 2,
			Right = 3
		}

		[Header("Referennces")]
		[SerializeField]
		private SpriteRenderer _bagSpriteRenderer;

		[SerializeField]
		private GameObject _topBorder;

		[SerializeField]
		private GameObject _leftBorder;

		[SerializeField]
		private GameObject _rightBorder;

		[SerializeField]
		private GameObject _bottomLeftBorder;

		[SerializeField]
		private GameObject _bottomRightBorder;

		[Header("Times")]
		[SerializeField]
		private float _animationExpandDuration;

		[Tooltip("The time it take to make the bag bouncy back")]
		[SerializeField]
		private float _animationBouncyBackDuration;

		[Tooltip("How much should the bag expand")]
		[SerializeField]
		private float _animationOffset;

		[Header("Border Offset")]
		[SerializeField]
		private float _topBorderOffset;

		[SerializeField]
		private float _middleBorderOffset;

		[SerializeField]
		private float _bottomBorderOffset;

		[SerializeField]
		private float _bagExpandOffSet;

		[Header("Misc")]
		[SerializeField]
		private EaseOrAnimationCurve _animationEase;

		[SerializeField]
		private float _punchScale;

		private Dictionary<Vector2Int, Square> _squares;

		private float _x;

		private float _y;

		private float _width;

		private float _height;

		private Vector2 _minSquarePosition;

		private Vector2 _maxSquarePosition;

		private float _a;

		private float _b;

		private float _c;

		private float _d;

		private List<ExpandDirection> _expandDirections;

		private bool _isBagExpanding;

		private bool _initialized;

		private bool _dirty;

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		public void AddNewSquare(Vector2Int position, Square square)
		{
		}

		public void Initialize()
		{
		}

		private void UpdateMinMaxSquarePositions()
		{
		}

		private void UpdateSpriteRendererSize()
		{
		}

		public void UpdateSpriteParamters()
		{
		}

		private void AdjustBagToFitSquares()
		{
		}

		private void UpdateExpandDirections()
		{
		}

		private void AnimateSpriteBorders()
		{
		}

		private void AnimateBorders(float wB, float hB, int timeExH, int timeExV)
		{
		}

		private void AnimateBorderPosition(float width, float height, float topOfset, float bottomOffset, float middleOffset)
		{
		}

		private void AnimatePosition(GameObject target, Vector3 targetPos)
		{
		}

		private void AnimateBorderScalePunch()
		{
		}

		private void AnimateScaleAndPunch(GameObject target)
		{
		}

		private void BouncyAnimationBag()
		{
		}

		private void AnimateBagRenderer(float duration, TweenCallback onComplete)
		{
		}
	}
}
