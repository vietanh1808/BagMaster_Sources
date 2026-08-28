using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Solo.MOST_IN_ONE
{
	public static class MOST_HapticFeedback
	{
		[Serializable]
		[Tooltip("Each element = one pulse")]
		public struct CustomHapticPattern
		{
			[Tooltip("IOS Pulse data")]
			public IOS_Haptic[] IOS_HapticPattern;

			[Tooltip("Android Pulse data")]
			public Android_Haptic[] Android_HapticPattern;

			public CustomHapticPattern(IOS_Haptic[] iosHaptic, Android_Haptic[] androidHaptic)
			{
				IOS_HapticPattern = null;
				Android_HapticPattern = null;
			}

			public readonly float GetDuration()
			{
				return 0f;
			}

			public readonly float IOSDuration()
			{
				return 0f;
			}

			public readonly float AndroidDuration()
			{
				return 0f;
			}
		}

		[Serializable]
		public struct IOS_Haptic
		{
			[Tooltip("Delay before starting this pulse in milliseconds")]
			public float Delay;

			[Tooltip("Haptic type of this pulse")]
			public HapticTypes PulseType;

			public IOS_Haptic(HapticTypes type, float delay)
			{
				Delay = 0f;
				PulseType = HapticTypes.Selection;
			}
		}

		[Serializable]
		public struct Android_Haptic
		{
			[Tooltip("Delay before starting this pulse in milliseconds")]
			public long Delay;

			[Tooltip("Pulse time in milliseconds")]
			public long PulseTime;

			[Tooltip("vibration Strength of the pulse\ninteger (0-255)")]
			public int PulseStrength;

			public Android_Haptic(long delay, long pattern, int amplitudes)
			{
				Delay = 0L;
				PulseTime = 0L;
				PulseStrength = 0;
			}
		}

		public enum HapticTypes
		{
			Selection = 0,
			Success = 1,
			Warning = 2,
			Failure = 3,
			LightImpact = 4,
			MediumImpact = 5,
			HeavyImpact = 6,
			RigidImpact = 7,
			SoftImpact = 8
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRunAndroidAsync_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CustomHapticPattern pattern;

			public CancellationToken token;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRunIOSAsync_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CustomHapticPattern pattern;

			public CancellationToken token;

			private IOS_Haptic[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private static bool _initialized;

		private static AndroidJavaObject _androidVibrator;

		private static AndroidJavaClass _vibrationEffectClass;

		private static int _androidApiLevel;

		private static float _lastHapticTime;

		private static float _hapticCooldown;

		private static Task _activePattern;

		private static CancellationTokenSource _cts;

		private static readonly object _lock;

		public static bool IsPlaying => false;

		public static bool HapticsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private static void IOSDefaultHapticsToAndroidPatterns(HapticTypes type, out long[] pattern, out int[] amplitudes)
		{
			pattern = null;
			amplitudes = null;
		}

		[RuntimeInitializeOnLoadMethod]
		private static void Initialize()
		{
		}

		public static void GenerateWithCooldown(HapticTypes type, float cooldown = -1f)
		{
		}

		public static void GeneratePattern(CustomHapticPattern pattern)
		{
		}

		private static Task RunPatternAsync(CustomHapticPattern pattern, CancellationToken token)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRunIOSAsync_003Ed__20))]
		private static Task RunIOSAsync(CustomHapticPattern pattern, CancellationToken token)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRunAndroidAsync_003Ed__21))]
		private static Task RunAndroidAsync(CustomHapticPattern pattern, CancellationToken token)
		{
			return null;
		}

		public static void Stop()
		{
		}

		public static void Generate(HapticTypes type)
		{
		}

		private static void InitializeAndroid()
		{
		}

		private static void GenerateAndroid(long[] pattern, int[] amplitudes)
		{
		}

		public static bool IsSupported()
		{
			return false;
		}
	}
}
