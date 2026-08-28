using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu(fileName = "LanguageFontCollection", menuName = "Game/LanguageFontCollection")]
	public class LanguageFontCollection : ScriptableObject
	{
		[Serializable]
		public class LanguageFontPair
		{
			[SerializeField]
			private string _languageName;

			[SerializeField]
			private TMP_FontAsset _fontAsset;

			public string LanguageName => null;

			public TMP_FontAsset FontAsset => null;

			public LanguageFontPair(string languageName)
			{
			}
		}

		[SerializeField]
		private List<LanguageFontPair> _languageFontPairs;

		public TMP_FontAsset GetFontAsset(string languageName)
		{
			return null;
		}

		public void AutoAcquireLanguages()
		{
		}
	}
}
