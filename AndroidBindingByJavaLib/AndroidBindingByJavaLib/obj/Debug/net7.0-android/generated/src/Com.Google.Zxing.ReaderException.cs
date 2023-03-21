using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='ReaderException']"
	[global::Android.Runtime.Register ("com/google/zxing/ReaderException", DoNotGenerateAcw=true)]
	public abstract partial class ReaderException : global::Java.Lang.Exception {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ReaderException']/field[@name='isStackTrace']"
		[Register ("isStackTrace")]
		protected static bool IsStackTrace {
			get {
				const string __id = "isStackTrace.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ReaderException']/field[@name='NO_TRACE']"
		[Register ("NO_TRACE")]
		protected static IList<Java.Lang.StackTraceElement>? NoTrace {
			get {
				const string __id = "NO_TRACE.[Ljava/lang/StackTraceElement;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<global::Java.Lang.StackTraceElement>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/ReaderException", typeof (ReaderException));

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

		protected ReaderException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ReaderException']/method[@name='fillInStackTrace' and count(parameter)=0]"
		[Register ("fillInStackTrace", "()Ljava/lang/Throwable;", "")]
		public override sealed unsafe global::Java.Lang.Throwable? FillInStackTrace ()
		{
			const string __id = "fillInStackTrace.()Ljava/lang/Throwable;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/ReaderException", DoNotGenerateAcw=true)]
	internal partial class ReaderExceptionInvoker : ReaderException {
		public ReaderExceptionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/ReaderException", typeof (ReaderExceptionInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
