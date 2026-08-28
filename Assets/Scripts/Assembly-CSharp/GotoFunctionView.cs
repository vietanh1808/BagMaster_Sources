using Game;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GotoFunctionView : MonoBehaviour
{
	[SerializeField]
	private Button _goToButton;

	[SerializeField]
	private Button _lockButton;

	[SerializeField]
	private Button _buyNowButton;

	[SerializeField]
	private Image _navigateFunctionImage;

	[SerializeField]
	private TextMeshProUGUI _navigateFunctionName;

	[SerializeField]
	private GameObject _notification;

	private FeatureNavigationConfig.FeatureNavigationData _configData;

	private DTO_GoToFunctionData _dtoData;

	private string _navigateSource;

	private void Start()
	{
	}

	public void UpdateInfo(FeatureNavigationConfig.FeatureNavigationData configData, DTO_GoToFunctionData dtoData)
	{
	}

	private void OnGotoButtonClicked()
	{
	}

	private bool IsEventDungeonResource()
	{
		return false;
	}

	private void ShowPurchaseTokenPopup()
	{
	}

	private int GetNumberStepLeft(int quantityPerStep)
	{
		return 0;
	}

	public void SetNavigateSource(string source)
	{
	}
}
