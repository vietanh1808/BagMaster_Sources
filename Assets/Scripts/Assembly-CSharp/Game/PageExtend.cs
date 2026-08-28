using UnityEngine;
using UnityScreenNavigator.Runtime.Core.Page;

namespace Game
{
	public class PageExtend : Page
	{
		[SerializeField]
		private string _trackingScreen;

		public override void DidPushEnter()
		{
		}
	}
}
