using System;
using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class TreeViewSimpleItem : MonoBehaviour
	{
		private int mItemDataIndex;

		private int mChildDataIndex;

		public Text mNameText;

		private SimpleItemData mItemData;

		public Image mImageSelect;

		private Button mButton;

		private Action<int, int> mOnClickItemCallBack;

		public int ItemIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ItemChildIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void Init(Action<int, int> OnClickItemCallBack = null)
		{
		}

		private void OnButtonClicked()
		{
		}

		public void SetItemData(SimpleItemData itemData, int itemIndex, int childIndex)
		{
		}

		public void SetItemSelected(bool isSelected)
		{
		}
	}
}
