using UnityEngine;

namespace Game.Combat
{
	[DefaultExecutionOrder(-1)]
	public class DungeonController : MonoBehaviour
	{
		[Header("Debug")]
		[SerializeField]
		private int overrideCampaignId;

		[SerializeField]
		private int overrideWave;

		[SerializeField]
		private bool loadSave;

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void CheatInstantLose()
		{
		}
	}
}
