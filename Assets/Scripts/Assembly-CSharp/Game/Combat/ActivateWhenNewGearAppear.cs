using System;
using System.Collections.Generic;

namespace Game.Combat
{
	public class ActivateWhenNewGearAppear : SafeDisposeable, ISkillComponent, IHasGearConditionComponent
	{
		private int _targetId;

		private string[] _tags;

		private bool _includeSelf;

		private bool _targetNewGearOnly;

		private IDisposable _listener;

		private List<Gear> _targets;

		public SimpleSkill Skill { get; private set; }

		public ActivateWhenNewGearAppear(SimpleSkill skill)
		{
		}

		private bool ValidaGear(Gear gear)
		{
			return false;
		}

		public bool IsTarget(Gear gear)
		{
			return false;
		}

		private void OnNewGearAppear(Gear gear)
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
