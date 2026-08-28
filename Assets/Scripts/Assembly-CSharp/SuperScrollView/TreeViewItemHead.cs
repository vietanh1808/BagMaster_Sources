using System;
using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class TreeViewItemHead : MonoBehaviour
	{
		public Text mText;

		public GameObject mArrow;

		public Button mButton;

		private int mTreeItemIndex;

		private Action<int> mClickHandler;

		public int TreeItemIndex => 0;

		public void Init()
		{
		}

		public void SetClickCallBack(Action<int> clickHandler)
		{
		}

		private void OnButtonClicked()
		{
		}

		public void SetExpand(bool expand)
		{
		}

		public void SetItemData(int treeItemIndex, bool expand)
		{
		}
	}
}
