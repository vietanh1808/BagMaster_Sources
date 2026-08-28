using System;
using UnityEngine;

namespace Game
{
	[Obsolete("Chuyển qua class <PostHomeOpenScreens> để dồn những popup hay screen vào một nơi cho dễ quản lý")]
	public class CheckShowStrongerSuggestion : MonoBehaviour
	{
		[SerializeField]
		private GameObject _recommendPopup;

		public const string DontShowAgainSave = "dsa_strongersuggestion";

		public static bool ForceDontShowThisTime;

		public static bool DontShowAgain
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Start()
		{
		}
	}
}
