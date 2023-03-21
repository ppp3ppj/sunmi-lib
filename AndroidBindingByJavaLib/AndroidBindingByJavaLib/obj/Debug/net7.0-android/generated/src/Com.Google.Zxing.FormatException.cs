using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='FormatException']"
	[global::Android.Runtime.Register ("com/google/zxing/FormatException", DoNotGenerateAcw=true)]
	public sealed partial class FormatException : global::Com.Google.Zxing.ReaderException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/FormatException", typeof (FormatException));

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

		internal FormatException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Com.Google.Zxing.FormatException? FormatInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='FormatException']/method[@name='getFormatInstance' and count(parameter)=0]"
			[Register ("getFormatInstance", "()Lcom/google/zxing/FormatException;", "")]
			get {
				const string __id = "getFormatInstance.()Lcom/google/zxing/FormatException;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.FormatException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='FormatException']/method[@name='getFormatInstance' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getFormatInstance", "(Ljava/lang/Throwable;)Lcom/google/zxing/FormatException;", "")]
		public static unsafe global::Com.Google.Zxing.FormatException? GetFormatInstance (global::Java.Lang.Throwable? cause)
		{
			const string __id = "getFormatInstance.(Ljava/lang/Throwable;)Lcom/google/zxing/FormatException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.FormatException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cause);
			}
		}

	}
}
