using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	[DefaultExecutionOrder(-4)]
	public class CombatSaveManager : MonoBehaviour
	{
		[Header("Gears")]
		[SerializeField]
		private CounterDropArea _counterGearArea;

		[SerializeField]
		private BenchDropArea _benchGearArea;

		[Header("Bag")]
		[SerializeField]
		private BagLayoutManager _layoutManager;

		[SerializeField]
		private RecyleDropArea _recycleArea;

		[Header("Phases")]
		[SerializeField]
		private RewardPhase _rewardPhase;

		[SerializeField]
		private RewardPhaseTraitShop _buffShop;

		[SerializeField]
		private RewardPhaseGearChest _gearChest;

		private readonly List<CombatSaveData.BuffData> _selectedBuffs;

		private static CombatSaveManager _instance;

		private static PlayerInfo PInfo => null;

		public static bool HasSave => false;

		public static CombatSaveData NormalSave => null;

		public static bool HasNormalSave => false;

		public static CombatSaveData DefeatSave => null;

		public static bool HasDefeatSave => false;

		public static CombatSaveManager Instance => null;

		public static CombatSaveData Load()
		{
			return null;
		}

		public static void Log(string msg)
		{
		}

		public static void ClearSave(bool clearDefeatData = true)
		{
		}

		public static void ClearNormalDataAndWriteDefeatData()
		{
		}

		private void Awake()
		{
		}

		public void Save()
		{
		}

		public void CheckSaveDefeatData(CombatSaveData modelData = null)
		{
		}

		public void SaveDefeatData(CombatSaveData modelData = null)
		{
		}

		public CombatSaveData CreateSaveData()
		{
			return null;
		}

		private void SaveCombatLevelBuffs(CombatSaveData saveData)
		{
		}

		public static void SaveCampaignProgress(int campaignId, int waveReached)
		{
		}

		private void SaveGears(CombatSaveData saveData)
		{
		}

		private void SaveActiveSkills(CombatSaveData saveData)
		{
		}

		private void SaveBag(CombatSaveData saveData)
		{
		}

		private void SaveBuffShop(CombatSaveData saveData)
		{
		}

		private void SaveGearChest(CombatSaveData saveData)
		{
		}

		private void SaveRecycle(CombatSaveData saveData)
		{
		}

		private void SaveBench(CombatSaveData saveData)
		{
		}

		private void SaveRewarded(CombatSaveData saveData)
		{
		}

		public void OnSelectedBuff(BuffData buff, int? wave = null)
		{
		}
	}
}
