using MoreMountains.Tools;
using UnityEngine;

public class BossMMProgressBar : MMProgressBar
{
	[MMInspectorGroup("Boss Catch-Up", true, 21, false)]
	[Tooltip("If true, force the delayed bar to start moving when the gap (delayed − foreground) exceeds MaxAllowedGap.")]
	public bool EnableGapCatchUp;

	[Range(0f, 1f)]
	public float MaxAllowedGap;

	[Tooltip("If true, cap how long the delayed bar may stay frozen after the first hit, regardless of incoming spam.")]
	public bool EnableMaxDelayCatchUp;

	public float MaxDecreasingDelay;

	private float _firstLagTimestamp;

	protected override void OnEnable()
	{
	}

	public override void UpdateBar(float currentValue, float minValue, float maxValue)
	{
	}
}
