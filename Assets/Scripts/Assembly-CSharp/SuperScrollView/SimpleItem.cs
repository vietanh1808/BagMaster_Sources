using System;
using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class SimpleItem : MonoBehaviour
	{
		public Text mNameText;

		private SimpleItemData mItemData;

		public Image mImageSelect;

		private Button mButton;

		private Action<int> mOnClickItemCallBack;

		public void Init(Action<int> OnClickItemCallBack = null)
		{
		}

		public void Init()
		{
		}

		private void OnButtonClicked()
		{
		}

		public void SetItemData(SimpleItemData itemData)
		{
		}

		public void SetItemSelected(bool isSelected)
		{
		}
	}
}
