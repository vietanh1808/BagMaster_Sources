using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class MonsterFrozenController : MonoBehaviour, IFreezeable
	{
		public float Resistance;

		public float Cooldown;

		private Unit _unit;

		private StatusManager _statusManager;

		private IStatHolder _statHolder;

		private float _lastFreezeTime;

		private List<StatusData> _activeStatuses;

		public bool IsFrozen => false;

		public bool CanBeFrozen => false;

		private void Awake()
		{
		}

		public void Freeze(object source, float duration)
		{
		}

		protected virtual StatusData CreateStatBuffStatus(object source, float duration)
		{
			return null;
		}

		public void Unfreeze(object source = null)
		{
		}

		private void UpdateAnimation()
		{
		}
	}
}
