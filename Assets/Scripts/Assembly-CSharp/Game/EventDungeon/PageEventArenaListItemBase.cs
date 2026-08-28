using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game.AssetManager;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EventDungeon
{
	public class PageEventArenaListItemBase : PageEventDungeonListItemBase
	{
		[CompilerGenerated]
		private sealed class _003CAutoTick_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PageEventArenaListItemBase _003C_003E4__this;

			private WaitForSeconds _003Cwfs_003E5__2;

			private long _003Cduration_003E5__3;

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
			public _003CAutoTick_003Ed__12(int _003C_003E1__state)
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
		private Button buttonEnter;

		[SerializeField]
		private TextMeshProUGUI textEndTime;

		[SerializeField]
		private SpriteAddressable rankIcon;

		[SerializeField]
		private TextMeshProUGUI textRankName;

		[SerializeField]
		private GameObject lockObject;

		[SerializeField]
		private TMP_Text textLockContent;

		private Coroutine coroutine;

		protected override void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Refresh()
		{
		}

		private void OnItemClicked()
		{
		}

		[IteratorStateMachine(typeof(_003CAutoTick_003Ed__12))]
		private IEnumerator AutoTick()
		{
			return null;
		}

		private string FormatSeasonTime(long duration)
		{
			return null;
		}

		public override void RenderView(EventDungeonUnlockViewState data)
		{
		}

		public override void PlayActiveFeedback()
		{
		}
	}
}
