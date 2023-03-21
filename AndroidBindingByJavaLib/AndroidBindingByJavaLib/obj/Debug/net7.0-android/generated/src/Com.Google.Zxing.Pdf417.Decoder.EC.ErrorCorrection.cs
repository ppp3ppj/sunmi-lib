using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Pdf417.Decoder.EC {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.decoder.ec']/class[@name='ErrorCorrection']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/decoder/ec/ErrorCorrection", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCorrection : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/pdf417/decoder/ec/ErrorCorrection", typeof (ErrorCorrection));

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.pdf417.decoder.ec']/class[@name='ErrorCorrection']/constructor[@name='ErrorCorrection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorCorrection () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.decoder.ec']/class[@name='ErrorCorrection']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("decode", "([II[I)I", "")]
		public unsafe int Decode (int[]? received, int numECCodewords, int[]? erasures)
		{
			const string __id = "decode.([II[I)I";
			IntPtr native_received = JNIEnv.NewArray (received);
			IntPtr native_erasures = JNIEnv.NewArray (erasures);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_received);
				__args [1] = new JniArgumentValue (numECCodewords);
				__args [2] = new JniArgumentValue (native_erasures);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (received != null) {
					JNIEnv.CopyArray (native_received, received);
					JNIEnv.DeleteLocalRef (native_received);
				}
				if (erasures != null) {
					JNIEnv.CopyArray (native_erasures, erasures);
					JNIEnv.DeleteLocalRef (native_erasures);
				}
				global::System.GC.KeepAlive (received);
				global::System.GC.KeepAlive (erasures);
			}
		}

	}
}
