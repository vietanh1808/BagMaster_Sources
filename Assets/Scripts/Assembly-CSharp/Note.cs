using UnityEngine;

public class Note : MonoBehaviour
{
	[SerializeField]
	[TextArea(10, 50)]
	private string _note;
}
