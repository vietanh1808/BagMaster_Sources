using System.Collections.Generic;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.EquipmentSystem.Inventory
{
	public class AvatarView : MonoBehaviour
	{
		[SerializeField]
		private EquipmentInfo _headEquipment;

		[SerializeField]
		private EquipmentInfo _bodyEquipment;

		[SerializeField]
		private EquipmentInfo _weaponEquipment;

		[SerializeField]
		private EquipmentInfo _accessoryEquipment;

		[Header("Change Feedback")]
		[SerializeField]
		private MMF_Player[] _equipFeedbackByRarity;

		private Dictionary<EquipmentPart, EquipmentInfo> _equippings;

		public void Initialize()
		{
		}

		public EquipmentInfo GetSlotForType(EquipmentPart type)
		{
			return null;
		}

		public void SetEquipmentView(EquipmentPart type, EquipmentData data, OwnedItemEntity owned)
		{
		}

		public void ClearEquipmentView(EquipmentPart type)
		{
		}

		public void PlayEquipmentChangeEffect(EquipmentData data)
		{
		}

		private MMF_Player GetEquipFeedback(EquipmentData data)
		{
			return null;
		}
	}
}
