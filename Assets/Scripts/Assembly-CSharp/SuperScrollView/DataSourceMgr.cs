using System;
using System.Collections.Generic;

namespace SuperScrollView
{
	public class DataSourceMgr<T> where T : ItemDataBase, new()
	{
		private List<T> mItemDataList;

		private Action mOnRefreshFinished;

		private Action mOnLoadMoreFinished;

		private int mLoadMoreCount;

		private float mDataLoadLeftTime;

		private float mDataRefreshLeftTime;

		private bool mIsWaittingRefreshData;

		private bool mIsWaitLoadingMoreData;

		public int TotalItemCount => 0;

		public List<T> ItemDataList => null;

		public DataSourceMgr(int count)
		{
		}

		public T GetItemDataByIndex(int index)
		{
			return null;
		}

		public void RequestRefreshDataList(Action onReflushFinished)
		{
		}

		public void RequestLoadMoreDataList(int loadCount, Action onLoadMoreFinished)
		{
		}

		public void Update()
		{
		}

		public void SetDataTotalCount(int count)
		{
		}

		public void ExchangeData(int index1, int index2)
		{
		}

		public void RemoveData(int index)
		{
		}

		public void RemoveDataByItemId(int itemId)
		{
		}

		public T InsertData(int index)
		{
			return null;
		}

		public T InsertData(int index, T newData)
		{
			return null;
		}

		private void DoRefreshDataSource(int count)
		{
		}

		public void AppendData(int addCount)
		{
		}

		public void AppendData(T itemData)
		{
		}

		public List<T> GetFilteredItemList(string filterStr)
		{
			return null;
		}
	}
}
