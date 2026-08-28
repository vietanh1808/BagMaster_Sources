using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Game.UI
{
	[Serializable]
	public class PoolingGridController<TData, TViewItem> where TViewItem : MonoBehaviour, IPooledViewItem<TData>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInstantiateViewItems_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public PoolingGridController<TData, TViewItem> _003C_003E4__this;

			private AsyncInstantiateOperation<TViewItem> _003Coperation_003E5__2;

			private UniTask.Awaiter _003C_003Eu__1;

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
		private struct _003CSyncItemsAndViews_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PoolingGridController<TData, TViewItem> _003C_003E4__this;

			public CancellationToken cancellationToken;

			private UniTask.Awaiter _003C_003Eu__1;

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
		private struct _003CUpdate_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PoolingGridController<TData, TViewItem> _003C_003E4__this;

			public CancellationToken cancellationToken;

			private UniTask.Awaiter _003C_003Eu__1;

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

		[CompilerGenerated]
		private sealed class _003Cget_VisibleViewItems_003Ed__30 : IEnumerable<TViewItem>, IEnumerable, IEnumerator<TViewItem>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private TViewItem _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public PoolingGridController<TData, TViewItem> _003C_003E4__this;

			private int _003Climit_003E5__2;

			private int _003Ci_003E5__3;

			TViewItem IEnumerator<TViewItem>.Current
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
			public _003Cget_VisibleViewItems_003Ed__30(int _003C_003E1__state)
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

			[DebuggerHidden]
			IEnumerator<TViewItem> IEnumerable<TViewItem>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private const int ExtraVisibleRowCount = 1;

		[SerializeField]
		private TViewItem _itemPrefab;

		[SerializeField]
		private RectTransform _container;

		[SerializeField]
		private RectTransform _viewport;

		[SerializeField]
		private RectOffset _padding;

		public float Spacing;

		private int _topRowIndex;

		private readonly List<TData> _dataItems;

		private readonly List<TViewItem> _viewItems;

		private bool _isContentDirty;

		private int _realViewItemCount;

		[CompilerGenerated]
		private Action<TData, TViewItem> m_OnItemClick;

		[CompilerGenerated]
		private Action<TData, TViewItem> m_OnItemsBecomeVisible;

		private Vector2 ViewPortSize => default;

		private Vector2 ItemSize => default;

		private int VisibleRowCount => 0;

		private int ColumnCount => 0;

		private Vector2 ContainerPosition => default;

		private int BottomRowIndex => 0;

		private int MaxRowIndex => 0;

		private int TargetViewItemCount => 0;

		public IReadOnlyList<TData> DataItems => null;

		public IEnumerable<TViewItem> VisibleViewItems
		{
			[IteratorStateMachine(typeof(PoolingGridController<, >._003Cget_VisibleViewItems_003Ed__30))]
			get
			{
				return null;
			}
		}

		public event Action<TData, TViewItem> OnItemClick
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

		public event Action<TData, TViewItem> OnItemsBecomeVisible
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

		public UniTask Init(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		public void Add(TData item)
		{
		}

		public void Add(IEnumerable<TData> newItems)
		{
		}

		public void Remove(TData item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Clear()
		{
		}

		public void Refresh(IEnumerable<TData> dataItems)
		{
		}

		public void Sort(Comparison<TData> comparison = null)
		{
		}

		[AsyncStateMachine(typeof(PoolingGridController<, >._003CUpdate_003Ed__45))]
		public UniTask Update(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		[AsyncStateMachine(typeof(PoolingGridController<, >._003CSyncItemsAndViews_003Ed__46))]
		private UniTask SyncItemsAndViews(CancellationToken cancellationToken)
		{
			return default;
		}

		[AsyncStateMachine(typeof(PoolingGridController<, >._003CInstantiateViewItems_003Ed__47))]
		private UniTask InstantiateViewItems(CancellationToken cancellationToken)
		{
			return default;
		}

		private void SetUp(TViewItem item, int index)
		{
		}

		private void InvokeClickEvent(TData item, int virtualIndex)
		{
		}

		private void UpdateContentSize()
		{
		}

		private bool CheckBound(int viewItemIndex, bool isTop)
		{
			return false;
		}

		private bool CheckBound(RectTransform rectTransform, bool isTop)
		{
			return false;
		}

		private void MoveItems(int rowIndex, int offset)
		{
		}

		private Vector2 GetAnchoredPosition(int index)
		{
			return default;
		}

		private Vector2 GetAnchoredPosition(int row, int column)
		{
			return default;
		}

		private void InvokeVisibleEvent(TData item, TViewItem viewItem)
		{
		}
	}
}
