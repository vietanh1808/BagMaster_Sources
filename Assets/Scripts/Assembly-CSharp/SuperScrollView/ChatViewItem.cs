using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ChatViewItem : MonoBehaviour
	{
		public Text mMsgText;

		public RectTransform mMsgPicMask;

		public Image mMsgPic;

		public Image mIcon;

		public Image mItemBg;

		public Image mArrow;

		public Text mIndexText;

		private int mItemIndex;

		private float mMsgPicScaleX;

		private float mMsgPicScaleY;

		public int ItemIndex => 0;

		public void Init()
		{
		}

		public void SetItemData(ChatMsg itemData, int itemIndex)
		{
		}
	}
}
