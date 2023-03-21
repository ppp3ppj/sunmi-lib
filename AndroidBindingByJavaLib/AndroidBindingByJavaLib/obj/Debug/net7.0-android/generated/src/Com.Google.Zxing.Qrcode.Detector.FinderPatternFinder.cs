using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Qrcode.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/detector/FinderPatternFinder", DoNotGenerateAcw=true)]
	public partial class FinderPatternFinder : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/field[@name='MAX_MODULES']"
		[Register ("MAX_MODULES")]
		protected const int MaxModules = (int) 57;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/field[@name='MIN_SKIP']"
		[Register ("MIN_SKIP")]
		protected const int MinSkip = (int) 3;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/qrcode/detector/FinderPatternFinder", typeof (FinderPatternFinder));

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

		protected FinderPatternFinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/constructor[@name='FinderPatternFinder' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;)V", "")]
		public unsafe FinderPatternFinder (global::Com.Google.Zxing.Common.BitMatrix? image) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/constructor[@name='FinderPatternFinder' and count(parameter)=2 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='com.google.zxing.ResultPointCallback']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;Lcom/google/zxing/ResultPointCallback;)V", "")]
		public unsafe FinderPatternFinder (global::Com.Google.Zxing.Common.BitMatrix? image, global::Com.Google.Zxing.IResultPointCallback? resultPointCallback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/zxing/common/BitMatrix;Lcom/google/zxing/ResultPointCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				__args [1] = new JniArgumentValue ((resultPointCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultPointCallback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (image);
				global::System.GC.KeepAlive (resultPointCallback);
			}
		}

		protected unsafe global::Com.Google.Zxing.Common.BitMatrix? Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/method[@name='getImage' and count(parameter)=0]"
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

		protected unsafe global::System.Collections.Generic.IList<global::Com.Google.Zxing.Qrcode.Detector.FinderPattern>? PossibleCenters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/method[@name='getPossibleCenters' and count(parameter)=0]"
			[Register ("getPossibleCenters", "()Ljava/util/List;", "")]
			get {
				const string __id = "getPossibleCenters.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Google.Zxing.Qrcode.Detector.FinderPattern>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/method[@name='foundPatternCross' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("foundPatternCross", "([I)Z", "")]
		protected static unsafe bool FoundPatternCross (int[]? stateCount)
		{
			const string __id = "foundPatternCross.([I)Z";
			IntPtr native_stateCount = JNIEnv.NewArray (stateCount);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stateCount);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (stateCount != null) {
					JNIEnv.CopyArray (native_stateCount, stateCount);
					JNIEnv.DeleteLocalRef (native_stateCount);
				}
				global::System.GC.KeepAlive (stateCount);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/method[@name='handlePossibleCenter' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("handlePossibleCenter", "([IIIZ)Z", "")]
		protected unsafe bool HandlePossibleCenter (int[]? stateCount, int i, int j, bool pureBarcode)
		{
			const string __id = "handlePossibleCenter.([IIIZ)Z";
			IntPtr native_stateCount = JNIEnv.NewArray (stateCount);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_stateCount);
				__args [1] = new JniArgumentValue (i);
				__args [2] = new JniArgumentValue (j);
				__args [3] = new JniArgumentValue (pureBarcode);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (stateCount != null) {
					JNIEnv.CopyArray (native_stateCount, stateCount);
					JNIEnv.DeleteLocalRef (native_stateCount);
				}
				global::System.GC.KeepAlive (stateCount);
			}
		}

	}
}
