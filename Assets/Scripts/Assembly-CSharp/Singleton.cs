using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	protected static T _instance;

	public static T Instance => null;

	public void Reset()
	{
	}

	public static bool Exists()
	{
		return false;
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnAwake()
	{
	}
}
