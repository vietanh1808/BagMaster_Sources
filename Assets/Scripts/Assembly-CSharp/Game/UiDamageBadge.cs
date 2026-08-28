using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class UiDamageBadge : MonoBehaviour
	{
		[SerializeField]
		private Image _cupIcon;

		[SerializeField]
		private TMP_Text _dpsText;

		[field: SerializeField]
		[field: HideInInspector]
		public RectTransform RectTransform { get; private set; }

		private void OnValidate()
		{
		}

		public void Init(Sprite cupSprite, float damage, in Color color)
		{
		}
	}
}
