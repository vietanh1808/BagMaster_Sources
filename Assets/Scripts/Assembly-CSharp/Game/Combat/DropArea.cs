using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Combat
{
	public class DropArea : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoolDownShowTooltip_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string title;

			public string description;

			public DropArea _003C_003E4__this;

			public TooltipType tooltipType;

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
			public _003CCoolDownShowTooltip_003Ed__20(int _003C_003E1__state)
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

		public static DropArea Default;

		[SerializeField]
		protected GameObject _mergeVfxPrefab;

		[SerializeField]
		protected MMF_Player _mergeFeedback;

		[SerializeField]
		private Vector2 tooltipOffset;

		public float coolDownShowTooltipTime;

		public bool DirtyDropped;

		protected float _nextTooltipAvailableTime;

		protected IMergeService _gearMergeService;

		public bool CanShowToolTip => false;

		protected virtual void OnDestroy()
		{
		}

		public virtual void LateUpdate()
		{
		}

		public virtual bool CanAccept(DragDropHandler dragDropHandler)
		{
			return false;
		}

		public virtual void OnHover(DragDropHandler dragDropHandler)
		{
		}

		public virtual void OnExit(DragDropHandler dragDropHandler)
		{
		}

		public virtual void OnClick()
		{
		}

		public virtual void Drop(DragDropHandler dragDropHandler)
		{
		}

		public virtual void Remove(DragDropHandler dragDropHandler)
		{
		}

		public void UpgradeGear(Gear gear, Unit _player)
		{
		}

		private GameObject GetMergeVfx(Gear gear)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoolDownShowTooltip_003Ed__20))]
		public IEnumerator CoolDownShowTooltip(string title, string description, TooltipType tooltipType)
		{
			return null;
		}

		public virtual void DropGearHere(Gear gear)
		{
		}

		public virtual void SetMergeService(IMergeService mergeService)
		{
		}

		public virtual void OnGearMerged(IMergeableItem newGear)
		{
		}

		protected virtual void OnMergeableItemRemoved(IMergeableItem mergeableItem)
		{
		}
	}
}
