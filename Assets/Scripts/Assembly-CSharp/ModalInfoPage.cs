using TMPro;
using UnityEngine;

public class ModalInfoPage : MonoBehaviour
{
	[SerializeField]
	private string PageTitleLocalizationKey;

	[SerializeField]
	private string PageContentLocalizationKey;

	[SerializeField]
	private TextMeshProUGUI TitleText;

	[SerializeField]
	private TextMeshProUGUI ContentText;

	private void Start()
	{
	}

	public void UpdateInfo(string titleKey, string contentKey)
	{
	}
}
