using System;
using System.Collections.Generic;

namespace Game.Combat
{
	public interface IGearSpawnService
	{
		event Action<Gear> OnGearCreatedEvent;

		void Add(GearData gearData);

		void Remove(GearData gearData);

		List<Gear> Spawn();

		Gear CreateGearWithID(GearData gearData);
	}
}
