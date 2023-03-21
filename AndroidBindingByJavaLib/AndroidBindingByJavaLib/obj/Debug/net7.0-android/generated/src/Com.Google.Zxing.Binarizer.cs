using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='Binarizer']"
	[global::Android.Runtime.Register ("com/google/zxing/Binarizer", DoNotGenerateAcw=true)]
	public abstract partial class Binarizer : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/Binarizer", typeof (Binarizer));

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

		protected Binarizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='Binarizer']/constructor[@name='Binarizer' and count(parameter)=1 and parameter[1][@type='com.google.zxing.LuminanceSource']]"
		[Register (".ctor", "(Lcom/google/zxing/LuminanceSource;)V", "")]
		protected unsafe Binarizer (global::Com.Google.Zxing.LuminanceSource? source) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Binarizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.BlackMatrix);
		}
#pragma warning restore 0169

		public abstract global::Com.Google.Zxing.Common.BitMatrix? BlackMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Binarizer']/method[@name='getBlackMatrix' and count(parameter)=0]"
			[Register ("getBlackMatrix", "()Lcom/google/zxing/common/BitMatrix;", "GetGetBlackMatrixHandler")]
			get; 
		}

		public unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Binarizer']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "")]
			get {
				const string __id = "getHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Google.Zxing.LuminanceSource? LuminanceSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Binarizer']/method[@name='getLuminanceSource' and count(parameter)=0]"
			[Register ("getLuminanceSource", "()Lcom/google/zxing/LuminanceSource;", "")]
			get {
				const string __id = "getLuminanceSource.()Lcom/google/zxing/LuminanceSource;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Binarizer']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "")]
			get {
				const string __id = "getWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
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

		static IntPtr n_CreateBinarizer_Lcom_google_zxing_LuminanceSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Binarizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateBinarizer (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Binarizer']/method[@name='createBinarizer' and count(parameter)=1 and parameter[1][@type='com.google.zxing.LuminanceSource']]"
		[Register ("createBinarizer", "(Lcom/google/zxing/LuminanceSource;)Lcom/google/zxing/Binarizer;", "GetCreateBinarizer_Lcom_google_zxing_LuminanceSource_Handler")]
		public abstract global::Com.Google.Zxing.Binarizer? CreateBinarizer (global::Com.Google.Zxing.LuminanceSource? p0);

		static Delegate? cb_getBlackRow_ILcom_google_zxing_common_BitArray_;
#pragma warning disable 0169
		static Delegate GetGetBlackRow_ILcom_google_zxing_common_BitArray_Handler ()
		{
			if (cb_getBlackRow_ILcom_google_zxing_common_BitArray_ == null)
				cb_getBlackRow_ILcom_google_zxing_common_BitArray_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_GetBlackRow_ILcom_google_zxing_common_BitArray_);
			return cb_getBlackRow_ILcom_google_zxing_common_BitArray_;
		}

		static IntPtr n_GetBlackRow_ILcom_google_zxing_common_BitArray_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Binarizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBlackRow (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Binarizer']/method[@name='getBlackRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray']]"
		[Register ("getBlackRow", "(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;", "GetGetBlackRow_ILcom_google_zxing_common_BitArray_Handler")]
		public abstract global::Com.Google.Zxing.Common.BitArray? GetBlackRow (int p0, global::Com.Google.Zxing.Common.BitArray? p1);

	}

	[global::Android.Runtime.Register ("com/google/zxing/Binarizer", DoNotGenerateAcw=true)]
	internal partial class BinarizerInvoker : Binarizer {
		public BinarizerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/Binarizer", typeof (BinarizerInvoker));

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

		public override unsafe global::Com.Google.Zxing.Common.BitMatrix? BlackMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Binarizer']/method[@name='getBlackMatrix' and count(parameter)=0]"
			[Register ("getBlackMatrix", "()Lcom/google/zxing/common/BitMatrix;", "GetGetBlackMatrixHandler")]
			get {
				const string __id = "getBlackMatrix.()Lcom/google/zxing/common/BitMatrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Binarizer']/method[@name='createBinarizer' and count(parameter)=1 and parameter[1][@type='com.google.zxing.LuminanceSource']]"
		[Register ("createBinarizer", "(Lcom/google/zxing/LuminanceSource;)Lcom/google/zxing/Binarizer;", "GetCreateBinarizer_Lcom_google_zxing_LuminanceSource_Handler")]
		public override unsafe global::Com.Google.Zxing.Binarizer? CreateBinarizer (global::Com.Google.Zxing.LuminanceSource? p0)
		{
			const string __id = "createBinarizer.(Lcom/google/zxing/LuminanceSource;)Lcom/google/zxing/Binarizer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Binarizer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Binarizer']/method[@name='getBlackRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray']]"
		[Register ("getBlackRow", "(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;", "GetGetBlackRow_ILcom_google_zxing_common_BitArray_Handler")]
		public override unsafe global::Com.Google.Zxing.Common.BitArray? GetBlackRow (int p0, global::Com.Google.Zxing.Common.BitArray? p1)
		{
			const string __id = "getBlackRow.(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
