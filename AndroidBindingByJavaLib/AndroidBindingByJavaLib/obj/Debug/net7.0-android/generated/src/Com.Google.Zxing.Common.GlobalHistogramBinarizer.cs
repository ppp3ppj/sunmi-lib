using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GlobalHistogramBinarizer']"
	[global::Android.Runtime.Register ("com/google/zxing/common/GlobalHistogramBinarizer", DoNotGenerateAcw=true)]
	public partial class GlobalHistogramBinarizer : global::Com.Google.Zxing.Binarizer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/common/GlobalHistogramBinarizer", typeof (GlobalHistogramBinarizer));

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

		protected GlobalHistogramBinarizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GlobalHistogramBinarizer']/constructor[@name='GlobalHistogramBinarizer' and count(parameter)=1 and parameter[1][@type='com.google.zxing.LuminanceSource']]"
		[Register (".ctor", "(Lcom/google/zxing/LuminanceSource;)V", "")]
		public unsafe GlobalHistogramBinarizer (global::Com.Google.Zxing.LuminanceSource? source) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/zxing/LuminanceSource;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (source);
			}
		}

		static Delegate? cb_getBlackMatrix;
#pragma warning disable 0169
		static Delegate GetGetBlackMatrixHandler ()
		{
			if (cb_getBlackMatrix == null)
				cb_getBlackMatrix = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBlackMatrix);
			return cb_getBlackMatrix;
		}

		static IntPtr n_GetBlackMatrix (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.GlobalHistogramBinarizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.BlackMatrix);
		}
#pragma warning restore 0169

		public override unsafe global::Com.Google.Zxing.Common.BitMatrix? BlackMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GlobalHistogramBinarizer']/method[@name='getBlackMatrix' and count(parameter)=0]"
			[Register ("getBlackMatrix", "()Lcom/google/zxing/common/BitMatrix;", "GetGetBlackMatrixHandler")]
			get {
				const string __id = "getBlackMatrix.()Lcom/google/zxing/common/BitMatrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_createBinarizer_Lcom_google_zxing_LuminanceSource_;
#pragma warning disable 0169
		static Delegate GetCreateBinarizer_Lcom_google_zxing_LuminanceSource_Handler ()
		{
			if (cb_createBinarizer_Lcom_google_zxing_LuminanceSource_ == null)
				cb_createBinarizer_Lcom_google_zxing_LuminanceSource_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateBinarizer_Lcom_google_zxing_LuminanceSource_);
			return cb_createBinarizer_Lcom_google_zxing_LuminanceSource_;
		}

		static IntPtr n_CreateBinarizer_Lcom_google_zxing_LuminanceSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.GlobalHistogramBinarizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var source = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateBinarizer (source));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GlobalHistogramBinarizer']/method[@name='createBinarizer' and count(parameter)=1 and parameter[1][@type='com.google.zxing.LuminanceSource']]"
		[Register ("createBinarizer", "(Lcom/google/zxing/LuminanceSource;)Lcom/google/zxing/Binarizer;", "GetCreateBinarizer_Lcom_google_zxing_LuminanceSource_Handler")]
		public override unsafe global::Com.Google.Zxing.Binarizer? CreateBinarizer (global::Com.Google.Zxing.LuminanceSource? source)
		{
			const string __id = "createBinarizer.(Lcom/google/zxing/LuminanceSource;)Lcom/google/zxing/Binarizer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Binarizer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (source);
			}
		}

		static Delegate? cb_getBlackRow_ILcom_google_zxing_common_BitArray_;
#pragma warning disable 0169
		static Delegate GetGetBlackRow_ILcom_google_zxing_common_BitArray_Handler ()
		{
			if (cb_getBlackRow_ILcom_google_zxing_common_BitArray_ == null)
				cb_getBlackRow_ILcom_google_zxing_common_BitArray_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_GetBlackRow_ILcom_google_zxing_common_BitArray_);
			return cb_getBlackRow_ILcom_google_zxing_common_BitArray_;
		}

		static IntPtr n_GetBlackRow_ILcom_google_zxing_common_BitArray_ (IntPtr jnienv, IntPtr native__this, int y, IntPtr native_row)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.GlobalHistogramBinarizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var row = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (native_row, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBlackRow (y, row));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GlobalHistogramBinarizer']/method[@name='getBlackRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray']]"
		[Register ("getBlackRow", "(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;", "GetGetBlackRow_ILcom_google_zxing_common_BitArray_Handler")]
		public override unsafe global::Com.Google.Zxing.Common.BitArray? GetBlackRow (int y, global::Com.Google.Zxing.Common.BitArray? row)
		{
			const string __id = "getBlackRow.(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (y);
				__args [1] = new JniArgumentValue ((row == null) ? IntPtr.Zero : ((global::Java.Lang.Object) row).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (row);
			}
		}

	}
}
