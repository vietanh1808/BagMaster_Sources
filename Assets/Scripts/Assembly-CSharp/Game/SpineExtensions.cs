using DG.Tweening;
using Spine.Unity;
using UnityEngine;

namespace Game
{
	public static class SpineExtensions
	{
		public static Tweener DoColor(this SkeletonGraphic skeletonGraphic, in Color target, float duration)
		{
			return null;
		}

		public static bool TrySetSkin(this SkeletonGraphic skeletonGraphic, string skinName)
		{
			return false;
		}

		public static void SetSkin(this SkeletonGraphic skeletonGraphic, string skinName)
		{
		}
	}
}
