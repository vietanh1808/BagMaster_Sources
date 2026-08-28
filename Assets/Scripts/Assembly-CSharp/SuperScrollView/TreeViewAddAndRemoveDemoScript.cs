using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class TreeViewAddAndRemoveDemoScript : MonoBehaviour
	{
		public LoopListView2 mLoopListView;

		private TreeViewDataSourceMgr<ItemData> mTreeViewDataSourceMgr;

		private TreeViewItemCountMgr mTreeItemCountMgr;

		private Button mAddChildButton;

		private InputField mAddChildInputItem;

		private InputField mAddChildInputChild;

		private Button mAddItemButton;

		private InputField mAddItemInputItem;

		private Button mRemoveChildButton;

		private InputField mRemoveChildInputItem;

		private InputField mRemoveChildInputChild;

		private Button mRemoveItemButton;

		private InputField mRemoveItemInputItem;

		private void Start()
		{
		}

		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		public void OnExpandClicked(int index)
		{
		}

		private void OnAddItemButtonClicked()
		{
		}

		private void OnAddChildButtonClicked()
		{
		}

		private void OnRemoveItemButtonClicked()
		{
		}

		private void OnRemoveChildButtonClicked()
		{
		}
	}
}
