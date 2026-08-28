using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Game.Combat
{
	public class LevelProgressBar : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CUpdateProgress_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LevelProgressBar _003C_003E4__this;

			public float time;

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
			public _003CUpdateProgress_003Ed__11(int _003C_003E1__state)
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
		private RectTransform _progress;

		[SerializeField]
		private TextMeshProUGUI _waveTxt;

		[SerializeField]
		private Sprite bossWave;

		[SerializeField]
		private GameObject _waveCount;

		[SerializeField]
		private GameObject _boss;

		[SerializeField]
		private GameObject _shop;

		[SerializeField]
		private GameObject progressSprite;

		private int currentWave => 0;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateProgress_003Ed__11))]
		public IEnumerator UpdateProgress(float time)
		{
			return null;
		}

		public void UpdateProgressPercent(float percent)
		{
		}

		private void UpdateWaveState()
		{
		}
	}
}
