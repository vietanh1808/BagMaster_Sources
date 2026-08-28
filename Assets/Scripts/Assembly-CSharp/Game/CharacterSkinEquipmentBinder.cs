using Game.EquipmentSystem;
using Game.Skin;
using UnityEngine;

namespace Game
{
	public class CharacterSkinEquipmentBinder : MonoBehaviour
	{
		[Tooltip("MonoBehaviour that implements ICharacterSkin. Leave empty to auto-find on this GameObject.")]
		[SerializeField]
		private MonoBehaviour _skinBehaviour;

		[Tooltip("Off = manual mode: the owner drives the skin instead of PlayerInfo events.")]
		[SerializeField]
		private bool _usingEvents;

		private ICharacterSkin _skin;

		private PlayerInfo _playerInfo;

		private bool _started;

		private string _armSuffix;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetPlayerInfo(PlayerInfo playerInfo)
		{
		}

		private void Bind()
		{
		}

		private void Unbind()
		{
		}

		private void OnEquipmentEquipped(OwnedItemEntity item)
		{
		}

		private void OnEquipmentUnequipped(OwnedItemEntity item)
		{
		}

		public void ApplyEquipment(OwnedItemEntity item)
		{
		}

		public void ApplyUnequip(OwnedItemEntity item)
		{
		}

		public void SyncFromPlayerInfo()
		{
		}

		private void HandleEquipped(OwnedItemEntity item)
		{
		}

		private void HandleUnequipped(OwnedItemEntity item)
		{
		}

		private void ApplyEquipmentSkins(EquipmentData data)
		{
		}

		private void ClearEquipmentSkins(EquipmentData data)
		{
		}

		private void ResetPartToDefault(SkinPart part)
		{
		}

		private static string DefaultSkinKey(SkinPart part)
		{
			return null;
		}

		private string GetBodySetPrefix()
		{
			return null;
		}

		private string FormatArmKey(string skinArmSuffix)
		{
			return null;
		}

		private void UpdateArm(string skinArmSuffix)
		{
		}

		public static bool TryMap(EquipmentPart equipmentPart, out SkinPart skinPart)
		{
			skinPart = default;
			return false;
		}
	}
}
