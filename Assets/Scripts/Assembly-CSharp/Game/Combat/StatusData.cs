using System;

namespace Game.Combat
{
	public class StatusData
	{
		public StatusType Type;

		public object Source;

		public Action ActivateAction;

		public Action EndAction;

		public Action PauseEffectAction;

		public Action ResumeEffectAction;

		public Func<bool> EndCondition;

		public float Interval;

		public float Duration;

		public float ActivateRate;

		public StatusManager Holder;

		public float CompareValue;

		public float Delay;

		private float _intervalTimer;

		private float _durationTimer;

		private float _delayTimer;

		private bool _effectPaused;

		public bool Completed { get; private set; }

		public bool Paused { get; private set; }

		public void Update(float deltaTime)
		{
		}

		public void Activate(bool resetTimer = true)
		{
		}

		public void PauseEffect()
		{
		}

		public void ResumeEffect()
		{
		}

		public void End()
		{
		}

		public void Remove()
		{
		}

		public void SetInterval(float normalizeValue)
		{
		}
	}
}
