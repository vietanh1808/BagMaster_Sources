using UnityEngine;

public class GeneralEventsListeners : MonoBehaviour
{
	public enum MyEvents
	{
		CHANGE_COLOR = 0,
		JUMP = 1,
		LENGTH = 2
	}

	private Vector3 towardsRotation;

	private float turnForLength;

	private float turnForIter;

	private Color fromColor;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void jumpUp(LTEvent e)
	{
	}

	private void changeColor(LTEvent e)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionStay(Collision collision)
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnMouseDown()
	{
	}
}
