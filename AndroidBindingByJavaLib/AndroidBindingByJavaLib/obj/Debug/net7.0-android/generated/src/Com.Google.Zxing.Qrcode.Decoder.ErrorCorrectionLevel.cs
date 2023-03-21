using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Qrcode.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/decoder/ErrorCorrectionLevel", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCorrectionLevel : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/field[@name='H']"
		[Register ("H")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel? H {
			get {
				const string __id = "H.Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/field[@name='L']"
		[Register ("L")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel? L {
			get {
				const string __id = "L.Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/field[@name='M']"
		[Register ("M")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel? M {
			get {
				const string __id = "M.Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/field[@name='Q']"
		[Register ("Q")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel? Q {
			get {
				const string __id = "Q.Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/qrcode/decoder/ErrorCorrectionLevel", typeof (ErrorCorrectionLevel));

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

		internal ErrorCorrectionLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe int Bits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/method[@name='getBits' and count(parameter)=0]"
			[Register ("getBits", "()I", "")]
			get {
				const string __id = "getBits.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/method[@name='forBits' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("forBits", "(I)Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel? ForBits (int bits)
		{
			const string __id = "forBits.(I)Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bits);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel[]? Values ()
		{
			const string __id = "values.()[Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel));
			} finally {
			}
		}

	}
}
