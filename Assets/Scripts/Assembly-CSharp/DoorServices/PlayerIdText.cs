using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DoorServices
{
	public class PlayerIdText : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _text;

		[SerializeField]
		private string _format;

		[SerializeField]
		private Button _copyButton;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnPlayerIdUpdated(string obj)
		{
		}
	}
}
