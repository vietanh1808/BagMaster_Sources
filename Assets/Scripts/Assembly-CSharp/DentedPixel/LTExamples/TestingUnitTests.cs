using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DentedPixel.LTExamples
{
	public class TestingUnitTests : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			public TestingUnitTests _003C_003E4__this;

			public int pauseCount;

			public GameObject cubeRound;

			public Vector3 onStartPos;

			public Vector3 onStartPosSpline;

			public GameObject cubeSpline;

			public GameObject cubeSeq;

			public GameObject cubeBounds;

			public bool didPassBounds;

			public Vector3 failPoint;

			public int setOnStartNum;

			public bool setPosOnUpdate;

			public int setPosNum;

			public bool hasGroupTweensCheckStarted;

			public float previousXlt4;

			public bool onUpdateWasCalled;

			public float start;

			public float expectedTime;

			public bool didGetCorrectOnUpdate;

			public Action _003C_003E9__13;

			public Action<Vector3> _003C_003E9__14;

			public Action _003C_003E9__16;

			public Action<object> _003C_003E9__15;

			internal void _003CtimeBasedTesting_003Eb__0()
			{
			}

			internal void _003CtimeBasedTesting_003Eb__1()
			{
			}

			internal void _003CtimeBasedTesting_003Eb__2(float val)
			{
			}

			internal void _003CtimeBasedTesting_003Eb__3()
			{
			}

			internal void _003CtimeBasedTesting_003Eb__4()
			{
			}

			internal void _003CtimeBasedTesting_003Eb__5()
			{
			}

			internal void _003CtimeBasedTesting_003Eb__6(float val)
			{
			}

			internal void _003CtimeBasedTesting_003Eb__7()
			{
			}

			internal void _003CtimeBasedTesting_003Eb__13()
			{
			}

			internal void _003CtimeBasedTesting_003Eb__14(Vector3 newPosition)
			{
			}

			internal void _003CtimeBasedTesting_003Eb__15(object param)
			{
			}

			internal void _003CtimeBasedTesting_003Eb__16()
			{
			}

			internal void _003CtimeBasedTesting_003Eb__8()
			{
			}

			internal void _003CtimeBasedTesting_003Eb__9(float val)
			{
			}

			internal void _003CtimeBasedTesting_003Eb__10()
			{
			}

			internal void _003CtimeBasedTesting_003Eb__11(Vector3 val)
			{
			}

			internal void _003CtimeBasedTesting_003Eb__12()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003ClotsOfCancels_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TestingUnitTests _003C_003E4__this;

			private int _003CcubeCount_003E5__2;

			private int[] _003CtweensA_003E5__3;

			private GameObject[] _003CaGOs_003E5__4;

			private int[] _003CtweensB_003E5__5;

			private GameObject[] _003CbGOs_003E5__6;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003ClotsOfCancels_003Ed__25(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CpauseTimeNow_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TestingUnitTests _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CpauseTimeNow_003Ed__26(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CtimeBasedTesting_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TestingUnitTests _003C_003E4__this;

			private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

			private int _003CdescriptionMatchCount_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CtimeBasedTesting_003Ed__24(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public GameObject cube1;

		public GameObject cube2;

		public GameObject cube3;

		public GameObject cube4;

		public GameObject cubeAlpha1;

		public GameObject cubeAlpha2;

		private bool eventGameObjectWasCalled;

		private bool eventGeneralWasCalled;

		private int lt1Id;

		private LTDescr lt2;

		private LTDescr lt3;

		private LTDescr lt4;

		private LTDescr[] groupTweens;

		private GameObject[] groupGOs;

		private int groupTweensCnt;

		private int rotateRepeat;

		private int rotateRepeatAngle;

		private GameObject boxNoCollider;

		private float timeElapsedNormalTimeScale;

		private float timeElapsedIgnoreTimeScale;

		private bool pauseTweenDidFinish;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private GameObject cubeNamed(string name)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CtimeBasedTesting_003Ed__24))]
		private IEnumerator timeBasedTesting()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003ClotsOfCancels_003Ed__25))]
		private IEnumerator lotsOfCancels()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CpauseTimeNow_003Ed__26))]
		private IEnumerator pauseTimeNow()
		{
			return null;
		}

		private void rotateRepeatFinished()
		{
		}

		private void rotateRepeatAllFinished()
		{
		}

		private void eventGameObjectCalled(LTEvent e)
		{
		}

		private void eventGeneralCalled(LTEvent e)
		{
		}
	}
}
