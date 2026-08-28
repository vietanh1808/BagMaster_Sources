using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class MeleeController : MonoBehaviour
	{
		[SerializeField]
		private bool _canSimulationEffect;

		private List<ProjectileBehaviour> _behaviours;

		public ProjectileOptions Options { get; set; }

		public bool CanSimulationEffect => false;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void Setup(ProjectileEvents events)
		{
		}

		public void Cancel()
		{
		}
	}
}
