using Game.AssetManager;
using Game.Combat;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class UiGear : MonoBehaviour
	{
		[SerializeField]
		private ImageAddressable _icon;

		[SerializeField]
		private ImageAddressable _shadow;

		[SerializeField]
		private Image _slotFiller;

		[field: SerializeField]
		[field: HideInInspector]
		public RectTransform RectTransform { get; private set; }

		private void OnValidate()
		{
		}

		public void Init(GearData data)
		{
		}
	}
}
