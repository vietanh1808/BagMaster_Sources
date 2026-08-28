using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Game.GUI
{
	public abstract class SelectionView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetView_003Ed__2<T, TPath> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public UniTask<T> task;

			public CancellationToken cancelToken;

			public TPath path;

			private UniTask<T>.Awaiter _003C_003Eu__1;

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
		private struct _003CPushView_003Ed__0<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string path;

			public CancellationToken cancelToken;

			private UniTask<T>.Awaiter _003C_003Eu__1;

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
		private struct _003CPushView_003Ed__1<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public UINameType uiType;

			public CancellationToken cancelToken;

			private UniTask<T>.Awaiter _003C_003Eu__1;

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

		[AsyncStateMachine(typeof(_003CPushView_003Ed__0<>))]
		protected static UniTask<T> PushView<T>(string path, CancellationToken cancelToken)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CPushView_003Ed__1<>))]
		protected static UniTask<T> PushView<T>(UINameType uiType, CancellationToken cancelToken)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CGetView_003Ed__2<, >))]
		private static UniTask<T> GetView<T, TPath>(TPath path, UniTask<T> task, CancellationToken cancelToken)
		{
			return default;
		}

		public static UniTask<TOutput> PushView<TOutput>(string path, in CancellationToken cancelToken = default(CancellationToken))
		{
			return default;
		}

		public static UniTask<TOutput> PushView<TInput, TOutput>(string path, TInput input, in CancellationToken cancelToken = default(CancellationToken))
		{
			return default;
		}

		public static UniTask<TOutput> PushView<TOutput>(UINameType uiType, in CancellationToken cancelToken = default(CancellationToken))
		{
			return default;
		}

		public static UniTask<TOutput> PushView<TInput, TOutput>(UINameType uiType, TInput input, in CancellationToken cancelToken = default(CancellationToken))
		{
			return default;
		}
	}
	public abstract class SelectionView<TOutput> : SelectionView
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPushView_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TOutput> _003C_003Et__builder;

			public string path;

			public CancellationToken cancelToken;

			private UniTask<SelectionView<TOutput>>.Awaiter _003C_003Eu__1;

			private UniTask<TOutput>.Awaiter _003C_003Eu__2;

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
		private struct _003CPushView_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TOutput> _003C_003Et__builder;

			public UINameType uiType;

			public CancellationToken cancelToken;

			private UniTask<SelectionView<TOutput>>.Awaiter _003C_003Eu__1;

			private UniTask<TOutput>.Awaiter _003C_003Eu__2;

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

		[AsyncStateMachine(typeof(SelectionView<>._003CPushView_003Ed__0))]
		public static UniTask<TOutput> PushView(string path, CancellationToken cancelToken = default(CancellationToken))
		{
			return default;
		}

		[AsyncStateMachine(typeof(SelectionView<>._003CPushView_003Ed__1))]
		public static UniTask<TOutput> PushView(UINameType uiType, CancellationToken cancelToken = default(CancellationToken))
		{
			return default;
		}

		public abstract UniTask<TOutput> Select(CancellationToken cancellationToken = default(CancellationToken));
	}
	public abstract class SelectionView<TInput, TOutput> : SelectionView
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPushView_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TOutput> _003C_003Et__builder;

			public string path;

			public CancellationToken cancelToken;

			public TInput input;

			private UniTask<SelectionView<TInput, TOutput>>.Awaiter _003C_003Eu__1;

			private UniTask<TOutput>.Awaiter _003C_003Eu__2;

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
		private struct _003CPushView_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TOutput> _003C_003Et__builder;

			public UINameType uiType;

			public CancellationToken cancelToken;

			public TInput input;

			private UniTask<SelectionView<TInput, TOutput>>.Awaiter _003C_003Eu__1;

			private UniTask<TOutput>.Awaiter _003C_003Eu__2;

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

		[AsyncStateMachine(typeof(SelectionView<, >._003CPushView_003Ed__0))]
		public static UniTask<TOutput> PushView(string path, TInput input, CancellationToken cancelToken = default(CancellationToken))
		{
			return default;
		}

		[AsyncStateMachine(typeof(SelectionView<, >._003CPushView_003Ed__1))]
		public static UniTask<TOutput> PushView(UINameType uiType, TInput input, CancellationToken cancelToken = default(CancellationToken))
		{
			return default;
		}

		public abstract UniTask<TOutput> Select(TInput input, CancellationToken cancellationToken = default(CancellationToken));
	}
}
