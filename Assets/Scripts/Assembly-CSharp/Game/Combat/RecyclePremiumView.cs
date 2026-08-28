using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class RecyclePremiumView : MonoBehaviour
	{
		[Header("Visual")]
		[SerializeField]
		private SpriteRenderer _recycleRenderer;

		[SerializeField]
		private Sprite _recycleRremiumSprite;

		[Header("Events")]
		public UnityEvent OnActivatedEvent;

		public void Show()
		{
		}
	}
}
