using BattlePass.Model;
using Game;
using Game.Data;
using Game.QuestSystem;
using UnityEngine;

namespace BattlePass.Views
{
	public class BattlePassListener : MonoBehaviour
	{
		private struct KeyTeam
		{
			public readonly QuestDefines defines;

			public readonly string target;

			public KeyTeam(QuestDefines defines, string target)
			{
				this.defines = QuestDefines.Empty;
				this.target = null;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		public static int PendingResourceSpendAmount;

		private static float lastTimeSavePayload;

		private EventEntry eventEntry;

		private bool hasRegister;

		private void Awake()
		{
		}

		private void RefreshEvent(string eventId)
		{
		}

		private void RegisterExtraPointChanged()
		{
		}

		private void RegisterQuestChanged()
		{
		}

		private void CheckAndTrackLevelUp(BattlePassPayload payload, BattlePassBundleData bundleData, int point, int amount)
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private static void ForceSaveData()
		{
		}
	}
}
