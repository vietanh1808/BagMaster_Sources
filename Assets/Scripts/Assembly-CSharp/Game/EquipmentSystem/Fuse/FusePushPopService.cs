using System;
using System.Collections.ObjectModel;

namespace Game.EquipmentSystem.Fuse
{
	public class FusePushPopService
	{
		public Action<OwnedItemEntity> OnMainMaterialPushed;

		public Action OnRequireReached;

		public Action OnEmptyMaterials;

		public Action<int, OwnedItemEntity> OnMaterialPushed;

		public Action<int, OwnedItemEntity> OnMaterialPopped;

		private OwnedItemEntity[] _materials;

		public int MaterialRequireCount { get; private set; }

		public EquipmentData Main { get; private set; }

		public ReadOnlyCollection<OwnedItemEntity> Materials => null;

		public void PushMaterial(OwnedItemEntity material)
		{
		}

		private void PushMaterialInEmptySlot(OwnedItemEntity material, out int index)
		{
			index = default;
		}

		private bool IsFirstMaterialPushed(OwnedItemEntity material)
		{
			return false;
		}

		private void PushFirstMaterial(OwnedItemEntity material)
		{
		}

		public bool IsRequireReached()
		{
			return false;
		}

		public void PopMaterial(OwnedItemEntity material)
		{
		}

		private void FindMaterialAndEmptySlot(OwnedItemEntity material, out int index)
		{
			index = default;
		}

		private bool IsFirstMaterialEmpty()
		{
			return false;
		}

		private void PopAllMaterials()
		{
		}

		private void SetupMaterialSlots(int count)
		{
		}

		public bool IsPushed(OwnedItemEntity material)
		{
			return false;
		}

		public void ClearMaterials()
		{
		}
	}
}
