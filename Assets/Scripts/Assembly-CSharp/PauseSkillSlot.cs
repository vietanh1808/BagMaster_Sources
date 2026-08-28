using Game.Combat;
using Game.Constant;
using UnityEngine;
using UnityEngine.UI;

public class PauseSkillSlot : SupportSkillSlot
{
	[SerializeField]
	private BuffUIProfile _buffUIProfile;

	[SerializeField]
	private Image _imgBorderIcon;

	public override void UpdateInfo(Sprite icon, SimpleSkill skill, Rarity rarity)
	{
	}

	public override void UpdateInfo(string iconName, SimpleSkill skill, Rarity rarity)
	{
	}
}
