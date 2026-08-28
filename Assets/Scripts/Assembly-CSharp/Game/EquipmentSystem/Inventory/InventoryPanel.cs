using Game.AssetManager;
using Game.EquipmentSystem.Fuse;
using UnityEngine;

namespace Game.EquipmentSystem.Inventory
{
	public class InventoryPanel : MonoBehaviour
	{
		[SerializeField]
		private CharacterSkinEquipmentBinder _characterSkin;

		[Tooltip("Delay (s) before the character skin updates after equipping, so it syncs with the avatar scale feedback.")]
		[SerializeField]
		private float _equipScaleDelay;

		[SerializeField]
		private AvatarView _avatarView;

		[SerializeField]
		private EquipmentTransitionAnimator _transitionAnimator;

		[SerializeField]
		private GameObject _mergeNotification;

		[SerializeField]
		private GameObject _noItemText;

		private InventoryMap _inventoryMap;

		private bool _dirty;

		private readonly FuseMap _fuseMap;

		private InventorySortService _sortService;

		private bool _isFuseButtonClicked;

		private OwnedItemEntity _pendingSkinClear;

		[SerializeField]
		private EquipmentListViewV2<Item> _equipmentListView;

		private SpriteCacheService _spriteCacheService;

		private PlayerInfo PInfo => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void DisposeSpriteService()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnReceived(OwnedItemEntity ownedEquipment)
		{
		}

		private void OnRemoved(OwnedItemEntity ownedEquipment)
		{
		}

		private void OnEquipped(OwnedItemEntity ownedEquipment)
		{
		}

		private void ScheduleCharacterSkinUpdate(OwnedItemEntity toClear, OwnedItemEntity toApply)
		{
		}

		private void UpdateCharacterSkin(OwnedItemEntity toClear, OwnedItemEntity toApply)
		{
		}

		private void OnUnequipped(OwnedItemEntity ownedEquipment)
		{
		}

		private void Refresh()
		{
		}

		private void HighlightBetterItem(EquipmentDisplayData data, Item viewItem)
		{
		}

		private void LoadEquippedItems()
		{
		}

		public void OnMergeButtonClicked()
		{
		}
	}
}
