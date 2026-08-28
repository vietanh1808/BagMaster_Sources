using System;
using System.Runtime.CompilerServices;
using Game.EquipmentSystem;
using TMPro;
using UnityEngine;

namespace Game
{
	public class ResourceView : MonoBehaviour
	{
		[Header("Extra")]
		[SerializeField]
		private GameObject maskClaimedObject;

		[SerializeField]
		private GameObject lockObject;

		[SerializeField]
		private GameObject[] notifiesObject;

		[SerializeField]
		private TextMeshProUGUI _externalNameText;

		[SerializeField]
		private TextMeshProUGUI _externalDescText;

		[SerializeField]
		private GameObject _upTag;

		[SerializeField]
		private bool _isUp;

		[Header("Origin")]
		[SerializeField]
		private CurrencyView _currencyViewPrefab;

		[SerializeField]
		private EquipmentInfoGeneralUI _equipmentViewPrefab;

		[SerializeField]
		private Transform _viewContainer;

		[SerializeField]
		private TextMeshProUGUI _valueText;

		[SerializeField]
		private string _valueTextFormat;

		[Header("Runtime")]
		[SerializeField]
		private GameObject _currentView;

		[CompilerGenerated]
		private Action m_OnItemClicked;

		private ResourcesState _currentState;

		private static bool hasRegisterPool;

		public TextMeshProUGUI ValueText => null;

		public ResourceEntityHasVisual Data { get; private set; }

		public int Value { get; private set; }

		public event Action OnItemClicked
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		public void SetStatus(ResourcesState state)
		{
		}

		public void SetUp(bool up)
		{
		}

		public void ReturnPool()
		{
		}

		public void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateInfo(int resourceId, int value)
		{
		}

		public void UpdateInfo(ResourceEntityHasVisual data, int value)
		{
		}

		private void ShowEquipmentView(EquipmentData equipmentData)
		{
		}

		private void ShowOtherwise(ResourceEntityHasVisual resource, int value)
		{
		}

		private void InvokeClick()
		{
		}
	}
}
