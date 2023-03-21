using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Datamatrix.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='HighLevelEncoder']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/encoder/HighLevelEncoder", DoNotGenerateAcw=true)]
	public sealed partial class HighLevelEncoder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/datamatrix/encoder/HighLevelEncoder", typeof (HighLevelEncoder));

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

		internal HighLevelEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='HighLevelEncoder']/method[@name='determineConsecutiveDigitCount' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int']]"
		[Register ("determineConsecutiveDigitCount", "(Ljava/lang/CharSequence;I)I", "")]
		public static unsafe int DetermineConsecutiveDigitCount (global::Java.Lang.ICharSequence? msg, int startpos)
		{
			const string __id = "determineConsecutiveDigitCount.(Ljava/lang/CharSequence;I)I";
			IntPtr native_msg = CharSequence.ToLocalJniHandle (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue (startpos);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (msg);
			}
		}

		public static int DetermineConsecutiveDigitCount (string? msg, int startpos)
		{
			var jls_msg = msg == null ? null : new global::Java.Lang.String (msg);
			int __result = DetermineConsecutiveDigitCount (jls_msg, startpos);
			var __rsval = __result;
			jls_msg?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='HighLevelEncoder']/method[@name='encodeHighLevel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeHighLevel", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? EncodeHighLevel (string? msg)
		{
			const string __id = "encodeHighLevel.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='HighLevelEncoder']/method[@name='encodeHighLevel' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.datamatrix.encoder.SymbolShapeHint'] and parameter[3][@type='com.google.zxing.Dimension'] and parameter[4][@type='com.google.zxing.Dimension']]"
		[Register ("encodeHighLevel", "(Ljava/lang/String;Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;Lcom/google/zxing/Dimension;Lcom/google/zxing/Dimension;)Ljava/lang/String;", "")]
		public static unsafe string? EncodeHighLevel (string? msg, global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint? shape, global::Com.Google.Zxing.Dimension? minSize, global::Com.Google.Zxing.Dimension? maxSize)
		{
			const string __id = "encodeHighLevel.(Ljava/lang/String;Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;Lcom/google/zxing/Dimension;Lcom/google/zxing/Dimension;)Ljava/lang/String;";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((shape == null) ? IntPtr.Zero : ((global::Java.Lang.Object) shape).Handle);
				__args [2] = new JniArgumentValue ((minSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) minSize).Handle);
				__args [3] = new JniArgumentValue ((maxSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxSize).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (shape);
				global::System.GC.KeepAlive (minSize);
				global::System.GC.KeepAlive (maxSize);
			}
		}

	}
}
