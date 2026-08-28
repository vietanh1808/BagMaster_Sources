using System;
using System.Runtime.CompilerServices;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.EventDungeon
{
	public class PageEventDungeonListItemBase : MonoBehaviour
	{
		[CompilerGenerated]
		private static Action<PageEventDungeonListItemBase> m_onSelect;

		[CompilerGenerated]
		private static Action m_onTriggerRefreshItem;

		[SerializeField]
		protected MMF_Player activeFeedback;

		[SerializeField]
		protected GameObject contentMain;

		public EventDungeonUnlockViewState ViewState { get; protected set; }

		public static event Action<PageEventDungeonListItemBase> onSelect
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

		protected static event Action onTriggerRefreshItem
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

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public static void TriggerRefreshAllItems()
		{
		}

		protected virtual void OnTriggerRefresh()
		{
		}

		protected virtual void OnTicketChanged(EventDungeonUnlockViewState state)
		{
		}

		public virtual void RenderView(EventDungeonUnlockViewState data)
		{
		}

		public virtual void SetData(EventDungeonUnlockViewState data)
		{
		}

		public virtual void PlayActiveFeedback()
		{
		}

		protected void RaiseOnSelect()
		{
		}

		protected virtual void OnValidate()
		{
		}
	}
}
