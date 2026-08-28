using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class SpinDatePickerDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListViewYear;

		public LoopListView2 mLoopListViewMonth;

		public LoopListView2 mLoopListViewDay;

		public Color mColorReserved;

		public Color mColorSelected;

		public Text CurSelect;

		private Button mBackButton;

		private static string[] mMonthNameArray;

		private static string[] mWeekDayNameArray;

		private int mFirstYear;

		private int mFirstMonth;

		private int mFirstDay;

		private int mYearCount;

		private int mMonthCount;

		private int mCurSelectedMonth;

		private int mCurSelectedDay;

		private int mCurSelectedYear;

		public int CurSelectedYear => 0;

		public int CurSelectedMonth => 0;

		public int CurSelectedDay => 0;

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

		private LoopListViewItem2 OnGetItemByIndexForYear(LoopListView2 listView, int index)
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

		private void OnYearSnapTargetChanged(LoopListView2 listView, LoopListViewItem2 item)
		{
		}

		private void OnMonthSnapTargetChanged(LoopListView2 listView, LoopListViewItem2 item)
		{
		}

		private void OnDaySnapTargetChanged(LoopListView2 listView, LoopListViewItem2 item)
		{
		}

		private void OnYearSnapTargetFinished(LoopListView2 listView, LoopListViewItem2 item)
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
