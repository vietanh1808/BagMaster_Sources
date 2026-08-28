using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem
{
	[RequireComponent(typeof(EquipmentInfo))]
	public class EquipmentRevertButton : MonoBehaviour
	{
		[SerializeField]
		private Button _revertBtn;

		private EquipmentInfo _equipmentInfo;

		private EquipmentData _lastData;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnInfoUpdated(EquipmentInfo info)
		{
		}

		public void Refresh()
		{
		}

		private void RefreshVisibility()
		{
		}

		private void OnClick()
		{
		}
	}
}
