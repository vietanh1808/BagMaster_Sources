using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class GlobalGizmoDrawer : Singleton<GlobalGizmoDrawer>
{
	private interface Shape
	{
		void Draw();
	}

	private class CricleDrawer : Shape
	{
		public Vector2 Anchor;

		public float Radius;

		public void Draw()
		{
		}
	}

	private class RectDrawer : Shape
	{
		public Vector2 Origin;

		public Vector2 Size;

		public void Draw()
		{
		}
	}

	private class ConeDrawer : Shape
	{
		public Vector2 Anchor;

		public float Radius;

		public float AngleSize;

		public void Draw()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CRemoveAfter_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public float duration;

		public GlobalGizmoDrawer _003C_003E4__this;

		public Shape shape;

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

	private List<Shape> _drawers;

	public void DrawRect(Vector2 origin, Vector2 size, float duration)
	{
	}

	public void DrawCircle(Vector2 anchor, float radius, float duration)
	{
	}

	public void DrawCone(Vector2 anchor, float radius, float angleSize, float duration)
	{
	}

	[AsyncStateMachine(typeof(_003CRemoveAfter_003Ed__8))]
	private UniTask RemoveAfter(Shape shape, float duration)
	{
		return default;
	}

	private void OnDrawGizmos()
	{
	}
}
