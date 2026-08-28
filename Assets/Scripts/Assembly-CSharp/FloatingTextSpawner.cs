using System;
using System.Collections.Generic;
using Game.CodedAnimation;
using MoreMountains.Feedbacks;
using MoreMountains.Tools;
using TMPro;
using UnityEngine;

public class FloatingTextSpawner : MonoBehaviour
{
	public struct TextSpawnParams
	{
		public static readonly TextSpawnParams Default;

		public GameObject Source;

		public string Content;

		public Color Color;

		public int FontSize;

		public Vector3 Position;

		public FontStyles FontStyles;

		public bool IsUi;

		public float DurationScale;

		public FloatingTextSubSpawner.PreviousHandleLogic PreviousHandleLogic;

		public int Channel;

		public float ElementalCounterMod;
	}

	[SerializeField]
	private MMObjectPooler _floatingTextPool;

	[SerializeField]
	private MMObjectPooler _floatingTextUiPool;

	[SerializeField]
	private MMObjectPooler[] _floatingTextUiPools;

	[SerializeField]
	private MMObjectPooler _synercyFloatingTextUiPool;

	[SerializeField]
	private SynercyFloatingTextAnimation[] _synercyAnimations;

	[SerializeField]
	private float _damageTextMinInterval;

	[SerializeField]
	private float _playerHealNShieldTextMinInterval;

	[SerializeField]
	private float _synercyTextMinInterval;

	[SerializeField]
	private float _textUiMinInterval;

	[SerializeField]
	private int _maxSynercyAtAFrame;

	[SerializeField]
	private FloatingTextAnimator _neutralDamageAnimator;

	[SerializeField]
	private FloatingTextAnimator _strongDamageAnimator;

	[SerializeField]
	private FloatingTextAnimator _weakDamageAnimator;

	[HideInInspector]
	public AudioClip SynercySound;

	private List<FloatingTextSubSpawner> _allSubSpawners;

	private Dictionary<GameObject, FloatingTextSubSpawner> _damgeTextSpawners;

	private Dictionary<GameObject, FloatingTextSubSpawner> _uiTextSpawners;

	private List<SynercyFloatingTextSubSpawner> _allSynercySubSpawners;

	private Dictionary<GameObject, SynercyFloatingTextSubSpawner> _synercyTextSpawners;

	private List<GeneralUiFloatingTextSubSpawner> _allGeneralUiSubSpawners;

	private Dictionary<GameObject, GeneralUiFloatingTextSubSpawner> _generalUiSpawners;

	public bool ShowUiText;

	public static FloatingTextSpawner Instance { get; private set; }

	public float SynercyTextInterval => 0f;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void CreateDamageHealShieldText(GameObject source, string content, TextVisualData profile, float fontSizeOverride, Vector3 position, bool ui, float durationScale, int channel = 0)
	{
	}

	public void CreateDamageHealShieldText(in TextSpawnParams spawnParams)
	{
	}

	private FloatingTextAnimator GetTextAnimator(in TextSpawnParams spawnParams)
	{
		return null;
	}

	private void PushFloatingTextSubSpawner(Dictionary<GameObject, FloatingTextSubSpawner> dict, GameObject source, Func<GameObject> getObjectFunc, float interval, FloatingTextSubSpawner.QueueItem queueItem, int channel)
	{
	}

	public void CreateSynercyText(GameObject source, string content, Vector3 position, SynercyFloatingText.TextType textType, MMF_Player[] feedbacks, int variant, Color color = default(Color), int channel = 0)
	{
	}

	public void CreateUiText(GameObject source, string content, Vector3 position, Color color, int variant = 0, int channel = 0)
	{
	}

	public void RemoveAllRemainTextInQueue(GameObject source)
	{
	}

	public void DestroyAllSynercyTextFromSource(GameObject source)
	{
	}

	public void DestroyAllSynercyTexts()
	{
	}
}
