using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class KingdomBuildingRerollView : MonoBehaviour
	{
		[SerializeField]
		private Button _rerollButtonEnough;

		[SerializeField]
		private Button _rerollButtonNotEnough;

		[SerializeField]
		private CurrencyView[] _priceViews;

		[Header("Reference")]
		[SerializeField]
		private KingdomBuildingManager _buildingManager;

		private ResourceRequireData _rerollPriceData;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnRerollRollButtonClicked()
		{
		}
	}
}
