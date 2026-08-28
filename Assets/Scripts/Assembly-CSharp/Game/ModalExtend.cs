using UnityEngine;
using UnityScreenNavigator.Runtime.Core.Modal;

namespace Game
{
	public class ModalExtend : Modal
	{
		[SerializeField]
		private string _trackingScreen;

		public override void DidPushEnter()
		{
		}
	}
}
