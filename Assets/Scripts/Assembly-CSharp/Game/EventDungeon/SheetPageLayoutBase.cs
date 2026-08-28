using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.EventDungeon
{
	public class SheetPageLayoutBase : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPageListItemPrefab_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PageEventDungeonListItemBase> _003C_003Et__builder;

			public EventDungeonUnlockViewState ed;

			public CancellationToken cancellationToken;

			private TaskAwaiter<PageEventDungeonListItemBase> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		protected static Dictionary<string, Task<PageEventDungeonListItemBase>> itemPrefabs;

		public List<PageEventDungeonListItemBase> Items { get; }

		public virtual void RenderView(IEnumerable<EventDungeonUnlockViewState> events, CancellationToken cancellationToken = default(CancellationToken))
		{
		}

		public static void Preload(IEnumerable<EventDungeonUnlockViewState> eventDungeons)
		{
		}

		[AsyncStateMachine(typeof(_003CGetPageListItemPrefab_003Ed__6))]
		public Task<PageEventDungeonListItemBase> GetPageListItemPrefab(EventDungeonUnlockViewState ed, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
