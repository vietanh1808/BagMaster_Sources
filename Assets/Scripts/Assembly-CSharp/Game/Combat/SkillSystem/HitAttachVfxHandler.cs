using Game.Tools;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class HitAttachVfxHandler : MonoBehaviour
	{
		private OnTimeActionOnDisable _notifier;

		public void Initialize(MonoBehaviour target, float duration = 0f)
		{
		}

		private void OnTargetDisabled(GameObject _)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
