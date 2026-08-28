using DG.Tweening;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;

namespace Game.Combat
{
	public class GoldBar : MonoBehaviour
	{
		[SerializeField]
		protected TextMeshProUGUI _valueText;

		[SerializeField]
		protected Transform _coinSpawnPosition;

		[SerializeField]
		protected Transform _coinDestinationPosition;

		[SerializeField]
		protected ParticleSystem _coinFx;

		[SerializeField]
		protected MMF_Player _gainGoldFeeedback;

		[SerializeField]
		protected MMF_Player _goldReachFeedback;

		[SerializeField]
		protected GamePhase _gamePhase;

		[SerializeField]
		protected bool _noCreateVfx;

		protected int _displayValue;

		protected float _autoUpdateTime;

		public bool DontShowVFX;

		public static Vector3 SpawnPosition;

		private Tween _offTween;

		protected PlayerInfo PInfo => null;

		protected virtual void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual int GetAutoUpdateValue()
		{
			return 0;
		}

		private void OnDestroy()
		{
		}

		protected virtual void ListenRewardChanged(OwnedResourceEntity res, int changes)
		{
		}

		public virtual void GainGoldWithFX(int amount)
		{
		}

		protected virtual void CreateCoinFX(int amount, int i, Vector2 destination, Vector2 spawnPosition)
		{
		}

		public void PlayImpactFX()
		{
		}
	}
}
