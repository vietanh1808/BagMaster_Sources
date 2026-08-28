using TMPro;
using UnityEngine;

namespace Game
{
	public class CurrencyFloating : MonoBehaviour
	{
		[SerializeField]
		private SpriteRenderer _icon;

		[SerializeField]
		private TextMeshPro _text;

		[SerializeField]
		private float _worldUnitSize;

		public void UpdateInfo(Sprite sprite, int amount)
		{
		}

		public void UpdateInfo(string spriteName, int amount)
		{
		}
	}
}
