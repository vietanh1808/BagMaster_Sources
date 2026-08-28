using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	public class FloatGearSlashingService : SafeDisposeable, IFloatGearAnimationStopable
	{
		[CompilerGenerated]
		private Action m_OnStartSlash;

		[CompilerGenerated]
		private Action m_OnStopSlash;

		[CompilerGenerated]
		private Action m_OnStartBack;

		[CompilerGenerated]
		private Action m_OnStopped;

		private readonly FloatGearSlashingProfile _profile;

		private readonly Transform _transform;

		private Vector3 _initialPosition;

		private Vector3 _initialScale;

		private float _initialAngle;

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

		public FloatGearSlashingService(FloatGearSlashingProfile profile, Transform transform)
		{
		}

		public bool IsPlaying()
		{
			return false;
		}

		public void Stop()
		{
		}

		public void Play(float distance, Vector3 direction, float slashUpRadius, float slashDownRadius, float forwardRadius, float timeScale, Action onStartSlash = null, Action onStopSlash = null, Action onStartBack = null)
		{
		}

		private float GetAngle()
		{
			return 0f;
		}

		private void SetAngle(float v)
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
