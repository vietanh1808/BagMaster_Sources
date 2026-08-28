using MoreMountains.Tools;
using UnityEngine;

namespace Game.Combat
{
	public class MusicToggle : MonoBehaviour
	{
		[SerializeField]
		private GameObject _on;

		[SerializeField]
		private GameObject _off;

		private MMSoundManager SM => null;

		private void Start()
		{
		}

		private void OnValueChanged(bool isOn)
		{
		}
	}
}
