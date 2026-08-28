using System.Collections.Generic;
using MoreMountains.Tools;
using UnityEngine;

public class SoundManager : MMSoundManager
{
	[Header("Extends")]
	public bool NewSoundLogic;

	[MMCondition("NewSoundLogic", true)]
	public int MaxDupplicateSoundSameTime;

	[MMCondition("NewSoundLogic", true)]
	public bool KillSoundWhenMoreThanMaxDupplicate;

	[MMCondition("NewSoundLogic", true)]
	public float DupplicateSoundFadeDuration;

	[MMCondition("NewSoundLogic", true)]
	public MMTweenType DupplicateSoundFadeTween;

	[MMCondition("NewSoundLogic", true)]
	public float DupplicateDetectThresold;

	private Dictionary<AudioClip, float> _latestPlayTimes;

	protected override void Start()
	{
	}

	public override AudioSource PlaySound(AudioClip audioClip, MMSoundManagerPlayOptions options)
	{
		return null;
	}
}
