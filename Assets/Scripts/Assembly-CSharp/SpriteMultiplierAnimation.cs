using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class SpriteMultiplierAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateSprites_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpriteMultiplierAnimation _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAnimateSprites_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private SpriteRenderer _spriteRenderer;

	[SerializeField]
	private List<Sprite> _multiplierSprites;

	[SerializeField]
	private float _frameInterval;

	public bool PlayOnAwake;

	public bool Loop;

	public UnityEvent OnStopppedEvent;

	private int _currentSpriteIndex;

	private bool _isPlaying;

	private Sprite _baseSprite;

	private void Awake()
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateSprites_003Ed__13))]
	private IEnumerator AnimateSprites()
	{
		return null;
	}

	private void ApplyMultiplierSprite(Sprite multiplierSprite)
	{
	}

	public void AddMultiplierSprite(Sprite sprite)
	{
	}

	public void AddMultiplierSprites(IEnumerable<Sprite> sprites)
	{
	}

	public void ClearMultiplierSprites()
	{
	}

	public void SetBaseSprite(Sprite sprite)
	{
	}

	public void SetAnimationFrameRate(int frameRate)
	{
	}
}
