using UnityEngine;

public class CameraUi : MonoBehaviour
{
	private static CameraUi _instance;

	[SerializeField]
	private GameObject _bloomEffect;

	public static CameraUi Instance => null;

	private void Start()
	{
	}

	public void ToggleBloomEffect(bool Value)
	{
	}
}
