using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

public class AnimationEventListener : SerializedMonoBehaviour
{
	[SerializeField]
	private Dictionary<string, UnityEvent> _events;

	public UnityEvent GetUnityEvent(string eventName)
	{
		return null;
	}

	public void TriggerEvent(string eventName)
	{
	}

	public void AddEvent(string eventName)
	{
	}
}
