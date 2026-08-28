using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game;
using Game.GUI;
using Game.Shop;
using UnityEngine;

public class ChapterPackOfferService
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public ChapterPackOfferService _003C_003E4__this;

		public ShopPackData offer;

		public ChapterPackOffer modal;

		public bool shown;

		internal bool _003CCheckShow_003Eb__0()
		{
			return false;
		}

		internal void _003CCheckShow_003Eb__1(ChapterPackOffer popup)
		{
		}

		internal bool _003CCheckShow_003Eb__2()
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCheckShow_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public ChapterPackOfferService _003C_003E4__this;

		public ChapterPackOfferLogic logic;

		public MonoBehaviour source;

		private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

		private UniTask.Awaiter _003C_003Eu__1;

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

	private readonly UnlockPopup _unlockPopup;

	private readonly Transform _shopButton;

	public ChapterPackOfferService(UnlockPopup unlockPopup, Transform shopButton)
	{
	}

	[AsyncStateMachine(typeof(_003CCheckShow_003Ed__3))]
	public UniTask CheckShow(ChapterPackOfferLogic logic, MonoBehaviour source)
	{
		return default;
	}

	private ShopPackData FindLowestPriceChapterPack()
	{
		return null;
	}

	private ShopPackData FindHighestPriceChapterPack()
	{
		return null;
	}

	private ShopPackData FindNewestChapterPack()
	{
		return null;
	}

	private ShopPackData FindNewChapterPack()
	{
		return null;
	}

	private bool VerifyPack(ShopPackData shopPackData)
	{
		return false;
	}
}
