using System.Collections.Generic;
using Game.AssetManager;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class EffectController : MonoBehaviour
	{
		public float Intensity;

		private EffectShareData _effectShareData;

		private List<EffectData> _effectDatas;

		private List<IEffect> _createdEffect;

		private Dictionary<string, PrefabAddressable> _hitVfxLoaders;

		public EffectShareData EffectShareData => null;

		public IReadOnlyList<EffectData> EffectDatas => null;

		public void Initialize(List<EffectData> effectDatas)
		{
		}

		private void InitializeHitVfxLoaders(List<EffectData> effectDatas)
		{
		}

		public EffectData AddEffectData(EffectData effectData)
		{
			return null;
		}

		public float GetIncomingDamage()
		{
			return 0f;
		}

		public void Execute(IEffectTarget target)
		{
		}

		public void Execute(IReadOnlyList<EffectData> effectDatas, IEffectTarget target, List<IEffect> existingEffects = null)
		{
		}

		public EffectCreationParams CreateEffectParam(EffectData effectData, IEffectTarget target)
		{
			return default;
		}

		private void CreateEffectHitVfx(IEffectTarget effectTarget, PrefabAddressable loader)
		{
		}

		private float GetAoeMultiplierBonus()
		{
			return 0f;
		}

		public void Cancel()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
