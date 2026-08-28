using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class SaveBoolToggle : MonoBehaviour
{
	[SerializeField]
	private string _key;

	private void Start()
	{
	}

	private void OnToggle(bool value)
	{
	}
}
