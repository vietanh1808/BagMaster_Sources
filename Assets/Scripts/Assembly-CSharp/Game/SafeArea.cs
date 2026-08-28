using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Game
{
	[RequireComponent(typeof(RectTransform))]
	public sealed class SafeArea : MonoBehaviour
	{
		[Header("Axes")]
		[Tooltip("Conform to the safe area horizontally.")]
		[SerializeField]
		private bool _conformX;

		[Tooltip("Conform to the safe area vertically.")]
		[SerializeField]
		private bool _conformY;

		[Tooltip("Ignore the safe area on the top edge (anchor it to the top of the screen).")]
		[SerializeField]
		private bool _ignoreTop;

		[Tooltip("Ignore the safe area on the bottom edge (anchor it to the bottom of the screen).")]
		[SerializeField]
		private bool _ignoreBottom;

		[Header("Extra Insets (screen px)")]
		[Tooltip("Permanent extra inset in screen pixels, applied on top of the safe area and any runtime insets.")]
		[SerializeField]
		private float _extraLeft;

		[SerializeField]
		private float _extraRight;

		[SerializeField]
		private float _extraBottom;

		[SerializeField]
		private float _extraTop;

		private RectTransform _rectTransform;

		private Rect _lastSafeArea;

		private static float _runtimeLeft;

		private static float _runtimeRight;

		private static float _runtimeBottom;

		private static float _runtimeTop;

		[CompilerGenerated]
		private static Action m__runtimeInsetsChanged;

		private static event Action _runtimeInsetsChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}

		private void HandleRuntimeInsetsChanged()
		{
		}

		private void Apply()
		{
		}

		public static void SetRuntimeInsets(float left, float bottom, float right, float top)
		{
		}

		public static void SetRuntimeBottomInset(float screenPixels)
		{
		}

		public static void ClearRuntimeBottomInset()
		{
		}
	}
}
