using System.Collections.Generic;
using Game.CodedAnimation;
using Game.GUI;
using UnityEngine;

namespace Game.Shop
{
	public class SubscriptionPanel : MonoBehaviour
	{
		[SerializeField]
		private Transform[] _packUis;

		[SerializeField]
		private GameObject _shopPackItem;

		[SerializeField]
		private RectTransform _slotTemplate;

		[SerializeField]
		private Transform _slotContainer;

		[SerializeField]
		private DotweenAnimation2 _animation;

		[SerializeField]
		private VisibleUiWatcher _packWatcher;

		private List<Transform> _currentPackUis;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private List<ShopPackData> LoadPacks()
		{
			return null;
		}

		private void GeneratePacks(List<ShopPackData> packDatas)
		{
		}
	}
}
