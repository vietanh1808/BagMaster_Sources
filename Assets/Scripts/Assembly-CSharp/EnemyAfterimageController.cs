using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class EnemyAfterimageController : MonoBehaviour
{
	[Header("Afterimage khi dùng Skill")]
	[Tooltip("Độ sáng ban đầu afterimage (1 = full, 0.5 = nửa sáng)")]
	public float skillBrightness;

	[Tooltip("Thời gian afterimage tồn tại khi skill")]
	public float skillLifetime;

	[Tooltip("Khoảng cách spawn afterimage khi skill (nhỏ hơn = dày hơn)")]
	public float skillSpawnDist;

	[Header("Material")]
	[Tooltip("Material dùng cho afterimage của enemy này. Để trống = dùng default của Pool.")]
	public Material afterimageMaterial;

	private AfterimageEffect _effect;

	private bool _isSkillActive;

	public bool IsSkillActive => false;

	private void Awake()
	{
	}

	public void StartSkill()
	{
	}

	public void StopSkill()
	{
	}
}
