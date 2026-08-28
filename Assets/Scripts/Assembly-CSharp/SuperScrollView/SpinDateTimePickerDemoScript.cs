using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class SpinDateTimePickerDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListViewMonth;

		public LoopListView2 mLoopListViewDay;

		public LoopListView2 mLoopListViewHour;

		public LoopListView2 mLoopListViewMinute;

		public Color mColorReserved;

		public Color mColorSelected;

		public Text CurSelect;

		public int CurYear;

		private Button mBackButton;

		private static string[] mWeekDayNameArray;

		private static string[] mMonthNameArray;

		private int mFirstYear;

		private int mFirstMonth;

		private int mFirstDay;

		private int mFirstHour;

		private int mFirstMinute;

		private int mMonthCount;

		private int mHourCount;

		private int mMinuteCount;

		private int mCurSelectedMonth;

		private int mCurSelectedDay;

		private int mCurSelectedHour;

		private int mCurSelectedMinute;

		public int CurSelectedMonth => 0;

		public int CurSelectedDay => 0;

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

		private LoopListViewItem2 OnGetItemByIndexForMonth(LoopListView2 listView, int index)
		{
			return null;
		}

		private LoopListViewItem2 OnGetItemByIndexForDay(LoopListView2 listView, int index)
		{
			return null;
		}

		private void OnMonthSnapTargetChanged(LoopListView2 listView, LoopListViewItem2 item)
		{
		}

		private void OnDaySnapTargetChanged(LoopListView2 listView, LoopListViewItem2 item)
		{
		}

		private void OnHourSnapTargetChanged(LoopListView2 listView, LoopListViewItem2 item)
		{
		}

		private void OnMinuteSnapTargetChanged(LoopListView2 listView, LoopListViewItem2 item)
		{
		}

		private void OnMonthSnapTargetFinished(LoopListView2 listView, LoopListViewItem2 item)
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
