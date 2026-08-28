using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class EnviromentSkillManager : MonoBehaviour, IEffectGear, IStatOwner
	{
		[SerializeField]
		private List<SimpleSkill> _skills;

		private Unit _casterUnit;

		public IStatHolder StatHolder { get; set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void UpdateSkillsByCurrentLevel()
		{
		}

		public void UpdateSkills(int[] skillIds)
		{
		}

		public void Cancel()
		{
		}
	}
}
