using MoreMountains.Feedbacks;
using MoreMountains.Tools;
using UnityEngine;

namespace Game.Combat
{
	public class GearLuckyEffect : MonoBehaviour, MMEventListener<GearLuckyEvent>, MMEventListenerBase
	{
		[SerializeField]
		private MMF_Player _onTriggerFeedback;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnMMEvent(GearLuckyEvent eventData)
		{
		}
	}
}
