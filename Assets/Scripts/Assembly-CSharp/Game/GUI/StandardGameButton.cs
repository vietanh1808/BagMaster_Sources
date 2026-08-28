using UnityEngine;
using UnityEngine.UI;

namespace Game.GUI
{
	public class StandardGameButton : ButtonWrapper
	{
		[SerializeField]
		protected ButtonLocker Locker;

		[field: SerializeField]
		public LocalizableText TextComponent { get; private set; }

		[field: SerializeField]
		public Image ButtonGraphic { get; private set; }

		[field: SerializeField]
		public GameObject Cta { get; private set; }

		[field: SerializeField]
		public CanvasGroup CanvasGroup { get; private set; }

		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite ButtonSprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsCtaActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float Alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsLocked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void OnValidate()
		{
		}

		public void SetLocalizeValue<T>(T value)
		{
		}

		public void SetLocalizeValues(params string[] values)
		{
		}
	}
}
