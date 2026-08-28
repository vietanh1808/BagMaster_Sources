using UnityEngine;

namespace Game.Combat
{
	public abstract class EnemyState : MonoBehaviour
	{
		protected EnemyController Controller { get; private set; }

		public void Init(EnemyController controller)
		{
		}

		public virtual void EnterState()
		{
		}

		public virtual void UpdateState(float dt)
		{
		}

		public virtual void ExitState()
		{
		}
	}
}
