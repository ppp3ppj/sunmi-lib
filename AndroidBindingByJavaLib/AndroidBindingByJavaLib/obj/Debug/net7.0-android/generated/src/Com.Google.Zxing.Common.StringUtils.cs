using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='StringUtils']"
	[global::Android.Runtime.Register ("com/google/zxing/common/StringUtils", DoNotGenerateAcw=true)]
	public sealed partial class StringUtils : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='StringUtils']/field[@name='GB2312']"
		[Register ("GB2312")]
		public const string Gb2312 = (string) "GB2312";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='StringUtils']/field[@name='SHIFT_JIS']"
		[Register ("SHIFT_JIS")]
		public const string ShiftJis = (string) "SJIS";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/common/StringUtils", typeof (StringUtils));

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

		internal StringUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='StringUtils']/method[@name='guessEncoding' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("guessEncoding", "([BLjava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string? GuessEncoding (byte[]? bytes, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object>? hints)
		{
			const string __id = "guessEncoding.([BLjava/util/Map;)Ljava/lang/String;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			IntPtr native_hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (hints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (native_hints);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				JNIEnv.DeleteLocalRef (native_hints);
				global::System.GC.KeepAlive (bytes);
				global::System.GC.KeepAlive (hints);
			}
		}

	}
}
