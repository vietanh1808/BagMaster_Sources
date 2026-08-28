using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class GlobalTargetManager : MonoBehaviour
	{
		public Team TargetTeam;

		public ListUnits ListUnits;

		public Transform BaseAnchor;

		public float FetchInterval;

		private float _nextFetch;

		public static Dictionary<Team, GlobalTargetManager> Instances { get; private set; }

		public Transform Anchor { get; private set; }

		public IEnumerable<Unit> TargetAlives { get; private set; }

		public IOrderedEnumerable<Unit> TargetsOrderByDistance { get; private set; }

		public IOrderedEnumerable<Unit> TargetsOrderByHp { get; private set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void ChangeAnchor(Transform newAnchor)
		{
		}

		public IEnumerable<Unit> GetTargets(FilterMethod method, int number, float range, Transform rangeAnchor)
		{
			return null;
		}

		private void Fetch()
		{
		}

		private void SortDistance()
		{
		}
	}
}
