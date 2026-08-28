using System;
using System.Runtime.CompilerServices;
using Game;
using Game.Combat;
using UnityEngine;

namespace Combat.Dungeon
{
	public class ExpManager : MonoBehaviour, IExpManager
	{
		[SerializeField]
		private TraitShopView _traitShopPrefab;

		private Unit _playerUnit;

		private IBuffManager _buffManager;

		private BuffPool _currentBuffPool;

		private PlayerInfo _playerInfo;

		[CompilerGenerated]
		private Action<int> m_OnMilestoneReached;

		public int TotalExp
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public int CurrentMilestone { get; private set; }

		public ExpMilestoneGroup MilestoneGroup { get; private set; }

		private int TotalRequiredExp => 0;

		public event Action<int> OnMilestoneReached
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private static ExpMilestoneGroup GetExpMilestoneGroup(Campaign campaign)
		{
			return null;
		}

		public void Init(Unit playerUnit, Campaign campaign = null, PlayerInfo playerInfo = null)
		{
		}

		public void Init(Unit playerUnit, ExpMilestoneGroup milestoneGroup, PlayerInfo playerInfo = null)
		{
		}

		public void ForceIncreaseMilestone()
		{
		}

		private void OnExpGained(int totalExp)
		{
		}

		private void IncreaseMilestone()
		{
		}

		private void OpenTraitShop()
		{
		}

		private void OpenTraitShop(BuffPool buffPool)
		{
		}

		private static Vector3 GetUiPosition(in Vector3 worldPosition)
		{
			return default;
		}

		private void OnDestroy()
		{
		}
	}
}
