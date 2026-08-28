using Game.Combat.SkillSystem;
using TMPro;
using UnityEngine;

namespace Game.Combat
{
	public class GearStats : MonoBehaviour
	{
		public struct StatPair
		{
			public int Value;

			public int ValueWithoutBuff;
		}

		public float Power;

		public float Dps;

		public float Hps;

		public float Sps;

		public float Cooldown;

		public float PowerWithoutBuff;

		public float DpsWithoutBuff;

		public float HpsWithoutBuff;

		public float SpsWithoutBuff;

		public float CooldownWithoutBuff;

		[Header("UI")]
		[SerializeField]
		private GameObject _cpUi;

		[SerializeField]
		private TextMeshPro _cpText;

		[SerializeField]
		private TextMeshPro _cpIncreaseText;

		private Gear _gear;

		private float _initialCpScale;

		private StatPair _bounce;

		private StatPair _pierce;

		private StatPair _consecutive;

		private StatPair _spread;

		public GameObject CpUi => null;

		public Gear Gear => null;

		public float InitialCpScale => 0f;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void PositionCpUi()
		{
		}

		public void Calculate()
		{
		}

		private void CreateEffects(EffectData effectData, out IEffect withBuff, out IEffect withoutBuff, Stat.GetValueCustomDelegate modifierFilter)
		{
			withBuff = null;
			withoutBuff = null;
		}

		public float CalculateDps(Stat.GetValueCustomDelegate modifierFilter)
		{
			return 0f;
		}

		private bool NotBuff(StatModifier statModifier)
		{
			return false;
		}

		private void LoadSupportStats()
		{
		}

		private StatPair GetStatValue(StatName statName)
		{
			return default;
		}

		private int GetStatValue(StatName statName, Stat.GetValueCustomDelegate modifierFilter)
		{
			return 0;
		}

		private void CalculatePower()
		{
		}

		public void ShowCpUi(bool show)
		{
		}

		public void ScaleTextUp(float value)
		{
		}

		public void UpdateCpText(float value, float increasedValue)
		{
		}

		public void SetAlphaCpText(float value, float duration)
		{
		}

		public void ReduceAlphaCpText(float value, float min, float duration)
		{
		}

		public void IncreaseSortingOrderText(int value)
		{
		}
	}
}
