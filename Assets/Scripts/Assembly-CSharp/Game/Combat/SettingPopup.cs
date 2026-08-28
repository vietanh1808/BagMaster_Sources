using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class SettingPopup : PausePopup
	{
		[SerializeField]
		private Toggle _masterSoundToggle;

		[SerializeField]
		private Toggle _musicToggle;

		[SerializeField]
		private Toggle _soundToggle;

		[SerializeField]
		private Toggle _screenshakeToggle;

		[SerializeField]
		private Toggle _hapticToggle;

		[SerializeField]
		private GameObject _googleButton;

		[SerializeField]
		private GameObject _appleButton;

		private static MMSoundManager SM => null;

		private void Start()
		{
		}

		public static void OnOffMasterSound(bool on)
		{
		}

		public static void OnOffMusic(bool on)
		{
		}

		public static void OnOffSound(bool on)
		{
		}

		public static void OnOffScreenShake(bool on)
		{
		}

		public static void OnOffHaptic(bool on)
		{
		}

		private void PlayHaptic(bool on)
		{
		}
	}
}
