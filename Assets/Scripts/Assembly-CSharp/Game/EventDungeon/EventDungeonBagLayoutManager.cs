using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Game.Combat;
using UnityEngine;

namespace Game.EventDungeon
{
	public class EventDungeonBagLayoutManager : BagLayoutManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateLayoutAsync_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GameObject> _003C_003Et__builder;

			public EventDungeonBagLayoutManager _003C_003E4__this;

			public string layoutName;

			private TaskAwaiter<LayoutType> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetLayoutPrefabAsync_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LayoutType> _003C_003Et__builder;

			public string layoutName;

			public EventDungeonBagLayoutManager _003C_003E4__this;

			private TaskAwaiter<LayoutType> _003C_003Eu__1;

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

		[SerializeField]
		private LayoutType defaultLayout;

		[AsyncStateMachine(typeof(_003CCreateLayoutAsync_003Ed__1))]
		public Task<GameObject> CreateLayoutAsync(string layoutName)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetLayoutPrefabAsync_003Ed__2))]
		private Task<LayoutType> GetLayoutPrefabAsync(string layoutName)
		{
			return null;
		}
	}
}
