using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	public class SimpleResourceRewardViewList : MonoBehaviour
	{
		[SerializeField]
		private List<ResourceView> _resourceViews;

		public void UpdateInfo(List<ResourceRewardData> rewards)
		{
		}
	}
}
