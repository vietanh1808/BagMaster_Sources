using UnityEngine;

namespace Game.Combat
{
	public class BenchConnectionVisuals : MonoBehaviour
	{
		public enum State
		{
			NoConnection = 0,
			InConnection = 1
		}

		[SerializeField]
		private BenchDropArea _benchDropArea;

		[SerializeField]
		private LineRenderer _lineRenderer;

		[SerializeField]
		private float _lineZ;

		[SerializeField]
		private GameObject _inConnectionVfx;

		[SerializeField]
		private GameObject _breakVfxPrefab;

		[SerializeField]
		private Transform _benchTransform;

		[SerializeField]
		private State _currentState;

		private void Start()
		{
		}

		private void OnChargeUsed()
		{
		}

		private void OnConnectionBroken(Gear newGear)
		{
		}

		private void PlayBreakVfx()
		{
		}

		private void Update()
		{
		}

		private void UpdateLine()
		{
		}
	}
}
