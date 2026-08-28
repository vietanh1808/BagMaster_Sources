using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Shop
{
	public class EquipmentBannerTabButtons : MonoBehaviour
	{
		[SerializeField]
		private GameObject _tabButtonOnState;

		[SerializeField]
		private GameObject _tabButtonOffState;

		[SerializeField]
		private List<Image> _tabButtonSprites;

		[SerializeField]
		private Toggle _tabToggle;

		[Header("Runtime")]
		public int TabIndex;

		private Action<int> _onTabSelected;

		public Action<int> OnTabSelected
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnValueChanged(bool isOn)
		{
		}

		public Toggle GetTabToggle()
		{
			return null;
		}

		public void UpdateInfo(string iconText, bool isOn)
		{
		}
	}
}
