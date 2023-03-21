using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Qrcode.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/decoder/Mode", DoNotGenerateAcw=true)]
	public sealed partial class Mode : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='ALPHANUMERIC']"
		[Register ("ALPHANUMERIC")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode? Alphanumeric {
			get {
				const string __id = "ALPHANUMERIC.Lcom/google/zxing/qrcode/decoder/Mode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='BYTE']"
		[Register ("BYTE")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode? Byte {
			get {
				const string __id = "BYTE.Lcom/google/zxing/qrcode/decoder/Mode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='ECI']"
		[Register ("ECI")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode? Eci {
			get {
				const string __id = "ECI.Lcom/google/zxing/qrcode/decoder/Mode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='FNC1_FIRST_POSITION']"
		[Register ("FNC1_FIRST_POSITION")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode? Fnc1FirstPosition {
			get {
				const string __id = "FNC1_FIRST_POSITION.Lcom/google/zxing/qrcode/decoder/Mode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='FNC1_SECOND_POSITION']"
		[Register ("FNC1_SECOND_POSITION")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode? Fnc1SecondPosition {
			get {
				const string __id = "FNC1_SECOND_POSITION.Lcom/google/zxing/qrcode/decoder/Mode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='HANZI']"
		[Register ("HANZI")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode? Hanzi {
			get {
				const string __id = "HANZI.Lcom/google/zxing/qrcode/decoder/Mode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='KANJI']"
		[Register ("KANJI")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode? Kanji {
			get {
				const string __id = "KANJI.Lcom/google/zxing/qrcode/decoder/Mode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='NUMERIC']"
		[Register ("NUMERIC")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode? Numeric {
			get {
				const string __id = "NUMERIC.Lcom/google/zxing/qrcode/decoder/Mode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='STRUCTURED_APPEND']"
		[Register ("STRUCTURED_APPEND")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode? StructuredAppend {
			get {
				const string __id = "STRUCTURED_APPEND.Lcom/google/zxing/qrcode/decoder/Mode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='TERMINATOR']"
		[Register ("TERMINATOR")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode? Terminator {
			get {
				const string __id = "TERMINATOR.Lcom/google/zxing/qrcode/decoder/Mode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/qrcode/decoder/Mode", typeof (Mode));

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

		internal Mode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe int Bits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/method[@name='getBits' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/method[@name='forBits' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("forBits", "(I)Lcom/google/zxing/qrcode/decoder/Mode;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.Mode? ForBits (int bits)
		{
			const string __id = "forBits.(I)Lcom/google/zxing/qrcode/decoder/Mode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bits);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/method[@name='getCharacterCountBits' and count(parameter)=1 and parameter[1][@type='com.google.zxing.qrcode.decoder.Version']]"
		[Register ("getCharacterCountBits", "(Lcom/google/zxing/qrcode/decoder/Version;)I", "")]
		public unsafe int GetCharacterCountBits (global::Com.Google.Zxing.Qrcode.Decoder.Version? version)
		{
			const string __id = "getCharacterCountBits.(Lcom/google/zxing/qrcode/decoder/Version;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((version == null) ? IntPtr.Zero : ((global::Java.Lang.Object) version).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (version);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/qrcode/decoder/Mode;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.Mode? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/zxing/qrcode/decoder/Mode;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/qrcode/decoder/Mode;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.Mode[]? Values ()
		{
			const string __id = "values.()[Lcom/google/zxing/qrcode/decoder/Mode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Google.Zxing.Qrcode.Decoder.Mode[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Qrcode.Decoder.Mode));
			} finally {
			}
		}

	}
}
