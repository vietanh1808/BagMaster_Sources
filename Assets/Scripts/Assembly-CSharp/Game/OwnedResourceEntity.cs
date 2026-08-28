using System;
using Newtonsoft.Json;

namespace Game
{
	[Serializable]
	public sealed class OwnedResourceEntity
	{
		[JsonIgnore]
		public Action<int> OnValueChanged;

		private int _value;

		public int ResourceId { get; private set; }

		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public OwnedResourceEntity(int resId)
		{
		}

		[JsonConstructor]
		public OwnedResourceEntity(int resId, int value)
		{
		}

		public ResourceEntity GetResourceEntity()
		{
			return null;
		}

		public T GetResourceEntity<T>() where T : ResourceEntity
		{
			return null;
		}
	}
}
