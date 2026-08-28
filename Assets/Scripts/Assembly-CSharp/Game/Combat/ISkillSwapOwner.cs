using Game.Combat.SkillSystem;

namespace Game.Combat
{
	public interface ISkillSwapOwner
	{
		void Swap(SkillData from, SkillData to);

		void Revert(SkillData to);
	}
}
