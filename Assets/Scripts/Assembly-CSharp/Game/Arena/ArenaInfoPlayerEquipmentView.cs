using Game.EquipmentSystem;
using Game.EquipmentSystem.Inventory;
using UnityEngine;

namespace Game.Arena
{
	public class ArenaInfoPlayerEquipmentView : MonoBehaviour
	{
		[SerializeField]
		private Item headEquipment;

		[SerializeField]
		private Item bodyEquipment;

		[SerializeField]
		private Item weaponEquipment;

		[SerializeField]
		private Item accessoryEquipment;

		[SerializeField]
		private CharacterSkinEquipmentBinder characterSkin;

		private PlayerInfo playerInfo;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetPlayerData(PlayerInfo data)
		{
		}

		private void RefreshUi()
		{
		}

		private void RefreshSlot(Item slot, EquipmentPart part)
		{
		}

		private void UnloadUi()
		{
		}
	}
}
