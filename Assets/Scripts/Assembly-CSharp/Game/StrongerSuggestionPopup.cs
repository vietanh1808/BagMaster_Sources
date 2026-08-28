using UnityEngine;

namespace Game
{
	public class StrongerSuggestionPopup : MonoBehaviour
	{
		[SerializeField]
		private GameObject _inventory;

		[SerializeField]
		private GameObject _talent;

		[SerializeField]
		private GameObject _shop;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}
	}
}
