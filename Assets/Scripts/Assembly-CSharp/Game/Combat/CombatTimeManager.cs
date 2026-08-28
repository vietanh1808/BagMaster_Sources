using UnityEngine;

namespace Game.Combat
{
	public class CombatTimeManager : MonoBehaviour
	{
		private static CombatTimeManager _instance;

		[SerializeField]
		private float _combatTimeScale;

		public static CombatTimeManager Instance => null;

		public float CurrentEffectTimeScale { get; private set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void ResetEffectTimeScale()
		{
		}

		public void UpdateTimeScale(bool combat)
		{
		}

		public void SetCombatTimeScale(float value, bool inCombat)
		{
		}

		public void SetCombatTimeScaleNotUpdate(float value)
		{
		}
	}
}
