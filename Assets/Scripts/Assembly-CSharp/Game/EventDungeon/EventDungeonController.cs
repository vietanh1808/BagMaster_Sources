using System;
using Game.Combat;
using UnityEngine;

namespace Game.EventDungeon
{
	public class EventDungeonController : DungeonController
	{
		[SerializeField]
		private int overrideEventDungeonId;

		[SerializeField]
		private int overrideEventLevel;

		private EventDungeonUnlockViewState eventDungeonData;

		private IDisposable eventDisposable;

		[SerializeField]
		private bool cheatIncreaseHPAmor;

		private float cheatTimer;

		private float cheatInterval;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void OnGamePrepare(GamePhase phase)
		{
		}

		private void OnTakeDamage(Health health, float hp)
		{
		}
	}
}
