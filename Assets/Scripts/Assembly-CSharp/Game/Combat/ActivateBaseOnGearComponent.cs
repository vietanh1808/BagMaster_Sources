using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class ActivateBaseOnGearComponent : SafeDisposeable, IHasGearConditionComponent, ISkillComponent, IFetchWhenBagGridChanged, IHasStartCombatEffect, ICancelWhenLeaveBagComponent
	{
		protected IReadOnlyList<IEffectTarget> _targets;

		protected int _targetId;

		protected string[] _tags;

		protected CompareType _compareType;

		protected int _compareNumber;

		protected bool _includeSelfInCompare;

		protected int _triggerNumber;

		protected bool _includeSelfInTrigger;

		public SimpleSkill Skill { get; protected set; }

		public int Order => 0;

		public IReadOnlyList<IEffectTarget> Targets => null;

		public ActivateBaseOnGearComponent(SimpleSkill skill)
		{
		}

		public virtual void Fetch(IReadOnlyDictionary<Vector2Int, IBagGridItem> gridMap, IReadOnlyDictionary<IBagGridItem, List<Vector2Int>> gearPlacementPoints)
		{
		}

		public virtual void Cancel()
		{
		}

		public bool IsTargetSelf()
		{
			return false;
		}

		public bool IsTarget(Gear gear)
		{
			return false;
		}

		protected override void DoDispose()
		{
		}
	}
}
