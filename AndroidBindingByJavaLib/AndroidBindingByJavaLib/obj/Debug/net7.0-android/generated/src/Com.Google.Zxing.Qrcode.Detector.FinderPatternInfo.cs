using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Qrcode.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternInfo']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/detector/FinderPatternInfo", DoNotGenerateAcw=true)]
	public sealed partial class FinderPatternInfo : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/qrcode/detector/FinderPatternInfo", typeof (FinderPatternInfo));

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

		internal FinderPatternInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternInfo']/constructor[@name='FinderPatternInfo' and count(parameter)=1 and parameter[1][@type='com.google.zxing.qrcode.detector.FinderPattern[]']]"
		[Register (".ctor", "([Lcom/google/zxing/qrcode/detector/FinderPattern;)V", "")]
		public unsafe FinderPatternInfo (global::Com.Google.Zxing.Qrcode.Detector.FinderPattern[]? patternCenters) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/google/zxing/qrcode/detector/FinderPattern;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_patternCenters = JNIEnv.NewArray (patternCenters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_patternCenters);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (patternCenters != null) {
					JNIEnv.CopyArray (native_patternCenters, patternCenters);
					JNIEnv.DeleteLocalRef (native_patternCenters);
				}
				global::System.GC.KeepAlive (patternCenters);
			}
		}

		public unsafe global::Com.Google.Zxing.Qrcode.Detector.FinderPattern? BottomLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternInfo']/method[@name='getBottomLeft' and count(parameter)=0]"
			[Register ("getBottomLeft", "()Lcom/google/zxing/qrcode/detector/FinderPattern;", "")]
			get {
				const string __id = "getBottomLeft.()Lcom/google/zxing/qrcode/detector/FinderPattern;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Detector.FinderPattern> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Google.Zxing.Qrcode.Detector.FinderPattern? TopLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternInfo']/method[@name='getTopLeft' and count(parameter)=0]"
			[Register ("getTopLeft", "()Lcom/google/zxing/qrcode/detector/FinderPattern;", "")]
			get {
				const string __id = "getTopLeft.()Lcom/google/zxing/qrcode/detector/FinderPattern;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Detector.FinderPattern> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Google.Zxing.Qrcode.Detector.FinderPattern? TopRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternInfo']/method[@name='getTopRight' and count(parameter)=0]"
			[Register ("getTopRight", "()Lcom/google/zxing/qrcode/detector/FinderPattern;", "")]
			get {
				const string __id = "getTopRight.()Lcom/google/zxing/qrcode/detector/FinderPattern;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Detector.FinderPattern> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
