using Newtonsoft.Json;
using UnityEngine;

namespace Game
{
	public struct FloatArray
	{
		public float[] Values;

		[JsonIgnore]
		public Vector3 Vector3 => default;

		public FloatArray(params float[] values)
		{
			Values = null;
		}

		public FloatArray(Vector3 vector3)
		{
			Values = null;
		}
	}
}
