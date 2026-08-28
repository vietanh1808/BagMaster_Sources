using MoreMountains.Tools;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class CampaignDifficultyPreview : MonoBehaviour
	{
		[SerializeField]
		private MMSerializableDictionary<CampaignDifficultyMode, Sprite> _stageSprites;

		[SerializeField]
		private Image _stageImage;

		[SerializeField]
		private SkeletonGraphic _skeletonGraphic;

		[SerializeField]
		private SkeletonAnimation _skeletonAnimation;

		[SerializeField]
		private Color _lockColor;

		public void Show(CampaignDifficultyMode mode, bool isChapterLocked = false)
		{
		}

		private void SetAppearAnimation()
		{
		}

		private static string GetSkinName(CampaignDifficultyMode mode)
		{
			return null;
		}
	}
}
