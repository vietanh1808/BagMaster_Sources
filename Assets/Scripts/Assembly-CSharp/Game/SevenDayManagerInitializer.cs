using System.Collections.Generic;
using Game.SevenDayQuest;
using UnityEngine;

namespace Game
{
	public class SevenDayManagerInitializer : MonoBehaviour
	{
		private List<SevenDayEventConfig> _createdEvents;

		private List<SevenDayEventConfig> _notCreatedEvents;

		private float _lastCheckRealtime;

		private const float CheckInterval = 60f;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private bool IsEventRunning(SevenDayEventConfig config)
		{
			return false;
		}
	}
}
