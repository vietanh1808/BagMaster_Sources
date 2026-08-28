using UnityEngine;

[CreateAssetMenu(fileName = "GearIntroImageDimension", menuName = "ScriptableObjects/GearIntroImageDimension")]
public class GearIntroImageDimension : ScriptableObject
{
	[SerializeField]
	public Vector2 ConstraintDimentions;

	[SerializeField]
	public Vector2 ScaledDimentions;
}
