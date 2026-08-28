using System;
using Game.CodedAnimation;
using Game.Combat.SkillSystem;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Combat
{
	public class GearLevel5Popup : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _iconTransform;

		[SerializeField]
		private TextMeshProUGUI _descText;

		[SerializeField]
		private TextMeshProUGUI _synercyDescText;

		[SerializeField]
		private float _flyOutDuration;

		[SerializeField]
		private float _flyOutJumpPower;

		[SerializeField]
		private float _recoveryDuration;

		[SerializeField]
		private Vector3 _startScale;

		[SerializeField]
		private UnityEvent _onGearDropEvent;

		[SerializeField]
		private TextMeshProUGUI _itemName;

		[SerializeField]
		private IntroSkillSlot _introSkillSlot;

		[SerializeField]
		private TextMeshProUGUI _skillName;

		[SerializeField]
		private TextMeshProUGUI _skillDescirption;

		[SerializeField]
		private GameObject _skillBanner;

		[SerializeField]
		private IntroSkillSlot _transitionSkillSlot;

		[SerializeField]
		private TextMeshProUGUI _transitionSkillName;

		[SerializeField]
		private TextMeshProUGUI _transitionSkillDescirption;

		[SerializeField]
		private GameObject _transitionSkillBanner;

		[SerializeField]
		private GameObject _dontHaveSkillBanner;

		[SerializeField]
		private TextMeshProUGUI _gearSynergyDescription;

		[SerializeField]
		private GameObject synergyInfoObject;

		[SerializeField]
		private GameObject synergyInfoObjectDisabled;

		[SerializeField]
		private Image _synercyPreviewImg;

		[SerializeField]
		private Animator _vfxAnimator;

		[SerializeField]
		private DotweenAnimation1 _BounceAnimation;

		[Header("Events")]
		public UnityEvent<GearData> OnGearDataUpdatedEvent;

		[Header("Runtime")]
		private Gear _gear;

		public SkillData Skill;

		private Action _onPopComplete;

		private SpriteRenderer _animationRenderer;

		public const string PopupName = "Modal_GearLevel5Popup";

		private void Start()
		{
		}

		public void UpdateInfo(Gear gear, Action onPopComplete)
		{
		}

		public void CustomPop()
		{
		}

		public void GearFlyToPosition()
		{
		}

		public UnityEvent PlayFlashVFX()
		{
			return null;
		}
	}
}
