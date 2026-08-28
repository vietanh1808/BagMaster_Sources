using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Game
{
	[RequireComponent(typeof(Camera))]
	public sealed class CameraSafeArea : MonoBehaviour
	{
		[Header("Axes")]
		[Tooltip("Conform to Screen.safeArea vertically (notch / status bar).")]
		[SerializeField]
		private bool _conformToSafeArea;

		[Header("Extra Insets (screen px)")]
		[Tooltip("Extra inset at the bottom, in screen pixels (e.g. raise gameplay above the banner).")]
		[SerializeField]
		private float _extraBottom;

		[Tooltip("Extra inset at the top, in screen pixels.")]
		[SerializeField]
		private float _extraTop;

		private Camera _camera;

		private Rect _lastSafeArea;

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

		private void Apply()
		{
		}

		public static void SetRuntimeInsets(float bottom, float top)
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
