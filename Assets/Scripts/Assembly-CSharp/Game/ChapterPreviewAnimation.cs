using System.Collections.Generic;
using DG.Tweening;
using Game.CodedAnimation;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class ChapterPreviewAnimation : MonoBehaviour
	{
		[SerializeField]
		private float _initialDelay;

		[Header("Background")]
		[SerializeField]
		private float _backgroundFadeInDuration;

		[SerializeField]
		private float _objectScaleDuration;

		[SerializeField]
		private EaseOrAnimationCurve _objectScaleEase;

		[Header("Monster")]
		[SerializeField]
		private float _monsterStartScale;

		[SerializeField]
		private float _monsterAnimationDelay;

		[SerializeField]
		private Vector2 _monsterAnimationDuration;

		[SerializeField]
		private EaseOrAnimationCurve _monsterScaleEase;

		[SerializeField]
		private Color _lockedColor;

		[Header("Misc")]
		public bool IsLocked;

		private List<Tween> _tweens;

		[Header("Preview config")]
		[SerializeField]
		private GameObject[] _fallBackMonsterPrefabs;

		[SerializeField]
		private ChapterMonsterPreviewLoader _monsterPreviewLoader;

		private IReadOnlyList<GameObject> _monsterInstances;

		private readonly List<GameObject> _fallbackMonsters;

		private ChapterPreviewMonsterSource _monsterSource;

		private bool _fadeInStarted;

		private bool _monsterAnimationPlayed;

		private void Awake()
		{
		}

		private void CollectFallbackMonsters()
		{
		}

		private void Start()
		{
		}

		public void PrepareMonsterPreview(bool expectsAddressableLoad)
		{
		}

		private void OnMonsterLoadComplete(IReadOnlyList<GameObject> instances)
		{
		}

		private void SetFallbackMonstersActive(bool isEnable)
		{
		}

		private void OnDestroy()
		{
		}

		private void AnimateMonsterInstance(Transform monsterRoot)
		{
		}

		public void FadeIn()
		{
		}

		public void FadeOut()
		{
		}

		private void FadeInBackground()
		{
		}

		private void PlayMonsterTween(Transform monster, bool world)
		{
		}

		private void AnimateObjects(Image obj)
		{
		}

		private void AddTween(Tween tween)
		{
		}

		private void TryAnimateMonsters()
		{
		}
	}
}
