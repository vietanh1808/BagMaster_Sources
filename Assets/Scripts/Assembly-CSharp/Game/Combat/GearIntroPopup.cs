using System;
using System.Collections.Generic;
using Game.Combat.SkillSystem;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Combat
{
	public class GearIntroPopup : MonoBehaviour
	{
		[Header("UI References")]
		[SerializeField]
		private Image _iconImg;

		[SerializeField]
		private TextMeshProUGUI _nameText;

		[SerializeField]
		private TextMeshProUGUI _descText;

		[SerializeField]
		private TextMeshProUGUI _synercyText;

		[SerializeField]
		private Image _synercyPreviewImg;

		[SerializeField]
		private List<GameObject> _synercyItems;

		[SerializeField]
		private Vector2 _synercyItemSpacing;

		[SerializeField]
		private Animator _animator;

		[SerializeField]
		private IntroSkillSlot _introSkillSlot;

		[SerializeField]
		private TextMeshProUGUI _skillName;

		[SerializeField]
		private TextMeshProUGUI _skillDescirption;

		[SerializeField]
		private TextMeshProUGUI _skillDescription_Disabled;

		[SerializeField]
		private GameObject SynergyObject;

		[SerializeField]
		private GameObject SynergyObjectDisabled;

		[SerializeField]
		private GearIntroImageDimension _imageDimensions;

		[Header("Stats")]
		[SerializeField]
		private GearInfoProperty _cooldownProperty;

		[SerializeField]
		private GearInfoProperty _critRateProperty;

		[SerializeField]
		private GearInfoProperty _attackProperty;

		[SerializeField]
		private GearInfoProperty _healProperty;

		[SerializeField]
		private GearInfoProperty _shieldProperty;

		[Header("Fly to Gear")]
		[SerializeField]
		private GameObject _flyGearPrefab;

		[SerializeField]
		private float _flyDuration;

		[SerializeField]
		private GameObject _endFlyVfx;

		[Header("Events")]
		public UnityEvent<GearData> OnGearDataUpdatedEvent;

		[Header("Runtime")]
		public Gear Gear;

		public SkillData Skill;

		public Action OnEndPopping;

		public Action OnStartPopping;

		public void UpdateInfo(GearData gearData)
		{
		}

		[Obsolete("Out Of Date")]
		public void UpdateStats(Gear gear)
		{
		}

		private IEffect CreateEffectCreationParams(Gear gear, EffectData effectData)
		{
			return null;
		}

		[Obsolete("Out Of Date")]
		public void GenerateSynercy()
		{
		}

		public void Next()
		{
		}

		public void InvokeOnPopped()
		{
		}
	}
}
