using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Oned {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCAReader']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/UPCAReader", DoNotGenerateAcw=true)]
	public sealed partial class UPCAReader : global::Com.Google.Zxing.Oned.UPCEANReader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/oned/UPCAReader", typeof (UPCAReader));

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

		internal UPCAReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCAReader']/constructor[@name='UPCAReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UPCAReader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCAReader']/method[@name='decodeMiddle' and count(parameter)=3 and parameter[1][@type='com.google.zxing.common.BitArray'] and parameter[2][@type='int[]'] and parameter[3][@type='java.lang.StringBuilder']]"
		[Register ("decodeMiddle", "(Lcom/google/zxing/common/BitArray;[ILjava/lang/StringBuilder;)I", "")]
		protected override unsafe int DecodeMiddle (global::Com.Google.Zxing.Common.BitArray? row, int[]? startRange, global::Java.Lang.StringBuilder? resultString)
		{
			const string __id = "decodeMiddle.(Lcom/google/zxing/common/BitArray;[ILjava/lang/StringBuilder;)I";
			IntPtr native_startRange = JNIEnv.NewArray (startRange);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((row == null) ? IntPtr.Zero : ((global::Java.Lang.Object) row).Handle);
				__args [1] = new JniArgumentValue (native_startRange);
				__args [2] = new JniArgumentValue ((resultString == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultString).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (startRange != null) {
					JNIEnv.CopyArray (native_startRange, startRange);
					JNIEnv.DeleteLocalRef (native_startRange);
				}
				global::System.GC.KeepAlive (row);
				global::System.GC.KeepAlive (startRange);
				global::System.GC.KeepAlive (resultString);
			}
		}

	}
}
