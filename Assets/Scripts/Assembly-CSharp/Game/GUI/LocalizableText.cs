using I2.Loc;
using TMPro;
using UnityEngine;

namespace Game.GUI
{
	[RequireComponent(typeof(TMP_Text))]
	public class LocalizableText : UiBehaviour
	{
		[field: SerializeField]
		public TMP_Text TextComponent { get; private set; }

		[field: SerializeField]
		public Localize Localize { get; private set; }

		[field: SerializeField]
		public LocalizationParamsManager ParamsManager { get; private set; }

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

		public void SetLocalizeValue<T>(T value)
		{
		}

		public void SetLocalizeValues(params string[] values)
		{
		}

		protected override void OnValidate()
		{
		}
	}
}
