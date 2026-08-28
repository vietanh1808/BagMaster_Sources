using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class ViewportHandler : MonoBehaviour
{
	public enum Constraint
	{
		Landscape = 0,
		Portrait = 1
	}

	public Color wireColor;

	public float UnitsSize;

	public Constraint constraint;

	public static ViewportHandler Instance;

	public Camera camera;

	private float _width;

	private float _height;

	private Vector3 _bl;

	private Vector3 _bc;

	private Vector3 _br;

	private Vector3 _ml;

	private Vector3 _mc;

	private Vector3 _mr;

	private Vector3 _tl;

	private Vector3 _tc;

	private Vector3 _tr;

	public float Width => 0f;

	public float Height => 0f;

	public Vector3 BottomLeft => default;

	public Vector3 BottomCenter => default;

	public Vector3 BottomRight => default;

	public Vector3 MiddleLeft => default;

	public Vector3 MiddleCenter => default;

	public Vector3 MiddleRight => default;

	public Vector3 TopLeft => default;

	public Vector3 TopCenter => default;

	public Vector3 TopRight => default;

	private void Awake()
	{
	}

	public void ComputeResolution()
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
