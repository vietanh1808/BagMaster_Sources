using System.Collections.Generic;
using UnityEngine;

namespace Game.GUI
{
	public static class VisibleUiExtensions
	{
		public static void UpdateChildrenVisibleState(this UiBehaviour container, IEnumerable<IVisibleUi> children, bool shouldTriggerEvent = true, in Paddings visiblePaddings = default(Paddings))
		{
		}

		public static void UpdateChildrenVisibleState(this RectTransform container, IEnumerable<IVisibleUi> children, bool shouldTriggerEvent = true, in Paddings visiblePaddings = default(Paddings))
		{
		}

		public static void UpdateChildVisibleState(this IVisibleUi container, IVisibleUi child, bool shouldTriggerEvent = true, in Paddings visiblePaddings = default(Paddings))
		{
		}

		public static void UpdateChildVisibleState(this RectTransform container, IVisibleUi child, bool shouldTriggerEvent = true, in Paddings visiblePaddings = default(Paddings))
		{
		}

		public static void ForceLayoutRebuild(this IVisibleUi visibleUi)
		{
		}

		public static void ForceUpdateRectTransforms(this IVisibleUi visibleUi)
		{
		}

		public static bool IsVisibleInside(this IVisibleUi visibleUi, RectTransform container)
		{
			return false;
		}

		public static bool IsVisibleInside(this IVisibleUi visibleUi, IVisibleUi container)
		{
			return false;
		}
	}
}
