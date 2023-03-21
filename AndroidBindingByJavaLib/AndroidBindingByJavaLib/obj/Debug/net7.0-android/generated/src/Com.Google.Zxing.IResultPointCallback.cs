using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.zxing']/interface[@name='ResultPointCallback']"
	[Register ("com/google/zxing/ResultPointCallback", "", "Com.Google.Zxing.IResultPointCallbackInvoker")]
	public partial interface IResultPointCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/interface[@name='ResultPointCallback']/method[@name='foundPossibleResultPoint' and count(parameter)=1 and parameter[1][@type='com.google.zxing.ResultPoint']]"
		[Register ("foundPossibleResultPoint", "(Lcom/google/zxing/ResultPoint;)V", "GetFoundPossibleResultPoint_Lcom_google_zxing_ResultPoint_Handler:Com.Google.Zxing.IResultPointCallbackInvoker, AndroidBindingByJavaLib")]
		void FoundPossibleResultPoint (global::Com.Google.Zxing.ResultPoint? p0);

	}

	[global::Android.Runtime.Register ("com/google/zxing/ResultPointCallback", DoNotGenerateAcw=true)]
	internal partial class IResultPointCallbackInvoker : global::Java.Lang.Object, IResultPointCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/ResultPointCallback", typeof (IResultPointCallbackInvoker));

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

		public static IResultPointCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResultPointCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.google.zxing.ResultPointCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResultPointCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_;
#pragma warning disable 0169
		static Delegate GetFoundPossibleResultPoint_Lcom_google_zxing_ResultPoint_Handler ()
		{
			if (cb_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_ == null)
				cb_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FoundPossibleResultPoint_Lcom_google_zxing_ResultPoint_);
			return cb_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_;
		}

		static void n_FoundPossibleResultPoint_Lcom_google_zxing_ResultPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.IResultPointCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FoundPossibleResultPoint (p0);
		}
#pragma warning restore 0169

		IntPtr id_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_;
		public unsafe void FoundPossibleResultPoint (global::Com.Google.Zxing.ResultPoint? p0)
		{
			if (id_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_ == IntPtr.Zero)
				id_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_ = JNIEnv.GetMethodID (class_ref, "foundPossibleResultPoint", "(Lcom/google/zxing/ResultPoint;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_, __args);
		}

	}
}
