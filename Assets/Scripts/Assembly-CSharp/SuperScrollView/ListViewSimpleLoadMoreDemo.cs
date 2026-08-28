using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ListViewSimpleLoadMoreDemo : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStartLoadMore_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ListViewSimpleLoadMoreDemo _003C_003E4__this;

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
			public _003CStartLoadMore_003Ed__13(int _003C_003E1__state)
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

		public LoopListView2 mLoopListView;

		public int mTotalDataCount;

		private DataSourceMgr<SimpleItemData> mDataSourceMgr;

		private Button mBackButton;

		private int mCurrentSelectItemId;

		private LoadingTipStatus mLoadingTipStatus;

		public int mLoadCount;

		private IEnumerator mDelayCoroutine;

		private float mDelayTime;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		private void StartCoroutineLoadMore()
		{
		}

		[IteratorStateMachine(typeof(_003CStartLoadMore_003Ed__13))]
		private IEnumerator StartLoadMore()
		{
			return null;
		}

		private void LoadMore()
		{
		}

		private void UpdateLoadingTip(LoopListViewItem2 item)
		{
		}

		private void Update()
		{
		}

		private void OnDataSourceLoadMoreFinished()
		{
		}

		private void OnItemClicked(int itemId)
		{
		}

		private void OnBackButtonClicked()
		{
		}
	}
}
