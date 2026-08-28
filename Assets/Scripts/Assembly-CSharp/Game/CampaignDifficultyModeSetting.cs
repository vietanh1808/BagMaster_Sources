using System;
using UnityEngine;

namespace Game
{
	[Serializable]
	public struct CampaignDifficultyModeSetting
	{
		public Sprite ButtonSprite;

		public Sprite LevelTypeSprite;

		public Color ChapterNameTopColor;

		public Color ChapterNameBottomColor;

		public Color RewardHaloColor;

		public Sprite RewardCircleSprite;

		public Color RewardCircleColor;

		public bool UseSpineBackground;

		public Sprite RewardBackgroundSprite;

		public string SpineSkinName;
	}
}
