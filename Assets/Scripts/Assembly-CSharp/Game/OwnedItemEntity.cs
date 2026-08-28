using System;
using Game.Combat;
using Newtonsoft.Json;

namespace Game
{
	[Serializable]
	public sealed class OwnedItemEntity : IEquatable<OwnedItemEntity>, IEffectGear, IStatOwner
	{
		[JsonIgnore]
		private NonBehaviourStatHolder _statHolder;

		public Guid UniqueId { get; private set; }

		public int ItemId { get; private set; }

		[JsonIgnore]
		public IStatHolder StatHolder => null;

		public OwnedItemEntity(int itemId)
		{
		}

		public T GetResourceEntity<T>() where T : ResourceEntity
		{
			return null;
		}

		public T GetGear<T>() where T : GearData
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(OwnedItemEntity other)
		{
			return false;
		}

		public static bool operator ==(OwnedItemEntity a, OwnedItemEntity b)
		{
			return false;
		}

		public static bool operator !=(OwnedItemEntity a, OwnedItemEntity b)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
