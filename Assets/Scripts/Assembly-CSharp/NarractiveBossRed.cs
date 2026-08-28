using Game.Combat;
using UnityEngine;
using Yarn.Unity;

public class NarractiveBossRed : MonoBehaviour
{
	public GameObject _bubble;

	private BossRedIntroduction _bossRedIntroduction;

	[YarnCommand("aggressive")]
	public void TriggerAggressive()
	{
	}

	[YarnCommand("summon_weapon")]
	public void TriggerSummonWeapon()
	{
	}

	[YarnCommand("attack")]
	public void TriggerAttack()
	{
	}

	[YarnCommand("backidle")]
	public void PlayBackToIdle()
	{
	}

	[YarnCommand("bubble_active")]
	public void SetBubbleActive(bool value)
	{
	}

	private BossRedIntroduction GetBossRedIntroduction()
	{
		return null;
	}
}
