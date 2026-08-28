using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraFixWidth : MonoBehaviour
{
	[SerializeField]
	private float _desiredWidth;

	[SerializeField]
	[Range(0f, 1f)]
	private float _matchWidth;

	private void Awake()
	{
	}

	private void UpdateSize()
	{
	}
}
