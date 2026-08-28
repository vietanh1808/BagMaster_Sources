using System;
using System.Collections.Generic;
using Game.CodedAnimation;
using MoreMountains.Feedbacks;
using UnityEngine;

public class SynercyFloatingTextSubSpawner : IDisposable
{
	public struct QueueItem
	{
		public string Content;

		public Color Color;

		public Vector3 Position;

		public MMF_Player[] Feedbacks;

		public int Variant;
	}

	private class SynercyTextStorage
	{
		public float LastSpawnTime;

		public List<GameObject> ActiveTexts;
	}

	public readonly GameObject Source;

	private readonly float _interval;

	private readonly Func<GameObject> _getGameObjectFunc;

	private readonly SynercyFloatingTextAnimation[] _animations;

	private readonly Func<AudioClip> _getSound;

	private readonly Dictionary<int, Queue<QueueItem>> _waitingTexts;

	private readonly Dictionary<int, SynercyTextStorage> _activeTexts;

	public bool IsSourceDestroyed { get; private set; }

	public SynercyFloatingTextSubSpawner(GameObject source, Func<GameObject> getGameObjectFunc, SynercyFloatingTextAnimation[] animations, float interval, Func<AudioClip> getSound = null)
	{
	}

	public int Update(float dt, int maxSpawns)
	{
		return 0;
	}

	private SynercyTextStorage GetStorage(int channel)
	{
		return null;
	}

	private void Spawn(QueueItem data, SynercyTextStorage storage)
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

	private void ClearStorage(SynercyTextStorage storage)
	{
	}
}
