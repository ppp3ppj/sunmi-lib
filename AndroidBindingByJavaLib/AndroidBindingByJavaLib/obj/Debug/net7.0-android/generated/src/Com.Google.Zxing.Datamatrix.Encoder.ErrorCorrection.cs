using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Datamatrix.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='ErrorCorrection']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/encoder/ErrorCorrection", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCorrection : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/datamatrix/encoder/ErrorCorrection", typeof (ErrorCorrection));

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

		internal ErrorCorrection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='ErrorCorrection']/method[@name='encodeECC200' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.datamatrix.encoder.SymbolInfo']]"
		[Register ("encodeECC200", "(Ljava/lang/String;Lcom/google/zxing/datamatrix/encoder/SymbolInfo;)Ljava/lang/String;", "")]
		public static unsafe string? EncodeECC200 (string? codewords, global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo? symbolInfo)
		{
			const string __id = "encodeECC200.(Ljava/lang/String;Lcom/google/zxing/datamatrix/encoder/SymbolInfo;)Ljava/lang/String;";
			IntPtr native_codewords = JNIEnv.NewString ((string?)codewords);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_codewords);
				__args [1] = new JniArgumentValue ((symbolInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) symbolInfo).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_codewords);
				global::System.GC.KeepAlive (symbolInfo);
			}
		}

	}
}
