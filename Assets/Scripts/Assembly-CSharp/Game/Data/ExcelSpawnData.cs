using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelSpawnData
	{
		public int Spawn_Group_ID;

		public int Spawn_ID;

		public int Monster_ID;

		public string Portal_ID;

		public int Distribution_type;

		public int Group_Unit;

		public int Group_count;

		public float Group_interval;

		public int Monster_Level;

		public float Start_time;

		public float End_Time;

		public float Loop_Interval;

		public float AtkModifier;

		public float HpModifier;

		public float SpawnXOffsetPerUnit;

		public float SpawnRandomYFactor;
	}
}
