using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Combat
{
	public class ConfirmationPopup : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _titleText;

		[SerializeField]
		private TextMeshProUGUI _descriptionText;

		[SerializeField]
		private Button _continueButton;

		[SerializeField]
		private Button _cancelButton;

		[SerializeField]
		private Button _closeButton;

		public static void Show(string title, string description, UnityAction onContinue = null, UnityAction onCancel = null, string popupName = "Modal_ConfirmationPopup")
		{
		}
	}
}
