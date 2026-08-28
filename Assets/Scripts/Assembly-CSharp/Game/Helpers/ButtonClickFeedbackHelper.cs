using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Helpers
{
	[RequireComponent(typeof(MMF_Player))]
	public class ButtonClickFeedbackHelper : MonoBehaviour
	{
		[SerializeField]
		private Button button;

		private MMF_Player player;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void PlayEffect()
		{
		}
	}
}
