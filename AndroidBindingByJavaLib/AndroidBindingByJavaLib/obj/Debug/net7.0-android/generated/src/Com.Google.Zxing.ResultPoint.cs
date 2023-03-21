using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']"
	[global::Android.Runtime.Register ("com/google/zxing/ResultPoint", DoNotGenerateAcw=true)]
	public partial class ResultPoint : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/ResultPoint", typeof (ResultPoint));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ResultPoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/constructor[@name='ResultPoint' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public unsafe ResultPoint (float x, float y) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='distance' and count(parameter)=2 and parameter[1][@type='com.google.zxing.ResultPoint'] and parameter[2][@type='com.google.zxing.ResultPoint']]"
		[Register ("distance", "(Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;)F", "")]
		public static unsafe float Distance (global::Com.Google.Zxing.ResultPoint? pattern1, global::Com.Google.Zxing.ResultPoint? pattern2)
		{
			const string __id = "distance.(Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((pattern1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pattern1).Handle);
				__args [1] = new JniArgumentValue ((pattern2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pattern2).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (pattern1);
				global::System.GC.KeepAlive (pattern2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed unsafe bool Equals (global::Java.Lang.Object? other)
		{
			const string __id = "equals.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()F", "")]
		public unsafe float GetX ()
		{
			const string __id = "getX.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()F", "")]
		public unsafe float GetY ()
		{
			const string __id = "getY.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed unsafe int GetHashCode ()
		{
			const string __id = "hashCode.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='orderBestPatterns' and count(parameter)=1 and parameter[1][@type='com.google.zxing.ResultPoint[]']]"
		[Register ("orderBestPatterns", "([Lcom/google/zxing/ResultPoint;)V", "")]
		public static unsafe void OrderBestPatterns (global::Com.Google.Zxing.ResultPoint[]? patterns)
		{
			const string __id = "orderBestPatterns.([Lcom/google/zxing/ResultPoint;)V";
			IntPtr native_patterns = JNIEnv.NewArray (patterns);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_patterns);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (patterns != null) {
					JNIEnv.CopyArray (native_patterns, patterns);
					JNIEnv.DeleteLocalRef (native_patterns);
				}
				global::System.GC.KeepAlive (patterns);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string? ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
