using UnityEngine;

namespace Game.Combat
{
	public class VibrateToggle : MonoBehaviour
	{
		[SerializeField]
		private GameObject _on;

		[SerializeField]
		private GameObject _off;

		private void Start()
		{
		}

		protected virtual void OnValueChanged(bool isOn)
		{
		}
	}
}
