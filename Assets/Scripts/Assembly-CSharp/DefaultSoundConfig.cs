using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultSoundConfig", menuName = "Game/DefaultSoundConfig")]
public class DefaultSoundConfig : ScriptableObject
{
	[Serializable]
	public class SoundData
	{
		public AudioClip Clip;

		public SoundPlayOption Options;

		public AudioSource Play()
		{
			return null;
		}
	}

	public AudioClip ButtonClickSound;

	[SerializeField]
	private SoundData[] _soundDatas;

	private Dictionary<string, float> _soundCooldowns;

	private static DefaultSoundConfig _instance;

	public static DefaultSoundConfig Instance => null;

	[Obsolete("Use DefaultSoundConfig.GetSoundData()")]
	public AudioClip GetSound(string soundName)
	{
		return null;
	}

	[Obsolete("Use DefaultSoundConfig.GetSoundData().Play()")]
	public void PlaySound(string soundName, AudioSource audioSource, float cooldown)
	{
	}

	public static SoundData GetSoundData(string soundName)
	{
		return null;
	}

	private void SortByAlpha()
	{
	}

	private void CheckDupplicate()
	{
	}
}
