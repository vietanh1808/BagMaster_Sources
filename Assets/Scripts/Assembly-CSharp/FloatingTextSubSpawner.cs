using System;
using System.Collections.Generic;
using Game.CodedAnimation;
using TMPro;
using UnityEngine;

public class FloatingTextSubSpawner : IDisposable
{
	public enum PreviousHandleLogic
	{
		None = 0,
		Fade = 1
	}

	public struct QueueItem
	{
		public string Content;

		public Color Color;

		public float FontSize;

		public Vector3 Position;

		public FontStyles FontStyles;

		public float DurationScale;

		public PreviousHandleLogic PreviousHandleLogic;

		public FloatingTextAnimator TextAnimator;
	}

	private class FloatingTextStorage
	{
		public float LastSpawnTime;

		public List<FloatingText> FloatingTexts;
	}

	public readonly GameObject Source;

	private readonly float _interval;

	private readonly Dictionary<int, Queue<QueueItem>> _waitingTexts;

	private readonly Dictionary<int, FloatingTextStorage> _floatingTexts;

	private readonly Func<GameObject> _getGameObjectFunc;

	private readonly Action<FloatingText> _onFloatingTextDisabled;

	public bool IsSourceDestroyed { get; private set; }

	public FloatingTextSubSpawner(GameObject source, Func<GameObject> getGameObjectFunc, float minInterval)
	{
	}

	public void Update(float dt)
	{
	}

	private FloatingTextStorage GetStorage(int channel)
	{
		return null;
	}

	private void SpawnFloatingText(QueueItem queueItem, int channel, FloatingTextStorage storage)
	{
	}

	private void OnFloatingTextDisabled(FloatingText floatingText)
	{
	}

	private void HandlePreviousText(FloatingTextStorage storage, PreviousHandleLogic previousHandleLogic)
	{
	}

	private void FadePreviousText(FloatingTextStorage storage)
	{
	}

	public void Push(int channel, QueueItem queueItem)
	{
	}

	public void ClearWaitingTexts(int channel = -1)
	{
	}

	public void ClearFloatingTexts(int channel = -1)
	{
	}

	private void ClearCallbacks()
	{
	}

	public void Dispose()
	{
	}

	private void ClearStorage(FloatingTextStorage storage, bool disableText)
	{
	}
}
