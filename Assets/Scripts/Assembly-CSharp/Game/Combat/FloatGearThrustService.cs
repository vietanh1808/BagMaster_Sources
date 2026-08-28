using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	public class FloatGearThrustService : SafeDisposeable, IFloatGearAnimationStopable
	{
		[CompilerGenerated]
		private Action m_OnStartSlash;

		[CompilerGenerated]
		private Action m_OnStopSlash;

		[CompilerGenerated]
		private Action m_OnStartBack;

		[CompilerGenerated]
		private Action m_OnStopped;

		private readonly FloatGearThrustProfile _profile;

		private readonly Transform _transform;

		private Vector3 _initialPosition;

		private Quaternion _initialRotation;

		private Vector3 _initialScale;

		private Sequence _animationSequence;

		public event Action OnStartSlash
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

		public event Action OnStopSlash
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

		public event Action OnStartBack
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

		public event Action OnStopped
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

		public FloatGearThrustService(FloatGearThrustProfile profile, Transform transform)
		{
		}

		protected override void DoDispose()
		{
		}

		public bool IsPlaying()
		{
			return false;
		}

		public void Stop()
		{
		}

		public void Play(float distance, Vector3 direction, float timeScale, Action onStartSlash = null, Action onStopSlash = null, Action onStartBack = null)
		{
		}
	}
}
