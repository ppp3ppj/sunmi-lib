using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Oned {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='Code93Writer']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/Code93Writer", DoNotGenerateAcw=true)]
	public partial class Code93Writer : global::Com.Google.Zxing.Oned.OneDimensionalCodeWriter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/oned/Code93Writer", typeof (Code93Writer));

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

		protected Code93Writer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='Code93Writer']/constructor[@name='Code93Writer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Code93Writer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='Code93Writer']/method[@name='appendPattern' and count(parameter)=4 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='boolean']]"
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

		static IntPtr n_Encode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contents)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.Code93Writer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var contents = JNIEnv.GetString (native_contents, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Encode (contents));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='Code93Writer']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)[Z", "GetEncode_Ljava_lang_String_Handler")]
		public override unsafe bool[]? Encode (string? contents)
		{
			const string __id = "encode.(Ljava/lang/String;)[Z";
			IntPtr native_contents = JNIEnv.NewString ((string?)contents);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_contents);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (bool[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
				JNIEnv.DeleteLocalRef (native_contents);
			}
		}

	}
}
