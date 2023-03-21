using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Qrcode.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='Encoder']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/encoder/Encoder", DoNotGenerateAcw=true)]
	public sealed partial class Encoder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/qrcode/encoder/Encoder", typeof (Encoder));

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

		internal Encoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='Encoder']/method[@name='chooseMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("chooseMode", "(Ljava/lang/String;)Lcom/google/zxing/qrcode/decoder/Mode;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.Mode? ChooseMode (string? content)
		{
			const string __id = "chooseMode.(Ljava/lang/String;)Lcom/google/zxing/qrcode/decoder/Mode;";
			IntPtr native_content = JNIEnv.NewString ((string?)content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_content);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_content);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='Encoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.qrcode.decoder.ErrorCorrectionLevel']]"
		[Register ("encode", "(Ljava/lang/String;Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;)Lcom/google/zxing/qrcode/encoder/QRCode;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Encoder.QRCode? Encode (string? content, global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel? ecLevel)
		{
			const string __id = "encode.(Ljava/lang/String;Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;)Lcom/google/zxing/qrcode/encoder/QRCode;";
			IntPtr native_content = JNIEnv.NewString ((string?)content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_content);
				__args [1] = new JniArgumentValue ((ecLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ecLevel).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Encoder.QRCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_content);
				global::System.GC.KeepAlive (ecLevel);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='Encoder']/method[@name='encode' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.qrcode.decoder.ErrorCorrectionLevel'] and parameter[3][@type='java.util.Map&lt;com.google.zxing.EncodeHintType, ?&gt;']]"
		[Register ("encode", "(Ljava/lang/String;Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;Ljava/util/Map;)Lcom/google/zxing/qrcode/encoder/QRCode;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Encoder.QRCode? Encode (string? content, global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel? ecLevel, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.EncodeHintType, object>? hints)
		{
			const string __id = "encode.(Ljava/lang/String;Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;Ljava/util/Map;)Lcom/google/zxing/qrcode/encoder/QRCode;";
			IntPtr native_content = JNIEnv.NewString ((string?)content);
			IntPtr native_hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.EncodeHintType, object>.ToLocalJniHandle (hints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_content);
				__args [1] = new JniArgumentValue ((ecLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ecLevel).Handle);
				__args [2] = new JniArgumentValue (native_hints);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Encoder.QRCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_content);
				JNIEnv.DeleteLocalRef (native_hints);
				global::System.GC.KeepAlive (ecLevel);
				global::System.GC.KeepAlive (hints);
			}
		}

	}
}
