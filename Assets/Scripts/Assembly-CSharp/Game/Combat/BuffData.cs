using System;
using System.Collections.Generic;
using Game.Combat.SkillSystem;
using Game.Constant;
using UnityEngine;

namespace Game.Combat
{
	public class BuffData
	{
		public int Id;

		public List<SkillData> SkillDatas;

		public string IconName;

		public string Name;

		public string Description;

		public int Price;

		public int Level;

		public int Weight;

		public int GroupId;

		public Rarity Rarity;

		public AudioClip SelectedSfx;

		public bool DisplayOnAcquired;

		public int DisplayOrder;

		[Obsolete("Use CampaignIDUnlock")]
		public int LevelIDUnlock;

		public int CampaignIDUnlock;

		public float DpsMod;

		public string[] BuffGearTags;

		public string SynergyText;

		public bool InMainCampaign;

		public bool InDungeon;

		public string LocalizedName => null;

		public string LocalizedDescription => null;

		public string LocalizedSynergyText => null;

		public bool IsUnlocked => false;

		public float GetSortingOrder()
		{
			return 0f;
		}

		public List<SimpleSkill> CreateSkillInstances(Unit owner)
		{
			return null;
		}

		public void Activate(Unit player)
		{
		}
	}
}
