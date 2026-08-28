using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	public class OrbitingGear : MonoBehaviour
	{
		[SerializeField]
		private SpriteRenderer _renderer;

		public Gear Gear { get; private set; }

		public Unit Owner { get; private set; }

		public SpriteRenderer Renderer => null;

		private void OnEnable()
		{
		}

		public void SetInfo(Gear gear, Unit owner)
		{
		}

		public void Refresh()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		private void OnDestroy()
		{
		}

		public void FadeIn()
		{
		}

		public Tween FadeOut()
		{
			return null;
		}
	}
}
