using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public abstract class BaseEffectImp : MonoBehaviour
	{
		public float EffectScale;

		public EffectShareData ShareData { get; set; }

		public virtual float EffDuration { get; }

		public BaseEffectImp Before { get; set; }

		public abstract void Initialize(EffectParams effectParams);

		public virtual void ProjectileCreated(GameObject target)
		{
		}

		public virtual void HitSimulate(GameObject target)
		{
		}

		public virtual void PreExecute()
		{
		}

		public abstract void Execute(GameObject target);

		public virtual void Cancel()
		{
		}
	}
}
