using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Qrcode.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/detector/Detector", DoNotGenerateAcw=true)]
	public partial class Detector : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/qrcode/detector/Detector", typeof (Detector));

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

		protected Detector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/constructor[@name='Detector' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
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

		protected unsafe global::Com.Google.Zxing.Common.BitMatrix? Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Lcom/google/zxing/common/BitMatrix;", "")]
			get {
				const string __id = "getImage.()Lcom/google/zxing/common/BitMatrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected unsafe global::Com.Google.Zxing.IResultPointCallback? ResultPointCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='getResultPointCallback' and count(parameter)=0]"
			[Register ("getResultPointCallback", "()Lcom/google/zxing/ResultPointCallback;", "")]
			get {
				const string __id = "getResultPointCallback.()Lcom/google/zxing/ResultPointCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.IResultPointCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='calculateModuleSize' and count(parameter)=3 and parameter[1][@type='com.google.zxing.ResultPoint'] and parameter[2][@type='com.google.zxing.ResultPoint'] and parameter[3][@type='com.google.zxing.ResultPoint']]"
		[Register ("calculateModuleSize", "(Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;)F", "")]
		protected unsafe float CalculateModuleSize (global::Com.Google.Zxing.ResultPoint? topLeft, global::Com.Google.Zxing.ResultPoint? topRight, global::Com.Google.Zxing.ResultPoint? bottomLeft)
		{
			const string __id = "calculateModuleSize.(Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((topLeft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) topLeft).Handle);
				__args [1] = new JniArgumentValue ((topRight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) topRight).Handle);
				__args [2] = new JniArgumentValue ((bottomLeft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomLeft).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (topLeft);
				global::System.GC.KeepAlive (topRight);
				global::System.GC.KeepAlive (bottomLeft);
			}
		}

		static Delegate? cb_detect;
#pragma warning disable 0169
		static Delegate GetDetectHandler ()
		{
			if (cb_detect == null)
				cb_detect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Detect);
			return cb_detect;
		}

		static IntPtr n_Detect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Detector.Detector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Detect ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='detect' and count(parameter)=0]"
		[Register ("detect", "()Lcom/google/zxing/common/DetectorResult;", "GetDetectHandler")]
		public virtual unsafe global::Com.Google.Zxing.Common.DetectorResult? Detect ()
		{
			const string __id = "detect.()Lcom/google/zxing/common/DetectorResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DetectorResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='detect' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("detect", "(Ljava/util/Map;)Lcom/google/zxing/common/DetectorResult;", "")]
		public unsafe global::Com.Google.Zxing.Common.DetectorResult? Detect (global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object>? hints)
		{
			const string __id = "detect.(Ljava/util/Map;)Lcom/google/zxing/common/DetectorResult;";
			IntPtr native_hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (hints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hints);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DetectorResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hints);
				global::System.GC.KeepAlive (hints);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='findAlignmentInRegion' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float']]"
		[Register ("findAlignmentInRegion", "(FIIF)Lcom/google/zxing/qrcode/detector/AlignmentPattern;", "")]
		protected unsafe global::Com.Google.Zxing.Qrcode.Detector.AlignmentPattern? FindAlignmentInRegion (float overallEstModuleSize, int estAlignmentX, int estAlignmentY, float allowanceFactor)
		{
			const string __id = "findAlignmentInRegion.(FIIF)Lcom/google/zxing/qrcode/detector/AlignmentPattern;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (overallEstModuleSize);
				__args [1] = new JniArgumentValue (estAlignmentX);
				__args [2] = new JniArgumentValue (estAlignmentY);
				__args [3] = new JniArgumentValue (allowanceFactor);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Detector.AlignmentPattern> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='processFinderPatternInfo' and count(parameter)=1 and parameter[1][@type='com.google.zxing.qrcode.detector.FinderPatternInfo']]"
		[Register ("processFinderPatternInfo", "(Lcom/google/zxing/qrcode/detector/FinderPatternInfo;)Lcom/google/zxing/common/DetectorResult;", "")]
		protected unsafe global::Com.Google.Zxing.Common.DetectorResult? ProcessFinderPatternInfo (global::Com.Google.Zxing.Qrcode.Detector.FinderPatternInfo? info)
		{
			const string __id = "processFinderPatternInfo.(Lcom/google/zxing/qrcode/detector/FinderPatternInfo;)Lcom/google/zxing/common/DetectorResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DetectorResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (info);
			}
		}

	}
}
