using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Aztec.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.aztec.detector']/class[@name='Detector']"
	[global::Android.Runtime.Register ("com/google/zxing/aztec/detector/Detector", DoNotGenerateAcw=true)]
	public sealed partial class Detector : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/aztec/detector/Detector", typeof (Detector));

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

		internal Detector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.aztec.detector']/class[@name='Detector']/constructor[@name='Detector' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;)V", "")]
		public unsafe Detector (global::Com.Google.Zxing.Common.BitMatrix? image) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/zxing/common/BitMatrix;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (image);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.detector']/class[@name='Detector']/method[@name='detect' and count(parameter)=0]"
		[Register ("detect", "()Lcom/google/zxing/aztec/AztecDetectorResult;", "")]
		public unsafe global::Com.Google.Zxing.Aztec.AztecDetectorResult? Detect ()
		{
			const string __id = "detect.()Lcom/google/zxing/aztec/AztecDetectorResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.AztecDetectorResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.detector']/class[@name='Detector']/method[@name='detect' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("detect", "(Z)Lcom/google/zxing/aztec/AztecDetectorResult;", "")]
		public unsafe global::Com.Google.Zxing.Aztec.AztecDetectorResult? Detect (bool isMirror)
		{
			const string __id = "detect.(Z)Lcom/google/zxing/aztec/AztecDetectorResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isMirror);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.AztecDetectorResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
