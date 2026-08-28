using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FlickWall : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFlicker_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Color initialColor;

		public Color flickerColor;

		public FlickWall _003C_003E4__this;

		public float flickerDuration;

		public float flickerSpeed;

		private float _003CflickerStop_003E5__2;

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
		public _003CFlicker_003Ed__5(int _003C_003E1__state)
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
	private float _duration;

	[SerializeField]
	private Color _color;

	[SerializeField]
	private SpriteRenderer[] _spriteRenderers;

	private bool _isFlickering;

	public void Flick()
	{
	}

	[IteratorStateMachine(typeof(_003CFlicker_003Ed__5))]
	public virtual IEnumerator Flicker(Color initialColor, Color flickerColor, float flickerSpeed, float flickerDuration)
	{
		return null;
	}

	private void SetColor(Color color)
	{
	}
}
