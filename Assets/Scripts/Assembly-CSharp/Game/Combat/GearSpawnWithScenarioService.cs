using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Game.Combat
{
	public class GearSpawnWithScenarioService : IGearSpawnService
	{
		[CompilerGenerated]
		private Action<Gear> m_OnGearCreatedEvent;

		private readonly Unit _gearOwner;

		private readonly Queue<GearData> _scenario;

		public event Action<Gear> OnGearCreatedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public GearSpawnWithScenarioService(Unit gearOwner)
		{
		}

		public void Add(GearData gearData)
		{
		}

		public void Remove(GearData gearData)
		{
		}

		public List<Gear> Spawn()
		{
			return null;
		}

		public Gear CreateGearWithID(GearData gearData)
		{
			return null;
		}
	}
}
