using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Pdf417.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.detector']/class[@name='PDF417DetectorResult']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/detector/PDF417DetectorResult", DoNotGenerateAcw=true)]
	public sealed partial class PDF417DetectorResult : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/pdf417/detector/PDF417DetectorResult", typeof (PDF417DetectorResult));

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

		internal PDF417DetectorResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.pdf417.detector']/class[@name='PDF417DetectorResult']/constructor[@name='PDF417DetectorResult' and count(parameter)=2 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='java.util.List&lt;com.google.zxing.ResultPoint[]&gt;']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;Ljava/util/List;)V", "")]
		public unsafe PDF417DetectorResult (global::Com.Google.Zxing.Common.BitMatrix? bits, global::System.Collections.Generic.IList<global::Com.Google.Zxing.ResultPoint[]>? points) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/zxing/common/BitMatrix;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_points = global::Android.Runtime.JavaList<global::Com.Google.Zxing.ResultPoint[]>.ToLocalJniHandle (points);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bits == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bits).Handle);
				__args [1] = new JniArgumentValue (native_points);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_points);
				global::System.GC.KeepAlive (bits);
				global::System.GC.KeepAlive (points);
			}
		}

		public unsafe global::Com.Google.Zxing.Common.BitMatrix? Bits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.detector']/class[@name='PDF417DetectorResult']/method[@name='getBits' and count(parameter)=0]"
			[Register ("getBits", "()Lcom/google/zxing/common/BitMatrix;", "")]
			get {
				const string __id = "getBits.()Lcom/google/zxing/common/BitMatrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Google.Zxing.ResultPoint[]>? Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.detector']/class[@name='PDF417DetectorResult']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "")]
			get {
				const string __id = "getPoints.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Google.Zxing.ResultPoint[]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
