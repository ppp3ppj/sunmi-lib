using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Pdf417.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.detector']/class[@name='Detector']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/detector/Detector", DoNotGenerateAcw=true)]
	public sealed partial class Detector : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/pdf417/detector/Detector", typeof (Detector));

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

		internal Detector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.detector']/class[@name='Detector']/method[@name='detect' and count(parameter)=3 and parameter[1][@type='com.google.zxing.BinaryBitmap'] and parameter[2][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;'] and parameter[3][@type='boolean']]"
		[Register ("detect", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;Z)Lcom/google/zxing/pdf417/detector/PDF417DetectorResult;", "")]
		public static unsafe global::Com.Google.Zxing.Pdf417.Detector.PDF417DetectorResult? Detect (global::Com.Google.Zxing.BinaryBitmap? image, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object>? hints, bool multiple)
		{
			const string __id = "detect.(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;Z)Lcom/google/zxing/pdf417/detector/PDF417DetectorResult;";
			IntPtr native_hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (hints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				__args [1] = new JniArgumentValue (native_hints);
				__args [2] = new JniArgumentValue (multiple);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Detector.PDF417DetectorResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hints);
				global::System.GC.KeepAlive (image);
				global::System.GC.KeepAlive (hints);
			}
		}

	}
}
