using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityScreenNavigator.Runtime.Core.Sheet;

namespace Game.EventDungeon
{
	public class SheetPageEvent : Sheet
	{
		[SerializeField]
		private SheetPageLayoutBase pageLayoutPrefab;

		[SerializeField]
		private string trackingScreen;

		private CancellationTokenSource cts;

		public SheetPageLayoutBase CurrentLayout { get; private set; }

		private void OnDestroy()
		{
		}

		public override Task WillEnter()
		{
			return null;
		}

		private IEnumerable<EventDungeonUnlockViewState> GetDungeonEvents()
		{
			return null;
		}

		public override Task WillExit()
		{
			return null;
		}

		public override Task Cleanup()
		{
			return null;
		}

		private void InitCurrentLayout()
		{
		}

		public override void DidEnter()
		{
		}
	}
}
