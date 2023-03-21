using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Multi.Qrcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.multi.qrcode']/class[@name='QRCodeMultiReader']"
	[global::Android.Runtime.Register ("com/google/zxing/multi/qrcode/QRCodeMultiReader", DoNotGenerateAcw=true)]
	public sealed partial class QRCodeMultiReader : global::Com.Google.Zxing.Qrcode.QRCodeReader, global::Com.Google.Zxing.Multi.IMultipleBarcodeReader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/multi/qrcode/QRCodeMultiReader", typeof (QRCodeMultiReader));

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

		internal QRCodeMultiReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.multi.qrcode']/class[@name='QRCodeMultiReader']/constructor[@name='QRCodeMultiReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QRCodeMultiReader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi.qrcode']/class[@name='QRCodeMultiReader']/method[@name='decodeMultiple' and count(parameter)=1 and parameter[1][@type='com.google.zxing.BinaryBitmap']]"
		[Register ("decodeMultiple", "(Lcom/google/zxing/BinaryBitmap;)[Lcom/google/zxing/Result;", "")]
		public unsafe global::Com.Google.Zxing.Result[]? DecodeMultiple (global::Com.Google.Zxing.BinaryBitmap? image)
		{
			const string __id = "decodeMultiple.(Lcom/google/zxing/BinaryBitmap;)[Lcom/google/zxing/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (global::Com.Google.Zxing.Result[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Result));
			} finally {
				global::System.GC.KeepAlive (image);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi.qrcode']/class[@name='QRCodeMultiReader']/method[@name='decodeMultiple' and count(parameter)=2 and parameter[1][@type='com.google.zxing.BinaryBitmap'] and parameter[2][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decodeMultiple", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)[Lcom/google/zxing/Result;", "")]
		public unsafe global::Com.Google.Zxing.Result[]? DecodeMultiple (global::Com.Google.Zxing.BinaryBitmap? image, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object>? hints)
		{
			const string __id = "decodeMultiple.(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)[Lcom/google/zxing/Result;";
			IntPtr native_hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (hints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				__args [1] = new JniArgumentValue (native_hints);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (global::Com.Google.Zxing.Result[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Result));
			} finally {
				JNIEnv.DeleteLocalRef (native_hints);
				global::System.GC.KeepAlive (image);
				global::System.GC.KeepAlive (hints);
			}
		}

	}
}
