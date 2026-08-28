using System;
using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ContentFitterItem : MonoBehaviour
	{
		public Text mNameText;

		private ContentFitterItemData mItemData;

		private int mItemDataIndex;

		public Image mImageSelect;

		private Action<int> mOnClickItemCallBack;

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

		public void Init(Action<int> OnClickItemCallBack = null)
		{
		}

		private void OnButtonClicked(GameObject obj)
		{
		}

		public void SetItemData(ContentFitterItemData itemData, int itemIndex)
		{
		}

		public void SetItemSelected(bool isSelected)
		{
		}
	}
}
