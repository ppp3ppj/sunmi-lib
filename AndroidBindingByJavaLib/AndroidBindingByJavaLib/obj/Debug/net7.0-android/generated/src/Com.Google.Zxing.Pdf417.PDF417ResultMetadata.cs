using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Pdf417 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/PDF417ResultMetadata", DoNotGenerateAcw=true)]
	public sealed partial class PDF417ResultMetadata : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/pdf417/PDF417ResultMetadata", typeof (PDF417ResultMetadata));

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

		internal PDF417ResultMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/constructor[@name='PDF417ResultMetadata' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PDF417ResultMetadata () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe string? FileId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='getFileId' and count(parameter)=0]"
			[Register ("getFileId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getFileId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='setFileId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFileId", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setFileId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe bool LastSegment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='isLastSegment' and count(parameter)=0]"
			[Register ("isLastSegment", "()Z", "")]
			get {
				const string __id = "isLastSegment.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='setLastSegment' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLastSegment", "(Z)V", "")]
			set {
				const string __id = "setLastSegment.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int SegmentIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='getSegmentIndex' and count(parameter)=0]"
			[Register ("getSegmentIndex", "()I", "")]
			get {
				const string __id = "getSegmentIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='setSegmentIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSegmentIndex", "(I)V", "")]
			set {
				const string __id = "setSegmentIndex.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='getOptionalData' and count(parameter)=0]"
		[Register ("getOptionalData", "()[I", "")]
		public unsafe int[]? GetOptionalData ()
		{
			const string __id = "getOptionalData.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='setOptionalData' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setOptionalData", "([I)V", "")]
		public unsafe void SetOptionalData (int[]? optionalData)
		{
			const string __id = "setOptionalData.([I)V";
			IntPtr native_optionalData = JNIEnv.NewArray (optionalData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_optionalData);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (optionalData != null) {
					JNIEnv.CopyArray (native_optionalData, optionalData);
					JNIEnv.DeleteLocalRef (native_optionalData);
				}
				global::System.GC.KeepAlive (optionalData);
			}
		}

	}
}
