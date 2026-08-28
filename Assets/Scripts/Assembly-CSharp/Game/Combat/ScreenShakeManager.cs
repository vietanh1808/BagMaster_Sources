using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Combat
{
	public class ScreenShakeManager : MonoBehaviour
	{
		[SerializeField]
		private MMF_Player[] _smallShakeFeedbacks;

		public static ScreenShakeManager Instance { get; private set; }

		private void Awake()
		{
		}

		public void Play(int index)
		{
		}
	}
}
