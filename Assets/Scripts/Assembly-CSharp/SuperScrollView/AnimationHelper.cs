using System.Collections.Generic;

namespace SuperScrollView
{
	public class AnimationHelper
	{
		public class AnimationData
		{
			public float mCurValue;

			public float mTargetValue;

			public float mSpeed;

			public bool mIsFinished;

			public bool Update(float deltaTime)
			{
				return false;
			}
		}

		private List<int> mAllAnimationKeys;

		private Dictionary<int, AnimationData> mAnimationDataDict;

		public List<int> AllAnimationKeys => null;

		public void StartAnimation(int itemId, float startValue, float targetValue, float totalTime, bool forceFromStart = false)
		{
		}

		public void RemoveAnimation(int itemId)
		{
		}

		public bool IsAnimationFinished(int itemId)
		{
			return false;
		}

		public void UpdateAllAnimation(float deltaTime)
		{
		}

		public float GetCurAnimationValue(int itemId)
		{
			return 0f;
		}
	}
}
