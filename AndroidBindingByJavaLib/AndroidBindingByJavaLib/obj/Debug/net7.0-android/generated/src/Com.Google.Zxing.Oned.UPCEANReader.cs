using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Oned {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCEANReader']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/UPCEANReader", DoNotGenerateAcw=true)]
	public abstract partial class UPCEANReader : global::Com.Google.Zxing.Oned.OneDReader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/oned/UPCEANReader", typeof (UPCEANReader));

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

		protected UPCEANReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCEANReader']/constructor[@name='UPCEANReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe UPCEANReader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_;
#pragma warning disable 0169
		static Delegate GetDecodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_Handler ()
		{
			if (cb_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_ == null)
				cb_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_DecodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_);
			return cb_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_;
		}

		static int n_DecodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.UPCEANReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (int[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DecodeMiddle (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCEANReader']/method[@name='decodeMiddle' and count(parameter)=3 and parameter[1][@type='com.google.zxing.common.BitArray'] and parameter[2][@type='int[]'] and parameter[3][@type='java.lang.StringBuilder']]"
		[Register ("decodeMiddle", "(Lcom/google/zxing/common/BitArray;[ILjava/lang/StringBuilder;)I", "GetDecodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_Handler")]
		protected abstract int DecodeMiddle (global::Com.Google.Zxing.Common.BitArray? p0, int[]? p1, global::Java.Lang.StringBuilder? p2);

		static Delegate? cb_decodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetDecodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_Handler ()
		{
			if (cb_decodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_ == null)
				cb_decodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLL_L) n_DecodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_);
			return cb_decodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_;
		}

		static IntPtr n_DecodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_ (IntPtr jnienv, IntPtr native__this, int rowNumber, IntPtr native_row, IntPtr native_startGuardRange, IntPtr native_hints)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.UPCEANReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var row = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (native_row, JniHandleOwnership.DoNotTransfer);
			var startGuardRange = (int[]?) JNIEnv.GetArray (native_startGuardRange, JniHandleOwnership.DoNotTransfer, typeof (int));
			var hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.FromJniHandle (native_hints, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeRow (rowNumber, row, startGuardRange, hints));
			if (startGuardRange != null)
				JNIEnv.CopyArray (startGuardRange, native_startGuardRange);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCEANReader']/method[@name='decodeRow' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray'] and parameter[3][@type='int[]'] and parameter[4][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decodeRow", "(ILcom/google/zxing/common/BitArray;[ILjava/util/Map;)Lcom/google/zxing/Result;", "GetDecodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_Handler")]
		public virtual unsafe global::Com.Google.Zxing.Result? DecodeRow (int rowNumber, global::Com.Google.Zxing.Common.BitArray? row, int[]? startGuardRange, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object>? hints)
		{
			const string __id = "decodeRow.(ILcom/google/zxing/common/BitArray;[ILjava/util/Map;)Lcom/google/zxing/Result;";
			IntPtr native_startGuardRange = JNIEnv.NewArray (startGuardRange);
			IntPtr native_hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (hints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (rowNumber);
				__args [1] = new JniArgumentValue ((row == null) ? IntPtr.Zero : ((global::Java.Lang.Object) row).Handle);
				__args [2] = new JniArgumentValue (native_startGuardRange);
				__args [3] = new JniArgumentValue (native_hints);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (startGuardRange != null) {
					JNIEnv.CopyArray (native_startGuardRange, startGuardRange);
					JNIEnv.DeleteLocalRef (native_startGuardRange);
				}
				JNIEnv.DeleteLocalRef (native_hints);
				global::System.GC.KeepAlive (row);
				global::System.GC.KeepAlive (startGuardRange);
				global::System.GC.KeepAlive (hints);
			}
		}

		static Delegate? cb_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetDecodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_Handler ()
		{
			if (cb_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_ == null)
				cb_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_L) n_DecodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_);
			return cb_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_;
		}

		static IntPtr n_DecodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, int rowNumber, IntPtr native_row, IntPtr native_hints)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.UPCEANReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var row = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (native_row, JniHandleOwnership.DoNotTransfer);
			var hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.FromJniHandle (native_hints, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeRow (rowNumber, row, hints));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCEANReader']/method[@name='decodeRow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray'] and parameter[3][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decodeRow", "(ILcom/google/zxing/common/BitArray;Ljava/util/Map;)Lcom/google/zxing/Result;", "GetDecodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_Handler")]
		public override unsafe global::Com.Google.Zxing.Result? DecodeRow (int rowNumber, global::Com.Google.Zxing.Common.BitArray? row, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object>? hints)
		{
			const string __id = "decodeRow.(ILcom/google/zxing/common/BitArray;Ljava/util/Map;)Lcom/google/zxing/Result;";
			IntPtr native_hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (hints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (rowNumber);
				__args [1] = new JniArgumentValue ((row == null) ? IntPtr.Zero : ((global::Java.Lang.Object) row).Handle);
				__args [2] = new JniArgumentValue (native_hints);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hints);
				global::System.GC.KeepAlive (row);
				global::System.GC.KeepAlive (hints);
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/oned/UPCEANReader", DoNotGenerateAcw=true)]
	internal partial class UPCEANReaderInvoker : UPCEANReader {
		public UPCEANReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/oned/UPCEANReader", typeof (UPCEANReaderInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCEANReader']/method[@name='decodeMiddle' and count(parameter)=3 and parameter[1][@type='com.google.zxing.common.BitArray'] and parameter[2][@type='int[]'] and parameter[3][@type='java.lang.StringBuilder']]"
		[Register ("decodeMiddle", "(Lcom/google/zxing/common/BitArray;[ILjava/lang/StringBuilder;)I", "GetDecodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_Handler")]
		protected override unsafe int DecodeMiddle (global::Com.Google.Zxing.Common.BitArray? p0, int[]? p1, global::Java.Lang.StringBuilder? p2)
		{
			const string __id = "decodeMiddle.(Lcom/google/zxing/common/BitArray;[ILjava/lang/StringBuilder;)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
