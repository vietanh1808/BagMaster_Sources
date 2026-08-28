using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Game;
using MoreMountains.Feedbacks;
using MoreMountains.Tools;
using R3;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
	private class IncommingDamageDate
	{
		public object Source;

		public float Damage;
	}

	[CompilerGenerated]
	private static Action<Health, float> m_onTakeDamage;

	[SerializeField]
	private float _currentHp;

	[SerializeField]
	private float _currentShield;

	[SerializeField]
	private bool _resetCurrentHpAtStart;

	[SerializeField]
	private bool _destroyOnDeath;

	[SerializeField]
	private float _delayToDestroy;

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private MMHealthBar _healthBar;

	[SerializeField]
	private bool _alwaysShowHealBar;

	[SerializeField]
	private Text _hpText;

	[SerializeField]
	private MMF_Player _damagedFeedback;

	[SerializeField]
	private MMF_Player _blockedFeedback;

	[SerializeField]
	private MMF_Player _healFeedback;

	[SerializeField]
	private MMF_Player _gainShieldFeedback;

	[SerializeField]
	private MMF_Player _deathFeedback;

	[SerializeField]
	private bool _useDamageSourcePositionAsOrigin;

	[SerializeField]
	private Vector3 _floatingTextOffset;

	[SerializeField]
	private Vector2 _floatingTextPositionXRandom;

	[SerializeField]
	private Vector3 _floatingTextUiOffset;

	[SerializeField]
	private Vector2 _floatingTextUiPositionXRandom;

	[Header("Floating Text")]
	[SerializeField]
	private TextVisualData _damageTextProfile;

	[SerializeField]
	private ElementalTextColorData _elementalDamageTextColorData;

	[SerializeField]
	private ElementalTextColorData _elementalCriticalDamageTextColorData;

	[SerializeField]
	private DamageTextSpecificData _damageTextSpecificData;

	[SerializeField]
	private TextVisualData _shieldDamageTextProfile;

	[SerializeField]
	private TextVisualData _healTextProfile;

	[SerializeField]
	private TextVisualData _gainShieldTextProfile;

	[SerializeField]
	private TextVisualData _dodgeDamageTextProfile;

	[SerializeField]
	private string _immuneText;

	[SerializeField]
	private float _immuneTextCooldown;

	[SerializeField]
	private string _dodgedText;

	[SerializeField]
	private GameObject _dodgeFloatingTextSource;

	[Header("Be Healed")]
	[SerializeField]
	private bool _showHealText;

	[SerializeField]
	private Transform _healFloatingTextPosition;

	[SerializeField]
	private Vector2 _healFloatingTextPositionXRandom;

	[SerializeField]
	private MMF_Player _lifestealFeedback;

	[Header("Be Shielded")]
	[SerializeField]
	private bool _showShieldText;

	private IStatHolder _statHolder;

	private Collider2D _collider;

	private Subject<Health> _onRevive;

	private Subject<Health> _onDie;

	private Stat _maxHpStat;

	private Stat _maxShieldStat;

	private List<IncommingDamageDate> IncommingDamageDatas;

	private float _hpOffset;

	private int _overrideDamageFontSize;

	private GameObject _playerWallShieldVFX;

	private Tween _deactivePlayerWallTween;

	private float _lastImmuneTextTime;

	public bool CanNotBellow1;

	public bool GodMode { get; set; }

	public Observable<Health> OnRevive => null;

	public Observable<Health> OnDie => null;

	public float MaxHP => 0f;

	public float MaxShield => 0f;

	public float CurrentHP => 0f;

	public float CurrentShield => 0f;

	public MMHealthBar HealthBar => null;

	public Vector2 FloatingTextOffset
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public MMF_Player LifestealFeedback => null;

	public MMF_Player DamagedFeedback => null;

	public MMF_Player DeathFeedback => null;

	public bool IsPlayer { get; private set; }

	public Subject<CommonData> BeShieldEvent { get; private set; }

	public Subject<CommonData> BeHealedEvent { get; private set; }

	public Subject<CommonData> LostHpEvent { get; private set; }

	public static event Action<Health, float> onTakeDamage
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

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void LinkStats(Stat maxHealth, Stat maxShield)
	{
	}

	public float TakeDamage(DamageData damageData)
	{
		return 0f;
	}

	private float ShieldDamage(float damage, Vector2 position, int floatingTextChannel)
	{
		return 0f;
	}

	public void AddIncomingDamage(object source, float damage)
	{
	}

	public void RemoveIncomingDamage(object source)
	{
	}

	public float GetSimulationHp()
	{
		return 0f;
	}

	public float Heal(HealData healData)
	{
		return 0f;
	}

	public float GainShield(ShieldData shieldData)
	{
		return 0f;
	}

	private Vector3 GetDamageFloatingTextPosition(DamageData damageData)
	{
		return default;
	}

	private void CreateDamageFloatingText(DamageData damageData)
	{
	}

	private void CreateDamageShieldFloatingText(DamageData damageData)
	{
	}

	private void CreateHealFloatingText(HealData healData, float healValue)
	{
	}

	private void CreateGainShieldFloatingText(ShieldData shieldData)
	{
	}

	private Vector3 GetFloatingTextPosition(Vector3 origin)
	{
		return default;
	}

	private Vector3 GetFloatingTextUiPosition(Vector3 origin)
	{
		return default;
	}

	public void ResetShield()
	{
	}

	public bool IsAlive()
	{
		return false;
	}

	public void Revive()
	{
	}

	public void SetDeadImmediatly(DamageData damageData)
	{
	}

	public void UpdateHealthBar()
	{
	}

	public void UpdateShieldState(float shieldValue)
	{
	}

	private void Die()
	{
	}

	private void DestroySelf()
	{
	}

	public void FetchHpByOffset()
	{
	}

	public void SetMaxCurrentHp()
	{
	}

	public void SetCurrentHp(float value)
	{
	}

	public float SetDamageFontSize(int v)
	{
		return 0f;
	}

	public void SetDamageFeedback(MMF_Player feedback)
	{
	}

	public void SetBlockFeedback(MMF_Player feedback)
	{
	}

	public void SetDeathFeedback(MMF_Player feedback)
	{
	}

	public void PlayDeathFeedback()
	{
	}
}
