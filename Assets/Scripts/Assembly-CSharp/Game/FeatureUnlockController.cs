using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Game
{
	public class FeatureUnlockController : MonoBehaviour
	{
		[SerializeField]
		private List<LockConditionData> _unlockConditions;

		[Header("Events")]
		public UnityEvent OnLockedEvent;

		public UnityEvent OnUnlockedEvent;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void Check()
		{
		}

		private void RegisterEvents()
		{
		}

		private void OnValueChanged(int value)
		{
		}

		public void InvokeUnlock(bool unlock)
		{
		}
	}
}
