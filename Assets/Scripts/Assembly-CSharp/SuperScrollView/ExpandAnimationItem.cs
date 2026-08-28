using System;
using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class ExpandAnimationItem : MonoBehaviour
	{
		public Text mNameText;

		public Text mDescText;

		public Image mImageSelect;

		public Text mClickTip;

		public Button mExpandButton;

		private SimpleExpandItemData mItemData;

		private Button mButton;

		private float mItemMinHeight;

		private float mItemMaxHeight;

		private float mItemContentMinHeight;

		private float mItemContentMaxHeight;

		private float mAnimationTime;

		private float mAnimationValue;

		private float mItemGap;

		private float mItemAverageHeight;

		private Action<int> mOnClickItemCallBack;

		private AnimationHelper mAnimationHelper;

		private ExpandAnimationType mAnimaionType;

		public void Init(Action<int> OnClickItemCallBack, AnimationHelper animationHelper)
		{
		}

		public void Init()
		{
		}

		private void OnButtonClicked()
		{
		}

		private void OnExpandButtonClicked()
		{
		}

		public void SetItemData(SimpleExpandItemData itemData)
		{
		}

		public void SetItemSelected(bool isSelected)
		{
		}

		public void SetAnimationType(ExpandAnimationType type)
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

		private void ResetItemClipFade()
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

		private void SetHeight(RectTransform rectTrans, float minHight, float maxHight, float animationValue)
		{
		}

		private void SetMinMaxHeight(RectTransform rectTrans, float minHight, float maxHight)
		{
		}

		private void SetAlpha(float alpha)
		{
		}
	}
}
