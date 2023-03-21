using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Datamatrix.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolShapeHint']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/encoder/SymbolShapeHint", DoNotGenerateAcw=true)]
	public sealed partial class SymbolShapeHint : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolShapeHint']/field[@name='FORCE_NONE']"
		[Register ("FORCE_NONE")]
		public static global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint? ForceNone {
			get {
				const string __id = "FORCE_NONE.Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolShapeHint']/field[@name='FORCE_RECTANGLE']"
		[Register ("FORCE_RECTANGLE")]
		public static global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint? ForceRectangle {
			get {
				const string __id = "FORCE_RECTANGLE.Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolShapeHint']/field[@name='FORCE_SQUARE']"
		[Register ("FORCE_SQUARE")]
		public static global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint? ForceSquare {
			get {
				const string __id = "FORCE_SQUARE.Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/datamatrix/encoder/SymbolShapeHint", typeof (SymbolShapeHint));

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

		internal SymbolShapeHint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolShapeHint']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolShapeHint']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint[]? Values ()
		{
			const string __id = "values.()[Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint));
			} finally {
			}
		}

	}
}
