using Game.Combat;
using TMPro;
using UnityEngine;

namespace Game.DailyEvent
{
	public class EventDungeonInfoInGameplay : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _dungeonNameTxt;

		[SerializeField]
		private TextMeshProUGUI _levelTxt;

		[SerializeField]
		private TextMeshProUGUI _roundTxt;

		private Campaign Campaign => null;

		private int CurrentRound => 0;

		private int LastRound => 0;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
