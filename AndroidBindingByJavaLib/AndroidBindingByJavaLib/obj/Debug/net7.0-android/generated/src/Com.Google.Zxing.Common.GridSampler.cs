using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']"
	[global::Android.Runtime.Register ("com/google/zxing/common/GridSampler", DoNotGenerateAcw=true)]
	public abstract partial class GridSampler : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/common/GridSampler", typeof (GridSampler));

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

		protected GridSampler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/constructor[@name='GridSampler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GridSampler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Google.Zxing.Common.GridSampler? Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/google/zxing/common/GridSampler;", "")]
			get {
				const string __id = "getInstance.()Lcom/google/zxing/common/GridSampler;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.GridSampler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/method[@name='checkAndNudgePoints' and count(parameter)=2 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='float[]']]"
		[Register ("checkAndNudgePoints", "(Lcom/google/zxing/common/BitMatrix;[F)V", "")]
		protected static unsafe void CheckAndNudgePoints (global::Com.Google.Zxing.Common.BitMatrix? image, float[]? points)
		{
			const string __id = "checkAndNudgePoints.(Lcom/google/zxing/common/BitMatrix;[F)V";
			IntPtr native_points = JNIEnv.NewArray (points);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				__args [1] = new JniArgumentValue (native_points);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (points != null) {
					JNIEnv.CopyArray (native_points, points);
					JNIEnv.DeleteLocalRef (native_points);
				}
				global::System.GC.KeepAlive (image);
				global::System.GC.KeepAlive (points);
			}
		}

		static Delegate? cb_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_;
#pragma warning disable 0169
		static Delegate GetSampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_Handler ()
		{
			if (cb_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_ == null)
				cb_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_L) n_SampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_);
			return cb_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_;
		}

		static IntPtr n_SampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.GridSampler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.PerspectiveTransform> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SampleGrid (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/method[@name='sampleGrid' and count(parameter)=4 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.google.zxing.common.PerspectiveTransform']]"
		[Register ("sampleGrid", "(Lcom/google/zxing/common/BitMatrix;IILcom/google/zxing/common/PerspectiveTransform;)Lcom/google/zxing/common/BitMatrix;", "GetSampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_Handler")]
		public abstract global::Com.Google.Zxing.Common.BitMatrix? SampleGrid (global::Com.Google.Zxing.Common.BitMatrix? p0, int p1, int p2, global::Com.Google.Zxing.Common.PerspectiveTransform? p3);

		static Delegate? cb_sampleGrid_Lcom_google_zxing_common_BitMatrix_IIFFFFFFFFFFFFFFFF;
#pragma warning disable 0169
		static Delegate GetSampleGrid_Lcom_google_zxing_common_BitMatrix_IIFFFFFFFFFFFFFFFFHandler ()
		{
			if (cb_sampleGrid_Lcom_google_zxing_common_BitMatrix_IIFFFFFFFFFFFFFFFF == null)
				cb_sampleGrid_Lcom_google_zxing_common_BitMatrix_IIFFFFFFFFFFFFFFFF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIFFFFFFFFFFFFFFFF_L) n_SampleGrid_Lcom_google_zxing_common_BitMatrix_IIFFFFFFFFFFFFFFFF);
			return cb_sampleGrid_Lcom_google_zxing_common_BitMatrix_IIFFFFFFFFFFFFFFFF;
		}

		static IntPtr n_SampleGrid_Lcom_google_zxing_common_BitMatrix_IIFFFFFFFFFFFFFFFF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11, float p12, float p13, float p14, float p15, float p16, float p17, float p18)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.GridSampler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SampleGrid (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/method[@name='sampleGrid' and count(parameter)=19 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float'] and parameter[9][@type='float'] and parameter[10][@type='float'] and parameter[11][@type='float'] and parameter[12][@type='float'] and parameter[13][@type='float'] and parameter[14][@type='float'] and parameter[15][@type='float'] and parameter[16][@type='float'] and parameter[17][@type='float'] and parameter[18][@type='float'] and parameter[19][@type='float']]"
		[Register ("sampleGrid", "(Lcom/google/zxing/common/BitMatrix;IIFFFFFFFFFFFFFFFF)Lcom/google/zxing/common/BitMatrix;", "GetSampleGrid_Lcom_google_zxing_common_BitMatrix_IIFFFFFFFFFFFFFFFFHandler")]
		public abstract global::Com.Google.Zxing.Common.BitMatrix? SampleGrid (global::Com.Google.Zxing.Common.BitMatrix? p0, int p1, int p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11, float p12, float p13, float p14, float p15, float p16, float p17, float p18);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/method[@name='setGridSampler' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.GridSampler']]"
		[Register ("setGridSampler", "(Lcom/google/zxing/common/GridSampler;)V", "")]
		public static unsafe void SetGridSampler (global::Com.Google.Zxing.Common.GridSampler? newGridSampler)
		{
			const string __id = "setGridSampler.(Lcom/google/zxing/common/GridSampler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newGridSampler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newGridSampler).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (newGridSampler);
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/common/GridSampler", DoNotGenerateAcw=true)]
	internal partial class GridSamplerInvoker : GridSampler {
		public GridSamplerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/common/GridSampler", typeof (GridSamplerInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/method[@name='sampleGrid' and count(parameter)=4 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.google.zxing.common.PerspectiveTransform']]"
		[Register ("sampleGrid", "(Lcom/google/zxing/common/BitMatrix;IILcom/google/zxing/common/PerspectiveTransform;)Lcom/google/zxing/common/BitMatrix;", "GetSampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_Handler")]
		public override unsafe global::Com.Google.Zxing.Common.BitMatrix? SampleGrid (global::Com.Google.Zxing.Common.BitMatrix? p0, int p1, int p2, global::Com.Google.Zxing.Common.PerspectiveTransform? p3)
		{
			const string __id = "sampleGrid.(Lcom/google/zxing/common/BitMatrix;IILcom/google/zxing/common/PerspectiveTransform;)Lcom/google/zxing/common/BitMatrix;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/method[@name='sampleGrid' and count(parameter)=19 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float'] and parameter[9][@type='float'] and parameter[10][@type='float'] and parameter[11][@type='float'] and parameter[12][@type='float'] and parameter[13][@type='float'] and parameter[14][@type='float'] and parameter[15][@type='float'] and parameter[16][@type='float'] and parameter[17][@type='float'] and parameter[18][@type='float'] and parameter[19][@type='float']]"
		[Register ("sampleGrid", "(Lcom/google/zxing/common/BitMatrix;IIFFFFFFFFFFFFFFFF)Lcom/google/zxing/common/BitMatrix;", "GetSampleGrid_Lcom_google_zxing_common_BitMatrix_IIFFFFFFFFFFFFFFFFHandler")]
		public override unsafe global::Com.Google.Zxing.Common.BitMatrix? SampleGrid (global::Com.Google.Zxing.Common.BitMatrix? p0, int p1, int p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11, float p12, float p13, float p14, float p15, float p16, float p17, float p18)
		{
			const string __id = "sampleGrid.(Lcom/google/zxing/common/BitMatrix;IIFFFFFFFFFFFFFFFF)Lcom/google/zxing/common/BitMatrix;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [19];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (p7);
				__args [8] = new JniArgumentValue (p8);
				__args [9] = new JniArgumentValue (p9);
				__args [10] = new JniArgumentValue (p10);
				__args [11] = new JniArgumentValue (p11);
				__args [12] = new JniArgumentValue (p12);
				__args [13] = new JniArgumentValue (p13);
				__args [14] = new JniArgumentValue (p14);
				__args [15] = new JniArgumentValue (p15);
				__args [16] = new JniArgumentValue (p16);
				__args [17] = new JniArgumentValue (p17);
				__args [18] = new JniArgumentValue (p18);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
