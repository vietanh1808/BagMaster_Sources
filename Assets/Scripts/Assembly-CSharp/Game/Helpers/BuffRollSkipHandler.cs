using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Helpers
{
	public class BuffRollSkipHandler : MonoBehaviour
	{
		private Toggle toggle;

		[SerializeField]
		private List<LockConditionData> _unlockConditions;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnToggleValueChanged(bool isOn)
		{
		}

		public bool IsSkipBuffRollAnimation()
		{
			return false;
		}
	}
}
