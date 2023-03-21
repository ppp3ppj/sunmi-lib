using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DetectorResult']"
	[global::Android.Runtime.Register ("com/google/zxing/common/DetectorResult", DoNotGenerateAcw=true)]
	public partial class DetectorResult : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/common/DetectorResult", typeof (DetectorResult));

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

		protected DetectorResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DetectorResult']/constructor[@name='DetectorResult' and count(parameter)=2 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='com.google.zxing.ResultPoint[]']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;[Lcom/google/zxing/ResultPoint;)V", "")]
		public unsafe DetectorResult (global::Com.Google.Zxing.Common.BitMatrix? bits, global::Com.Google.Zxing.ResultPoint[]? points) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/zxing/common/BitMatrix;[Lcom/google/zxing/ResultPoint;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_points = JNIEnv.NewArray (points);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bits == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bits).Handle);
				__args [1] = new JniArgumentValue (native_points);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (points != null) {
					JNIEnv.CopyArray (native_points, points);
					JNIEnv.DeleteLocalRef (native_points);
				}
				global::System.GC.KeepAlive (bits);
				global::System.GC.KeepAlive (points);
			}
		}

		public unsafe global::Com.Google.Zxing.Common.BitMatrix? Bits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DetectorResult']/method[@name='getBits' and count(parameter)=0]"
			[Register ("getBits", "()Lcom/google/zxing/common/BitMatrix;", "")]
			get {
				const string __id = "getBits.()Lcom/google/zxing/common/BitMatrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DetectorResult']/method[@name='getPoints' and count(parameter)=0]"
		[Register ("getPoints", "()[Lcom/google/zxing/ResultPoint;", "")]
		public unsafe global::Com.Google.Zxing.ResultPoint[]? GetPoints ()
		{
			const string __id = "getPoints.()[Lcom/google/zxing/ResultPoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (global::Com.Google.Zxing.ResultPoint[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.ResultPoint));
			} finally {
			}
		}

	}
}
