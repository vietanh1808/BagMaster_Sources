using System;
using System.Collections.Generic;
using UnityEngine;

public class GeneralUiFloatingTextSubSpawner : IDisposable
{
	public struct QueueItem
	{
		public string Content;

		public Color Color;

		public Vector3 Position;

		public int Variant;
	}

	private class UiTextStorage
	{
		public float LastSpawnTime;

		public List<GameObject> ActiveTexts;

		public Action<GameObject> RemoveCallback;
	}

	public readonly GameObject Source;

	private readonly float _interval;

	private readonly Func<int, GameObject> _getGameObjectFunc;

	private readonly Dictionary<int, Queue<QueueItem>> _waitingTexts;

	private readonly Dictionary<int, UiTextStorage> _activeTexts;

	public bool IsSourceDestroyed { get; private set; }

	public GeneralUiFloatingTextSubSpawner(GameObject source, Func<int, GameObject> getGameObjectFunc, float interval)
	{
	}

	public void Update(float dt)
	{
	}

	private UiTextStorage GetStorage(int channel)
	{
		return null;
	}

	private void Spawn(QueueItem data, UiTextStorage storage)
	{
	}

	public void Push(int channel, QueueItem item)
	{
	}

	public void ClearWaitingTexts(int channel = -1)
	{
	}

	public void Dispose()
	{
	}

	private void ClearStorage(UiTextStorage storage)
	{
	}
}
