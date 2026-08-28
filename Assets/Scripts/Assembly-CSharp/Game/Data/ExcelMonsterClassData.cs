using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelMonsterClassData
	{
		public int ID;

		public string Name;

		public float HP_Scale;

		public float Atk_Scale;

		public float Res_Scale;

		public float Atk_Interval_scale;

		public float Step_Speed_Modifier;
	}
}
