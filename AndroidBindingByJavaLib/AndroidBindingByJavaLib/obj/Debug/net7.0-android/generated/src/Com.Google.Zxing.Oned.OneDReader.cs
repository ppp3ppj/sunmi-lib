using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Oned {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/OneDReader", DoNotGenerateAcw=true)]
	public abstract partial class OneDReader : global::Java.Lang.Object, global::Com.Google.Zxing.IReader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/oned/OneDReader", typeof (OneDReader));

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

		protected OneDReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/constructor[@name='OneDReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OneDReader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_decode_Lcom_google_zxing_BinaryBitmap_;
#pragma warning disable 0169
		static Delegate GetDecode_Lcom_google_zxing_BinaryBitmap_Handler ()
		{
			if (cb_decode_Lcom_google_zxing_BinaryBitmap_ == null)
				cb_decode_Lcom_google_zxing_BinaryBitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Decode_Lcom_google_zxing_BinaryBitmap_);
			return cb_decode_Lcom_google_zxing_BinaryBitmap_;
		}

		static IntPtr n_Decode_Lcom_google_zxing_BinaryBitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var image = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (native_image, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (image));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.google.zxing.BinaryBitmap']]"
		[Register ("decode", "(Lcom/google/zxing/BinaryBitmap;)Lcom/google/zxing/Result;", "GetDecode_Lcom_google_zxing_BinaryBitmap_Handler")]
		public virtual unsafe global::Com.Google.Zxing.Result? Decode (global::Com.Google.Zxing.BinaryBitmap? image)
		{
			const string __id = "decode.(Lcom/google/zxing/BinaryBitmap;)Lcom/google/zxing/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (image);
			}
		}

		static Delegate? cb_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetDecode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_Handler ()
		{
			if (cb_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ == null)
				cb_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_);
			return cb_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_;
		}

		static IntPtr n_Decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image, IntPtr native_hints)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var image = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (native_image, JniHandleOwnership.DoNotTransfer);
			var hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.FromJniHandle (native_hints, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (image, hints));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='com.google.zxing.BinaryBitmap'] and parameter[2][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decode", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)Lcom/google/zxing/Result;", "GetDecode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Google.Zxing.Result? Decode (global::Com.Google.Zxing.BinaryBitmap? image, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object>? hints)
		{
			const string __id = "decode.(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)Lcom/google/zxing/Result;";
			IntPtr native_hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (hints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				__args [1] = new JniArgumentValue (native_hints);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hints);
				global::System.GC.KeepAlive (image);
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

		static IntPtr n_DecodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeRow (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='decodeRow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray'] and parameter[3][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decodeRow", "(ILcom/google/zxing/common/BitArray;Ljava/util/Map;)Lcom/google/zxing/Result;", "GetDecodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_Handler")]
		public abstract global::Com.Google.Zxing.Result? DecodeRow (int p0, global::Com.Google.Zxing.Common.BitArray? p1, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object>? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='patternMatchVariance' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='float']]"
		[Register ("patternMatchVariance", "([I[IF)F", "")]
		protected static unsafe float PatternMatchVariance (int[]? counters, int[]? pattern, float maxIndividualVariance)
		{
			const string __id = "patternMatchVariance.([I[IF)F";
			IntPtr native_counters = JNIEnv.NewArray (counters);
			IntPtr native_pattern = JNIEnv.NewArray (pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_counters);
				__args [1] = new JniArgumentValue (native_pattern);
				__args [2] = new JniArgumentValue (maxIndividualVariance);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				if (counters != null) {
					JNIEnv.CopyArray (native_counters, counters);
					JNIEnv.DeleteLocalRef (native_counters);
				}
				if (pattern != null) {
					JNIEnv.CopyArray (native_pattern, pattern);
					JNIEnv.DeleteLocalRef (native_pattern);
				}
				global::System.GC.KeepAlive (counters);
				global::System.GC.KeepAlive (pattern);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='recordPattern' and count(parameter)=3 and parameter[1][@type='com.google.zxing.common.BitArray'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("recordPattern", "(Lcom/google/zxing/common/BitArray;I[I)V", "")]
		protected static unsafe void RecordPattern (global::Com.Google.Zxing.Common.BitArray? row, int start, int[]? counters)
		{
			const string __id = "recordPattern.(Lcom/google/zxing/common/BitArray;I[I)V";
			IntPtr native_counters = JNIEnv.NewArray (counters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((row == null) ? IntPtr.Zero : ((global::Java.Lang.Object) row).Handle);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (native_counters);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (counters != null) {
					JNIEnv.CopyArray (native_counters, counters);
					JNIEnv.DeleteLocalRef (native_counters);
				}
				global::System.GC.KeepAlive (row);
				global::System.GC.KeepAlive (counters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='recordPatternInReverse' and count(parameter)=3 and parameter[1][@type='com.google.zxing.common.BitArray'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("recordPatternInReverse", "(Lcom/google/zxing/common/BitArray;I[I)V", "")]
		protected static unsafe void RecordPatternInReverse (global::Com.Google.Zxing.Common.BitArray? row, int start, int[]? counters)
		{
			const string __id = "recordPatternInReverse.(Lcom/google/zxing/common/BitArray;I[I)V";
			IntPtr native_counters = JNIEnv.NewArray (counters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((row == null) ? IntPtr.Zero : ((global::Java.Lang.Object) row).Handle);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (native_counters);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (counters != null) {
					JNIEnv.CopyArray (native_counters, counters);
					JNIEnv.DeleteLocalRef (native_counters);
				}
				global::System.GC.KeepAlive (row);
				global::System.GC.KeepAlive (counters);
			}
		}

		static Delegate? cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/oned/OneDReader", DoNotGenerateAcw=true)]
	internal partial class OneDReaderInvoker : OneDReader {
		public OneDReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/oned/OneDReader", typeof (OneDReaderInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='decodeRow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray'] and parameter[3][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decodeRow", "(ILcom/google/zxing/common/BitArray;Ljava/util/Map;)Lcom/google/zxing/Result;", "GetDecodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_Handler")]
		public override unsafe global::Com.Google.Zxing.Result? DecodeRow (int p0, global::Com.Google.Zxing.Common.BitArray? p1, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object>? p2)
		{
			const string __id = "decodeRow.(ILcom/google/zxing/common/BitArray;Ljava/util/Map;)Lcom/google/zxing/Result;";
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
