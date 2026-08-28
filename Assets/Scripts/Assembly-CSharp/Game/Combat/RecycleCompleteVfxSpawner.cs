using Game.CodedAnimation;
using UnityEngine;

namespace Game.Combat
{
	public class RecycleCompleteVfxSpawner : MonoBehaviour
	{
		[SerializeField]
		private RecyleDropArea _recycle;

		[SerializeField]
		private GameObject _vfxPrefab;

		[SerializeField]
		private GameObject _hitVfxPrefab;

		[SerializeField]
		private Transform _spawnPosition;

		[SerializeField]
		private Transform _destination;

		[Header("Moving Animation")]
		[SerializeField]
		private EaseOrAnimationCurve _movingEase;

		[SerializeField]
		private float _movingDelay;

		[SerializeField]
		private float _movingDuration;

		[SerializeField]
		private float _movingHeight;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void SpawnGainFreeRerollVfx()
		{
		}
	}
}
