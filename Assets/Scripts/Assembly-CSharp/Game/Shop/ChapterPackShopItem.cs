using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Game.Shop
{
	public class ChapterPackShopItem : TimePackShopItem
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPrefab_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public ChapterPackShopItem _003C_003E4__this;

			public CancellationTokenSource cancellationToken;

			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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

		[Header("Chapter pack")]
		[SerializeField]
		private Image _bannerImage;

		[SerializeField]
		private string _bannerPathFormat;

		[Header("Runtime")]
		[SerializeField]
		private GameObject _currentBanner;

		private CancellationTokenSource _cancellationTokenSource;

		private AsyncOperationHandle<GameObject> _prefabHandle;

		private readonly HashSet<string> _trackedIapShopIds;

		public override void Initialize(ShopPackData package)
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void UpdateImage()
		{
		}

		[AsyncStateMachine(typeof(_003CGetPrefab_003Ed__10))]
		private UniTask GetPrefab(CancellationTokenSource cancellationToken)
		{
			return default;
		}

		public string GetAssetPath(string assetName)
		{
			return null;
		}

		protected override void UpdateNameText()
		{
		}
	}
}
