using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Common.Reedsolomon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common.reedsolomon']/class[@name='ReedSolomonEncoder']"
	[global::Android.Runtime.Register ("com/google/zxing/common/reedsolomon/ReedSolomonEncoder", DoNotGenerateAcw=true)]
	public sealed partial class ReedSolomonEncoder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/common/reedsolomon/ReedSolomonEncoder", typeof (ReedSolomonEncoder));

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

		internal ReedSolomonEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common.reedsolomon']/class[@name='ReedSolomonEncoder']/constructor[@name='ReedSolomonEncoder' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.reedsolomon.GenericGF']]"
		[Register (".ctor", "(Lcom/google/zxing/common/reedsolomon/GenericGF;)V", "")]
		public unsafe ReedSolomonEncoder (global::Com.Google.Zxing.Common.Reedsolomon.GenericGF? field) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/zxing/common/reedsolomon/GenericGF;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((field == null) ? IntPtr.Zero : ((global::Java.Lang.Object) field).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (field);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common.reedsolomon']/class[@name='ReedSolomonEncoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("encode", "([II)V", "")]
		public unsafe void Encode (int[]? toEncode, int ecBytes)
		{
			const string __id = "encode.([II)V";
			IntPtr native_toEncode = JNIEnv.NewArray (toEncode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_toEncode);
				__args [1] = new JniArgumentValue (ecBytes);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (toEncode != null) {
					JNIEnv.CopyArray (native_toEncode, toEncode);
					JNIEnv.DeleteLocalRef (native_toEncode);
				}
				global::System.GC.KeepAlive (toEncode);
			}
		}

	}
}
