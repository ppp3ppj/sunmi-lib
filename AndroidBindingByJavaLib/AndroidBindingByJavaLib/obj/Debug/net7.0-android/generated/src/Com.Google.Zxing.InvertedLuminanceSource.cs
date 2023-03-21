using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='InvertedLuminanceSource']"
	[global::Android.Runtime.Register ("com/google/zxing/InvertedLuminanceSource", DoNotGenerateAcw=true)]
	public sealed partial class InvertedLuminanceSource : global::Com.Google.Zxing.LuminanceSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/InvertedLuminanceSource", typeof (InvertedLuminanceSource));

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

		internal InvertedLuminanceSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='InvertedLuminanceSource']/constructor[@name='InvertedLuminanceSource' and count(parameter)=1 and parameter[1][@type='com.google.zxing.LuminanceSource']]"
		[Register (".ctor", "(Lcom/google/zxing/LuminanceSource;)V", "")]
		public unsafe InvertedLuminanceSource (global::Com.Google.Zxing.LuminanceSource? @delegate) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/zxing/LuminanceSource;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@delegate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @delegate).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@delegate);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='InvertedLuminanceSource']/method[@name='getMatrix' and count(parameter)=0]"
		[Register ("getMatrix", "()[B", "")]
		public override unsafe byte[]? GetMatrix ()
		{
			const string __id = "getMatrix.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='InvertedLuminanceSource']/method[@name='getRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("getRow", "(I[B)[B", "")]
		public override unsafe byte[]? GetRow (int y, byte[]? row)
		{
			const string __id = "getRow.(I[B)[B";
			IntPtr native_row = JNIEnv.NewArray (row);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (y);
				__args [1] = new JniArgumentValue (native_row);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (row != null) {
					JNIEnv.CopyArray (native_row, row);
					JNIEnv.DeleteLocalRef (native_row);
				}
				global::System.GC.KeepAlive (row);
			}
		}

	}
}
