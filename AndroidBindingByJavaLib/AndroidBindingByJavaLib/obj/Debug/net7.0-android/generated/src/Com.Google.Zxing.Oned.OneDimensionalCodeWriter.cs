using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Oned {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/OneDimensionalCodeWriter", DoNotGenerateAcw=true)]
	public abstract partial class OneDimensionalCodeWriter : global::Java.Lang.Object, global::Com.Google.Zxing.IWriter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/oned/OneDimensionalCodeWriter", typeof (OneDimensionalCodeWriter));

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

		protected OneDimensionalCodeWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/constructor[@name='OneDimensionalCodeWriter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OneDimensionalCodeWriter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_getDefaultMargin;
#pragma warning disable 0169
		static Delegate GetGetDefaultMarginHandler ()
		{
			if (cb_getDefaultMargin == null)
				cb_getDefaultMargin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDefaultMargin);
			return cb_getDefaultMargin;
		}

		static int n_GetDefaultMargin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDimensionalCodeWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DefaultMargin;
		}
#pragma warning restore 0169

		public virtual unsafe int DefaultMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/method[@name='getDefaultMargin' and count(parameter)=0]"
			[Register ("getDefaultMargin", "()I", "GetGetDefaultMarginHandler")]
			get {
				const string __id = "getDefaultMargin.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/method[@name='appendPattern' and count(parameter)=4 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='boolean']]"
		[Register ("appendPattern", "([ZI[IZ)I", "")]
		protected static unsafe int AppendPattern (bool[]? target, int pos, int[]? pattern, bool startColor)
		{
			const string __id = "appendPattern.([ZI[IZ)I";
			IntPtr native_target = JNIEnv.NewArray (target);
			IntPtr native_pattern = JNIEnv.NewArray (pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_target);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue (native_pattern);
				__args [3] = new JniArgumentValue (startColor);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (target != null) {
					JNIEnv.CopyArray (native_target, target);
					JNIEnv.DeleteLocalRef (native_target);
				}
				if (pattern != null) {
					JNIEnv.CopyArray (native_pattern, pattern);
					JNIEnv.DeleteLocalRef (native_pattern);
				}
				global::System.GC.KeepAlive (target);
				global::System.GC.KeepAlive (pattern);
			}
		}

		static Delegate? cb_encode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Handler ()
		{
			if (cb_encode_Ljava_lang_String_ == null)
				cb_encode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Encode_Ljava_lang_String_);
			return cb_encode_Ljava_lang_String_;
		}

		static IntPtr n_Encode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDimensionalCodeWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)[Z", "GetEncode_Ljava_lang_String_Handler")]
		public abstract bool[]? Encode (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/method[@name='encode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.BarcodeFormat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;II)Lcom/google/zxing/common/BitMatrix;", "")]
		public unsafe global::Com.Google.Zxing.Common.BitMatrix? Encode (string? contents, global::Com.Google.Zxing.BarcodeFormat? format, int width, int height)
		{
			const string __id = "encode.(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;II)Lcom/google/zxing/common/BitMatrix;";
			IntPtr native_contents = JNIEnv.NewString ((string?)contents);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_contents);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_contents);
				global::System.GC.KeepAlive (format);
			}
		}

		static Delegate? cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_Handler ()
		{
			if (cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ == null)
				cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIIL_L) n_Encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_);
			return cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_;
		}

		static IntPtr n_Encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contents, IntPtr native_format, int width, int height, IntPtr native_hints)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDimensionalCodeWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var contents = JNIEnv.GetString (native_contents, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (native_format, JniHandleOwnership.DoNotTransfer);
			var hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.EncodeHintType, object>.FromJniHandle (native_hints, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (contents, format, width, height, hints));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/method[@name='encode' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.BarcodeFormat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.util.Map&lt;com.google.zxing.EncodeHintType, ?&gt;']]"
		[Register ("encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;IILjava/util/Map;)Lcom/google/zxing/common/BitMatrix;", "GetEncode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_Handler")]
		public virtual unsafe global::Com.Google.Zxing.Common.BitMatrix? Encode (string? contents, global::Com.Google.Zxing.BarcodeFormat? format, int width, int height, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.EncodeHintType, object>? hints)
		{
			const string __id = "encode.(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;IILjava/util/Map;)Lcom/google/zxing/common/BitMatrix;";
			IntPtr native_contents = JNIEnv.NewString ((string?)contents);
			IntPtr native_hints = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.EncodeHintType, object>.ToLocalJniHandle (hints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_contents);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				__args [4] = new JniArgumentValue (native_hints);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_contents);
				JNIEnv.DeleteLocalRef (native_hints);
				global::System.GC.KeepAlive (format);
				global::System.GC.KeepAlive (hints);
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/oned/OneDimensionalCodeWriter", DoNotGenerateAcw=true)]
	internal partial class OneDimensionalCodeWriterInvoker : OneDimensionalCodeWriter {
		public OneDimensionalCodeWriterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/oned/OneDimensionalCodeWriter", typeof (OneDimensionalCodeWriterInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)[Z", "GetEncode_Ljava_lang_String_Handler")]
		public override unsafe bool[]? Encode (string? p0)
		{
			const string __id = "encode.(Ljava/lang/String;)[Z";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (bool[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
