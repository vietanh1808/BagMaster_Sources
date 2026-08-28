using System.Threading;
using Cysharp.Threading.Tasks;
using DoorServices;
using Game.GUI;
using Game.Shop;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class CombatGemOfferPopup : SelectionView<CombatGemOfferPopup.Params, bool>
	{
		public struct Params
		{
			public string IapProductId;

			public string PlacementTracking;

			public ResourceRewardData Reward;
		}

		[SerializeField]
		private IAPItemView _iAPItemView;

		[SerializeField]
		private TextMeshProUGUI _gemAmountText;

		public UnityEvent OnClosedWithRewardEvent;

		public UnityEvent OnClosedWithoutRewardEvent;

		private bool _isRewarded;

		private Params _params;

		private UniTaskCompletionSource<bool> _taskSource;

		public ResourceRewardData Reward => null;

		private string PlacementTracking => null;

		public string IapProductId => null;

		public StoreEntryMethod StoreEntryMethod => StoreEntryMethod.Others;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		public override UniTask<bool> Select(Params input, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		private void OnDestroy()
		{
		}

		private void OnClaimed()
		{
		}
	}
}
