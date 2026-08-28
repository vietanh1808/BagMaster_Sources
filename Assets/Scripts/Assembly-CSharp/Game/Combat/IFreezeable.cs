namespace Game.Combat
{
	public interface IFreezeable
	{
		bool IsFrozen { get; }

		bool CanBeFrozen { get; }

		void Freeze(object source, float duration);

		void Unfreeze(object source = null);
	}
}
