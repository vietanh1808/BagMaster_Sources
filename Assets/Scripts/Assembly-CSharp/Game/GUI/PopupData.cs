using System;
using UnityEngine;

namespace Game.GUI
{
	[Serializable]
	public struct PopupData
	{
		public PopupType Type;

		public string FeatureName;

		public Sprite Icon;

		public bool ShowFTUE;

		public int Priority;

		public string EventId;

		public string EventBannerName;

		public Action OnClosed;

		public Transform ReturnPosition;

		public object Parameter;

		public string IconName;
	}
}
