using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Pdf417.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/encoder/Compaction", DoNotGenerateAcw=true)]
	public sealed partial class Compaction : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']/field[@name='AUTO']"
		[Register ("AUTO")]
		public static global::Com.Google.Zxing.Pdf417.Encoder.Compaction? Auto {
			get {
				const string __id = "AUTO.Lcom/google/zxing/pdf417/encoder/Compaction;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Encoder.Compaction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']/field[@name='BYTE']"
		[Register ("BYTE")]
		public static global::Com.Google.Zxing.Pdf417.Encoder.Compaction? Byte {
			get {
				const string __id = "BYTE.Lcom/google/zxing/pdf417/encoder/Compaction;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Encoder.Compaction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']/field[@name='NUMERIC']"
		[Register ("NUMERIC")]
		public static global::Com.Google.Zxing.Pdf417.Encoder.Compaction? Numeric {
			get {
				const string __id = "NUMERIC.Lcom/google/zxing/pdf417/encoder/Compaction;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Encoder.Compaction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']/field[@name='TEXT']"
		[Register ("TEXT")]
		public static global::Com.Google.Zxing.Pdf417.Encoder.Compaction? Text {
			get {
				const string __id = "TEXT.Lcom/google/zxing/pdf417/encoder/Compaction;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Encoder.Compaction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/pdf417/encoder/Compaction", typeof (Compaction));

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

		internal Compaction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/pdf417/encoder/Compaction;", "")]
		public static unsafe global::Com.Google.Zxing.Pdf417.Encoder.Compaction? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/zxing/pdf417/encoder/Compaction;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Encoder.Compaction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/pdf417/encoder/Compaction;", "")]
		public static unsafe global::Com.Google.Zxing.Pdf417.Encoder.Compaction[]? Values ()
		{
			const string __id = "values.()[Lcom/google/zxing/pdf417/encoder/Compaction;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Google.Zxing.Pdf417.Encoder.Compaction[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Pdf417.Encoder.Compaction));
			} finally {
			}
		}

	}
}
