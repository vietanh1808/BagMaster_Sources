using UnityEngine;

public class TestingZLegacy : MonoBehaviour
{
	public delegate void NextFunc();

	public enum TimingType
	{
		SteadyNormalTime = 0,
		IgnoreTimeScale = 1,
		HalfTimeScale = 2,
		VariableTimeScale = 3,
		Length = 4
	}

	public AnimationCurve customAnimationCurve;

	public Transform pt1;

	public Transform pt2;

	public Transform pt3;

	public Transform pt4;

	public Transform pt5;

	private int exampleIter;

	private string[] exampleFunctions;

	public bool useEstimatedTime;

	private GameObject ltLogo;

	private TimingType timingType;

	private int descrTimeScaleChangeId;

	private Vector3 origin;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void pauseNow()
	{
	}

	private void OnGUI()
	{
	}

	private void endlessCallback()
	{
	}

	private void cycleThroughExamples()
	{
	}

	public void updateValue3Example()
	{
	}

	public void updateValue3ExampleUpdate(Vector3 val)
	{
	}

	public void updateValue3ExampleCallback(Vector3 val)
	{
	}

	public void loopTestClamp()
	{
	}

	public void loopTestPingPong()
	{
	}

	public void colorExample()
	{
	}

	public void moveOnACurveExample()
	{
	}

	public void customTweenExample()
	{
	}

	public void moveExample()
	{
	}

	public void rotateExample()
	{
	}

	public void rotateOnUpdate(float val)
	{
	}

	public void rotateFinished(object hash)
	{
	}

	public void scaleExample()
	{
	}

	public void updateValueExample()
	{
	}

	public void updateValueExampleCallback(float val, object hash)
	{
	}

	public void delayedCallExample()
	{
	}

	public void delayedCallExampleCallback()
	{
	}

	public void alphaExample()
	{
	}

	public void moveLocalExample()
	{
	}

	public void rotateAroundExample()
	{
	}

	public void loopPause()
	{
	}

	public void loopResume()
	{
	}

	public void punchTest()
	{
	}
}
