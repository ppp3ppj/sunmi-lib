using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Aztec.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='Encoder']"
	[global::Android.Runtime.Register ("com/google/zxing/aztec/encoder/Encoder", DoNotGenerateAcw=true)]
	public sealed partial class Encoder : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='Encoder']/field[@name='DEFAULT_AZTEC_LAYERS']"
		[Register ("DEFAULT_AZTEC_LAYERS")]
		public const int DefaultAztecLayers = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='Encoder']/field[@name='DEFAULT_EC_PERCENT']"
		[Register ("DEFAULT_EC_PERCENT")]
		public const int DefaultEcPercent = (int) 33;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/aztec/encoder/Encoder", typeof (Encoder));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='Encoder']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encode", "([B)Lcom/google/zxing/aztec/encoder/AztecCode;", "")]
		public static unsafe global::Com.Google.Zxing.Aztec.Encoder.AztecCode? Encode (byte[]? data)
		{
			const string __id = "encode.([B)Lcom/google/zxing/aztec/encoder/AztecCode;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.Encoder.AztecCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='Encoder']/method[@name='encode' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("encode", "([BII)Lcom/google/zxing/aztec/encoder/AztecCode;", "")]
		public static unsafe global::Com.Google.Zxing.Aztec.Encoder.AztecCode? Encode (byte[]? data, int minECCPercent, int userSpecifiedLayers)
		{
			const string __id = "encode.([BII)Lcom/google/zxing/aztec/encoder/AztecCode;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (minECCPercent);
				__args [2] = new JniArgumentValue (userSpecifiedLayers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.Encoder.AztecCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

	}
}
