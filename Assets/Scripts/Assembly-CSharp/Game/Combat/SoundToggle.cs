using MoreMountains.Tools;
using UnityEngine;

namespace Game.Combat
{
	public class SoundToggle : MonoBehaviour
	{
		[SerializeField]
		private GameObject _on;

		[SerializeField]
		private GameObject _off;

		private MMSoundManager SM => null;

		private void Start()
		{
		}

		protected virtual void OnValueChanged(bool isOn)
		{
		}
	}
}
