using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Multi.Qrcode.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.multi.qrcode.detector']/class[@name='MultiDetector']"
	[global::Android.Runtime.Register ("com/google/zxing/multi/qrcode/detector/MultiDetector", DoNotGenerateAcw=true)]
	public sealed partial class MultiDetector : global::Com.Google.Zxing.Qrcode.Detector.Detector {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/multi/qrcode/detector/MultiDetector", typeof (MultiDetector));

		internal static new IntPtr class_ref {
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

		internal MultiDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.multi.qrcode.detector']/class[@name='MultiDetector']/constructor[@name='MultiDetector' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;)V", "")]
		public unsafe MultiDetector (global::Com.Google.Zxing.Common.BitMatrix? image) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/zxing/common/BitMatrix;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (image);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi.qrcode.detector']/class[@name='MultiDetector']/method[@name='detectMulti' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("detectMulti", "(Ljava/util/Map;)[Lcom/google/zxing/common/DetectorResult;", "")]
		public unsafe global::Com.Google.Zxing.Common.DetectorResult[]? DetectMulti (global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object>? hints)
		{
			const string __id = "detectMulti.(Ljava/util/Map;)[Lcom/google/zxing/common/DetectorResult;";
			IntPtr native_hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (hints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hints);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (global::Com.Google.Zxing.Common.DetectorResult[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Common.DetectorResult));
			} finally {
				JNIEnv.DeleteLocalRef (native_hints);
				global::System.GC.KeepAlive (hints);
			}
		}

	}
}
