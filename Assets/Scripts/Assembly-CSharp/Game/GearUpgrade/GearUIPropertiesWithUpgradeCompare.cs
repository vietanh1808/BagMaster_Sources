using Game.Combat;
using Game.Combat.SkillSystem;
using UnityEngine;

namespace Game.GearUpgrade
{
	public class GearUIPropertiesWithUpgradeCompare : MonoBehaviour
	{
		[SerializeField]
		private GearUIProperty _cooldownProperty;

		[SerializeField]
		private GearUIProperty _critRateProperty;

		[SerializeField]
		private GearUIProperty _attackProperty;

		[SerializeField]
		private GearUIProperty _healProperty;

		[SerializeField]
		private GearUIProperty _shieldProperty;

		[SerializeField]
		private float _displayMod;

		[Header("Runtime")]
		[SerializeField]
		private int _gearLevel;

		[SerializeField]
		private bool _isMaxLevel;

		protected GearData _gearData;

		private GearUpgradeData _currentUpgradeData;

		private GearUpgradeData _nextUpgradeData;

		private PlayerInfo PInfo => null;

		public void UpdateInfo(GearData gearData)
		{
		}

		private SkillData GetSkillData()
		{
			return null;
		}

		private void UpdateCooldown(string text)
		{
		}

		private void UpdateCooldown()
		{
		}

		public void UpdatePropertyInPercent(GearUIProperty property)
		{
		}

		private string GetCurrentStatInPercent()
		{
			return null;
		}

		private string GetNextStatInPercent()
		{
			return null;
		}

		private void UpdateAttack(EffectData effectData, float attackMod)
		{
		}

		protected virtual void UpdateHeal(EffectData effectData)
		{
		}

		protected virtual void UpdateShield(EffectData effectData)
		{
		}

		private float GetStat(StatName statName)
		{
			return 0f;
		}

		private float GetStatAtUpgrade(GearUpgradeData upgradeData, StatName statName, float baseValue)
		{
			return 0f;
		}

		private float GetCurrentLevelStat(StatName statName, float baseValue)
		{
			return 0f;
		}

		private float GetNextLevelStat(StatName statName, float baseValue)
		{
			return 0f;
		}

		private void DisableAllProperties()
		{
		}
	}
}
