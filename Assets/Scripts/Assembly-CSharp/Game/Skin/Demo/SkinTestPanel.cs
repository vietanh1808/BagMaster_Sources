using System;
using System.Collections.Generic;
using Game.EquipmentSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Skin.Demo
{
	public class SkinTestPanel : MonoBehaviour
	{
		[Serializable]
		public class PartDropdown
		{
			public SkinPart Part;

			public TMP_Dropdown Dropdown;
		}

		[Tooltip("MonoBehaviour on the Spine actor that implements ICharacterSkin.")]
		[SerializeField]
		private MonoBehaviour _skinBehaviour;

		[SerializeField]
		private List<PartDropdown> _dropdowns;

		[SerializeField]
		private Button _clearAllButton;

		private ICharacterSkin _skin;

		private readonly Dictionary<SkinPart, List<string>> _skinKeysByPart;

		private void Start()
		{
		}

		private void PopulateDropdowns()
		{
		}

		private void WireDropdownCallbacks()
		{
		}

		private void HandleDropdownChanged(SkinPart part, int index)
		{
		}

		private void HandleClearAll()
		{
		}

		private TMP_Dropdown FindDropdown(SkinPart part)
		{
			return null;
		}

		private static string BuildLabel(EquipmentData data)
		{
			return null;
		}

		private static bool TryToEquipmentPart(SkinPart skinPart, out EquipmentPart result)
		{
			result = default;
			return false;
		}
	}
}
