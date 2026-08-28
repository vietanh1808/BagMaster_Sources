using System;
using System.Collections.Generic;
using Game.Combat.SkillSystem;
using Game.Constant;
using UnityEngine;

namespace Game.Combat
{
	[Serializable]
	public class GearData
	{
		public int Id;

		public bool IsActive;

		public GameObject Template;

		public SkillData ActiveSkillData;

		public SkillData[] PassiveSkillData;

		public string IconName;

		public string SpriteFloatName;

		public string Name;

		public string Description;

		public GearGridData GridData;

		public Rarity Rarity;

		public string AtkSpriteName;

		public int SellGold;

		public int SpawnTime;

		public bool ShowInAdReward;

		public float GearPower;

		public int UnlockedFromChapter;

		public int UnlockedFromPlayerLevel;

		public GearData MergeTo;

		public GearData MergeFrom;

		public int MergeLevel;

		public int DeclaredGroupId;

		public int GroupId;

		public int LayoutPoint;

		public int AppearCondition;

		public string[] Tags;

		public bool IsThrowType;

		public Elemental Elemental;

		public bool IdleAimTarget;

		public bool HasRecoil;

		public Vector2 DraggingOffset;

		public DefaultSoundConfig.SoundData PressSfx;

		public DefaultSoundConfig.SoundData FlyingGearLandSfx;

		public DefaultSoundConfig.SoundData PlaceSfx;

		public AudioClip MergeAppearSfx;

		public int SupportUiOrder;

		public string MergeAppearVfxName;

		public float RecycleValue;

		public List<WeightData> originalWeightData;

		public List<WeightData> WeightData;

		public int MaxWeightCount;

		public float IconAngleOnInfoPopup;

		public string SynercyDescription;

		public string SkillIconName;

		public Vector2Int MarkPosition;

		public string SynercyPreview;

		public Vector2 IconTopPosition;

		public string Display_Skill5Icon;

		public string Display_Skill5SkillID;

		public int UpgradeID;

		public int MasteryPoint;

		public string VideoPreviewPath;

		public string UiIconPath;

		public int UpgradeLevel;

		public GearEquipState gearState;

		public string LocalizedName => null;

		public string LocalizedDescription => null;

		public string LocalizedSynercyDescription => null;

		public int ProgressLevel => 0;

		public bool HasActiveSkill => false;

		public int MasteryId => 0;

		public void SetWeight(List<WeightData> newWeight)
		{
		}

		public int CurrentGearUpgradeId()
		{
			return 0;
		}

		public GameObject CreateInstance(Unit owner, bool increaseMastery = true)
		{
			return null;
		}

		public GameObject CreateGear(Unit owner)
		{
			return null;
		}

		public string FormatStringWithData(string str)
		{
			return null;
		}

		public bool IsWeapon()
		{
			return false;
		}
	}
}
