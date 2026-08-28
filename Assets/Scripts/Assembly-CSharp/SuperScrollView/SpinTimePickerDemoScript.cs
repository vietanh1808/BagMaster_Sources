using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class SpinTimePickerDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListViewHour;

		public LoopListView2 mLoopListViewMinute;

		public Color mColorReserved;

		public Color mColorSelected;

		public Text CurSelect;

		private Button mBackButton;

		private int mFirstYear;

		private int mFirstMonth;

		private int mFirstDay;

		private int mFirstHour;

		private int mFirstMinute;

		private int mHourCount;

		private int mMinuteCount;

		private int mCurSelectedHour;

		private int mCurSelectedMinute;

		public int CurSelectedHour => 0;

		public int CurSelectedMinute => 0;

		private void Start()
		{
		}

		private void InitButtonPanel()
		{
		}

		private void ScrollToCurrentDate()
		{
		}

		private void UpdateCurSelect()
		{
		}

		private LoopListViewItem2 OnGetItemByIndexForMinute(LoopListView2 listView, int index)
		{
			return null;
		}

		private LoopListViewItem2 OnGetItemByIndexForHour(LoopListView2 listView, int index)
		{
			return null;
		}

		private void OnHourSnapTargetChanged(LoopListView2 listView, LoopListViewItem2 item)
		{
		}

		private void OnMinuteSnapTargetChanged(LoopListView2 listView, LoopListViewItem2 item)
		{
		}

		private void OnListViewSnapTargetChanged(LoopListView2 listView, int targetIndex)
		{
		}

		private void OnBackButtonClicked()
		{
		}
	}
}
