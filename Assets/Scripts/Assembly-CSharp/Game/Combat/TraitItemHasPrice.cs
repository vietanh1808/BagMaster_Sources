using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class TraitItemHasPrice : TraitItem
	{
		[SerializeField]
		private TextMeshProUGUI _priceText;

		[SerializeField]
		private Button _buyBtn;

		private OwnedResourceEntity _gold;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public override void Initialize(BuffData buffData, Unit player, float delayAppear, bool isRecommended)
		{
		}

		private void OnBuy()
		{
		}
	}
}
