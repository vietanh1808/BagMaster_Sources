using UnityEngine;

namespace Game
{
	public class ShowMessage : MonoBehaviour
	{
		[SerializeField]
		private string _message;

		[SerializeField]
		private bool _localizeKey;

		public bool GetLocalizedStatus()
		{
			return false;
		}

		public void OverrideMessage(string message)
		{
		}

		public void Show()
		{
		}
	}
}
