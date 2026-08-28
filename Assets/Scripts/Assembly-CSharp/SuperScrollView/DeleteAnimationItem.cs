using System;
using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class DeleteAnimationItem : MonoBehaviour
	{
		public Text mNameText;

		public Image mImageSelect;

		public RectTransform mContentRootTrans;

		private SimpleItemData mItemData;

		private Button mButton;

		private float mItemHeight;

		private AnimationType mAnimaionType;

		private float mAnimationValue;

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

		public void SetAnimationType(AnimationType type)
		{
		}

		public void SetAnimationValue(float animationValue)
		{
		}

		private void ResetItemAnimation()
		{
		}

		private void UpdateItemAnimation()
		{
		}

		private void ResetItemClip()
		{
		}

		private void ResetItemFade()
		{
		}

		private void ResetItemClipFade()
		{
		}

		private void ResetItemSlideLeft()
		{
		}

		private void ResetItemSlideRight()
		{
		}

		private void UpdateItemClip()
		{
		}

		private void UpdateItemFade()
		{
		}

		private void UpdateItemClipFade()
		{
		}

		private void UpdateItemSlideLeft()
		{
		}

		private void UpdateItemSlideRight()
		{
		}

		private void SetHeight(float height)
		{
		}

		private void SetAlpha(float alpha)
		{
		}

		private void SetPosition(float positionX)
		{
		}
	}
}
