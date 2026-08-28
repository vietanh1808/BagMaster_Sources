using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SoundButton : UISound
{
	[Header("Button")]
	[SerializeField]
	private bool _manualAssign;

	private void Start()
	{
	}
}
