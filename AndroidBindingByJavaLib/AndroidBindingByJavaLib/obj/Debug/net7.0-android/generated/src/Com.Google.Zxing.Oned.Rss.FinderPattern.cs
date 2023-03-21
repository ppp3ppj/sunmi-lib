using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Oned.Rss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='FinderPattern']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/rss/FinderPattern", DoNotGenerateAcw=true)]
	public sealed partial class FinderPattern : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/oned/rss/FinderPattern", typeof (FinderPattern));

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

		internal FinderPattern (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='FinderPattern']/constructor[@name='FinderPattern' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(I[IIII)V", "")]
		public unsafe FinderPattern (int value, int[]? startEnd, int start, int end, int rowNumber) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I[IIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_startEnd = JNIEnv.NewArray (startEnd);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (value);
				__args [1] = new JniArgumentValue (native_startEnd);
				__args [2] = new JniArgumentValue (start);
				__args [3] = new JniArgumentValue (end);
				__args [4] = new JniArgumentValue (rowNumber);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (startEnd != null) {
					JNIEnv.CopyArray (native_startEnd, startEnd);
					JNIEnv.DeleteLocalRef (native_startEnd);
				}
				global::System.GC.KeepAlive (startEnd);
			}
		}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='FinderPattern']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "")]
			get {
				const string __id = "getValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='FinderPattern']/method[@name='getResultPoints' and count(parameter)=0]"
		[Register ("getResultPoints", "()[Lcom/google/zxing/ResultPoint;", "")]
		public unsafe global::Com.Google.Zxing.ResultPoint[]? GetResultPoints ()
		{
			const string __id = "getResultPoints.()[Lcom/google/zxing/ResultPoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::Com.Google.Zxing.ResultPoint[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.ResultPoint));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='FinderPattern']/method[@name='getStartEnd' and count(parameter)=0]"
		[Register ("getStartEnd", "()[I", "")]
		public unsafe int[]? GetStartEnd ()
		{
			const string __id = "getStartEnd.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

	}
}
