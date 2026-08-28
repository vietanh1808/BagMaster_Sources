using UnityEngine;

namespace Game.Combat
{
	public class PausePopup : MonoBehaviour
	{
		public static void Pause()
		{
		}

		public static void Pause(float lerpDuration, float maxiumDuration = 1f)
		{
		}

		public static void UnPause()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void SendLeaveGameEvent()
		{
		}

		public void ReturnHome()
		{
		}
	}
}
