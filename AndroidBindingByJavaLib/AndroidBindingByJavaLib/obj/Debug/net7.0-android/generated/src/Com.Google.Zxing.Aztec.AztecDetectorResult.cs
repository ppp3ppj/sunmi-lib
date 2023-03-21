using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Aztec {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.aztec']/class[@name='AztecDetectorResult']"
	[global::Android.Runtime.Register ("com/google/zxing/aztec/AztecDetectorResult", DoNotGenerateAcw=true)]
	public sealed partial class AztecDetectorResult : global::Com.Google.Zxing.Common.DetectorResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/aztec/AztecDetectorResult", typeof (AztecDetectorResult));

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

		internal AztecDetectorResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.aztec']/class[@name='AztecDetectorResult']/constructor[@name='AztecDetectorResult' and count(parameter)=5 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='com.google.zxing.ResultPoint[]'] and parameter[3][@type='boolean'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;[Lcom/google/zxing/ResultPoint;ZII)V", "")]
		public unsafe AztecDetectorResult (global::Com.Google.Zxing.Common.BitMatrix? bits, global::Com.Google.Zxing.ResultPoint[]? points, bool compact, int nbDatablocks, int nbLayers) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/zxing/common/BitMatrix;[Lcom/google/zxing/ResultPoint;ZII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_points = JNIEnv.NewArray (points);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((bits == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bits).Handle);
				__args [1] = new JniArgumentValue (native_points);
				__args [2] = new JniArgumentValue (compact);
				__args [3] = new JniArgumentValue (nbDatablocks);
				__args [4] = new JniArgumentValue (nbLayers);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (points != null) {
					JNIEnv.CopyArray (native_points, points);
					JNIEnv.DeleteLocalRef (native_points);
				}
				global::System.GC.KeepAlive (bits);
				global::System.GC.KeepAlive (points);
			}
		}

		public unsafe bool IsCompact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec']/class[@name='AztecDetectorResult']/method[@name='isCompact' and count(parameter)=0]"
			[Register ("isCompact", "()Z", "")]
			get {
				const string __id = "isCompact.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int NbDatablocks {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec']/class[@name='AztecDetectorResult']/method[@name='getNbDatablocks' and count(parameter)=0]"
			[Register ("getNbDatablocks", "()I", "")]
			get {
				const string __id = "getNbDatablocks.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int NbLayers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec']/class[@name='AztecDetectorResult']/method[@name='getNbLayers' and count(parameter)=0]"
			[Register ("getNbLayers", "()I", "")]
			get {
				const string __id = "getNbLayers.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
