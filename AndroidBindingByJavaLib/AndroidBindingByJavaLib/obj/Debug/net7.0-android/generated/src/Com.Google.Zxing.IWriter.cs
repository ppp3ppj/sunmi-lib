using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.zxing']/interface[@name='Writer']"
	[Register ("com/google/zxing/Writer", "", "Com.Google.Zxing.IWriterInvoker")]
	public partial interface IWriter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/interface[@name='Writer']/method[@name='encode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.BarcodeFormat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;II)Lcom/google/zxing/common/BitMatrix;", "GetEncode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IIHandler:Com.Google.Zxing.IWriterInvoker, AndroidBindingByJavaLib")]
		global::Com.Google.Zxing.Common.BitMatrix? Encode (string? p0, global::Com.Google.Zxing.BarcodeFormat? p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/interface[@name='Writer']/method[@name='encode' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.BarcodeFormat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.util.Map&lt;com.google.zxing.EncodeHintType, ?&gt;']]"
		[Register ("encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;IILjava/util/Map;)Lcom/google/zxing/common/BitMatrix;", "GetEncode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_Handler:Com.Google.Zxing.IWriterInvoker, AndroidBindingByJavaLib")]
		global::Com.Google.Zxing.Common.BitMatrix? Encode (string? p0, global::Com.Google.Zxing.BarcodeFormat? p1, int p2, int p3, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.EncodeHintType, object>? p4);

	}

	[global::Android.Runtime.Register ("com/google/zxing/Writer", DoNotGenerateAcw=true)]
	internal partial class IWriterInvoker : global::Java.Lang.Object, IWriter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/Writer", typeof (IWriterInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IWriter? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWriter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.google.zxing.Writer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWriterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IIHandler ()
		{
			if (cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II == null)
				cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_L) n_Encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II);
			return cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II;
		}

		static IntPtr n_Encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.IWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II;
		public unsafe global::Com.Google.Zxing.Common.BitMatrix? Encode (string? p0, global::Com.Google.Zxing.BarcodeFormat? p1, int p2, int p3)
		{
			if (id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II == IntPtr.Zero)
				id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;II)Lcom/google/zxing/common/BitMatrix;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_Handler ()
		{
			if (cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ == null)
				cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIIL_L) n_Encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_);
			return cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_;
		}

		static IntPtr n_Encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.IWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.EncodeHintType, object>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_;
		public unsafe global::Com.Google.Zxing.Common.BitMatrix? Encode (string? p0, global::Com.Google.Zxing.BarcodeFormat? p1, int p2, int p3, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.EncodeHintType, object>? p4)
		{
			if (id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;IILjava/util/Map;)Lcom/google/zxing/common/BitMatrix;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.EncodeHintType, object>.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

	}
}
