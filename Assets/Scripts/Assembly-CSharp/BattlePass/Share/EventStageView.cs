using TMPro;
using UnityEngine;

namespace BattlePass.Share
{
	public class EventStageView : MonoBehaviour
	{
		[SerializeField]
		private GameObject lockObject;

		[SerializeField]
		private GameObject unlockObject;

		[SerializeField]
		private TextMeshProUGUI[] texts;

		public void Init(bool unlocked, int stage)
		{
		}
	}
}
