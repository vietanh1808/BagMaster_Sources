using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Game.CodedAnimation;
using UnityEngine;

namespace Game.Combat
{
	public class ItemDropFX : MonoBehaviour
	{
		[SerializeField]
		private SpriteRenderer _renderer;

		[Header("First Spawn")]
		[SerializeField]
		private float _scaleDuration;

		[SerializeField]
		private Ease _scaleEase;

		[SerializeField]
		private Vector2 _randomXRange;

		[SerializeField]
		private float _moveXDuration;

		[SerializeField]
		private Ease _moveXEase;

		[SerializeField]
		private Vector2 _randomYRange;

		[SerializeField]
		private float _moveYDuration;

		[SerializeField]
		private AnimationCurve _moveYEase;

		[Header("Fly")]
		[SerializeField]
		private Vector2 _randomSpeed;

		[SerializeField]
		private EaseOrAnimationCurve _flyEase;

		[CompilerGenerated]
		private Action m_OnFlyFinishedEvent;

		private float _worldSize;

		public static List<ItemDropFX> Items { get; private set; }

		public event Action OnFlyFinishedEvent
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

		private void OnDestroy()
		{
		}

		public void Play()
		{
		}

		public void Fly()
		{
		}

		public void SetLayerOvertop()
		{
		}

		private void OnEnd()
		{
		}

		public static void CreateCombatVariantWitCustomIcon(Vector2 around, Sprite icon)
		{
		}

		public static void CreateCombatVariantWitCustomIcon(Vector2 around, string iconName)
		{
		}
	}
}
