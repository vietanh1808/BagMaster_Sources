using System;

namespace Game
{
	[Serializable]
	public struct SerializableResourceData
	{
		public int Id;

		public int Value;

		public SerializableResourceData(int id, int number)
		{
			Id = 0;
			Value = 0;
		}

		public ResourceRequireData ToResourceRequireData()
		{
			return null;
		}

		public static implicit operator ResourceRewardData(SerializableResourceData data)
		{
			return null;
		}

		public static implicit operator SerializableResourceData(ResourceRewardData data)
		{
			return default;
		}

		public static implicit operator ResourceRequireData(SerializableResourceData data)
		{
			return null;
		}

		public static implicit operator SerializableResourceData(ResourceRequireData data)
		{
			return default;
		}
	}
}
