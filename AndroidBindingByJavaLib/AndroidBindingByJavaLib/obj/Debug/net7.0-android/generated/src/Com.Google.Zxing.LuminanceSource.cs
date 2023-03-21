using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']"
	[global::Android.Runtime.Register ("com/google/zxing/LuminanceSource", DoNotGenerateAcw=true)]
	public abstract partial class LuminanceSource : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/LuminanceSource", typeof (LuminanceSource));

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

		protected LuminanceSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/constructor[@name='LuminanceSource' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		protected unsafe LuminanceSource (int width, int height) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='getHeight' and count(parameter)=0]"
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

		static Delegate? cb_isCropSupported;
#pragma warning disable 0169
		static Delegate GetIsCropSupportedHandler ()
		{
			if (cb_isCropSupported == null)
				cb_isCropSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCropSupported);
			return cb_isCropSupported;
		}

		static bool n_IsCropSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsCropSupported;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCropSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='isCropSupported' and count(parameter)=0]"
			[Register ("isCropSupported", "()Z", "GetIsCropSupportedHandler")]
			get {
				const string __id = "isCropSupported.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isRotateSupported;
#pragma warning disable 0169
		static Delegate GetIsRotateSupportedHandler ()
		{
			if (cb_isRotateSupported == null)
				cb_isRotateSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRotateSupported);
			return cb_isRotateSupported;
		}

		static bool n_IsRotateSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsRotateSupported;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRotateSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='isRotateSupported' and count(parameter)=0]"
			[Register ("isRotateSupported", "()Z", "GetIsRotateSupportedHandler")]
			get {
				const string __id = "isRotateSupported.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='getWidth' and count(parameter)=0]"
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

		static Delegate? cb_crop_IIII;
#pragma warning disable 0169
		static Delegate GetCrop_IIIIHandler ()
		{
			if (cb_crop_IIII == null)
				cb_crop_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_L) n_Crop_IIII);
			return cb_crop_IIII;
		}

		static IntPtr n_Crop_IIII (IntPtr jnienv, IntPtr native__this, int left, int top, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Crop (left, top, width, height));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='crop' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("crop", "(IIII)Lcom/google/zxing/LuminanceSource;", "GetCrop_IIIIHandler")]
		public virtual unsafe global::Com.Google.Zxing.LuminanceSource? Crop (int left, int top, int width, int height)
		{
			const string __id = "crop.(IIII)Lcom/google/zxing/LuminanceSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_getMatrix;
#pragma warning disable 0169
		static Delegate GetGetMatrixHandler ()
		{
			if (cb_getMatrix == null)
				cb_getMatrix = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMatrix);
			return cb_getMatrix;
		}

		static IntPtr n_GetMatrix (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetMatrix ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='getMatrix' and count(parameter)=0]"
		[Register ("getMatrix", "()[B", "GetGetMatrixHandler")]
		public abstract byte[]? GetMatrix ();

		static Delegate? cb_getRow_IarrayB;
#pragma warning disable 0169
		static Delegate GetGetRow_IarrayBHandler ()
		{
			if (cb_getRow_IarrayB == null)
				cb_getRow_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_GetRow_IarrayB);
			return cb_getRow_IarrayB;
		}

		static IntPtr n_GetRow_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.GetRow (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='getRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("getRow", "(I[B)[B", "GetGetRow_IarrayBHandler")]
		public abstract byte[]? GetRow (int p0, byte[]? p1);

		static Delegate? cb_invert;
#pragma warning disable 0169
		static Delegate GetInvertHandler ()
		{
			if (cb_invert == null)
				cb_invert = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Invert);
			return cb_invert;
		}

		static IntPtr n_Invert (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Invert ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='invert' and count(parameter)=0]"
		[Register ("invert", "()Lcom/google/zxing/LuminanceSource;", "GetInvertHandler")]
		public virtual unsafe global::Com.Google.Zxing.LuminanceSource? Invert ()
		{
			const string __id = "invert.()Lcom/google/zxing/LuminanceSource;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_rotateCounterClockwise;
#pragma warning disable 0169
		static Delegate GetRotateCounterClockwiseHandler ()
		{
			if (cb_rotateCounterClockwise == null)
				cb_rotateCounterClockwise = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_RotateCounterClockwise);
			return cb_rotateCounterClockwise;
		}

		static IntPtr n_RotateCounterClockwise (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.RotateCounterClockwise ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='rotateCounterClockwise' and count(parameter)=0]"
		[Register ("rotateCounterClockwise", "()Lcom/google/zxing/LuminanceSource;", "GetRotateCounterClockwiseHandler")]
		public virtual unsafe global::Com.Google.Zxing.LuminanceSource? RotateCounterClockwise ()
		{
			const string __id = "rotateCounterClockwise.()Lcom/google/zxing/LuminanceSource;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_rotateCounterClockwise45;
#pragma warning disable 0169
		static Delegate GetRotateCounterClockwise45Handler ()
		{
			if (cb_rotateCounterClockwise45 == null)
				cb_rotateCounterClockwise45 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_RotateCounterClockwise45);
			return cb_rotateCounterClockwise45;
		}

		static IntPtr n_RotateCounterClockwise45 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.RotateCounterClockwise45 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='rotateCounterClockwise45' and count(parameter)=0]"
		[Register ("rotateCounterClockwise45", "()Lcom/google/zxing/LuminanceSource;", "GetRotateCounterClockwise45Handler")]
		public virtual unsafe global::Com.Google.Zxing.LuminanceSource? RotateCounterClockwise45 ()
		{
			const string __id = "rotateCounterClockwise45.()Lcom/google/zxing/LuminanceSource;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string? ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/LuminanceSource", DoNotGenerateAcw=true)]
	internal partial class LuminanceSourceInvoker : LuminanceSource {
		public LuminanceSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/LuminanceSource", typeof (LuminanceSourceInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='getMatrix' and count(parameter)=0]"
		[Register ("getMatrix", "()[B", "GetGetMatrixHandler")]
		public override unsafe byte[]? GetMatrix ()
		{
			const string __id = "getMatrix.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='getRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("getRow", "(I[B)[B", "GetGetRow_IarrayBHandler")]
		public override unsafe byte[]? GetRow (int p0, byte[]? p1)
		{
			const string __id = "getRow.(I[B)[B";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
