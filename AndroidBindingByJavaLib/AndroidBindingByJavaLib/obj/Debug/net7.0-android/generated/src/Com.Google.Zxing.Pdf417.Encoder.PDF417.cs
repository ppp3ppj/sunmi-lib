using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Pdf417.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/encoder/PDF417", DoNotGenerateAcw=true)]
	public sealed partial class PDF417 : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/pdf417/encoder/PDF417", typeof (PDF417));

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

		internal PDF417 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/constructor[@name='PDF417' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PDF417 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/constructor[@name='PDF417' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe PDF417 (bool compact) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (compact);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe global::Com.Google.Zxing.Pdf417.Encoder.BarcodeMatrix? BarcodeMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/method[@name='getBarcodeMatrix' and count(parameter)=0]"
			[Register ("getBarcodeMatrix", "()Lcom/google/zxing/pdf417/encoder/BarcodeMatrix;", "")]
			get {
				const string __id = "getBarcodeMatrix.()Lcom/google/zxing/pdf417/encoder/BarcodeMatrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Encoder.BarcodeMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/method[@name='generateBarcodeLogic' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("generateBarcodeLogic", "(Ljava/lang/String;I)V", "")]
		public unsafe void GenerateBarcodeLogic (string? msg, int errorCorrectionLevel)
		{
			const string __id = "generateBarcodeLogic.(Ljava/lang/String;I)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue (errorCorrectionLevel);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/method[@name='setCompact' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCompact", "(Z)V", "")]
		public unsafe void SetCompact (bool compact)
		{
			const string __id = "setCompact.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (compact);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/method[@name='setCompaction' and count(parameter)=1 and parameter[1][@type='com.google.zxing.pdf417.encoder.Compaction']]"
		[Register ("setCompaction", "(Lcom/google/zxing/pdf417/encoder/Compaction;)V", "")]
		public unsafe void SetCompaction (global::Com.Google.Zxing.Pdf417.Encoder.Compaction? compaction)
		{
			const string __id = "setCompaction.(Lcom/google/zxing/pdf417/encoder/Compaction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((compaction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compaction).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (compaction);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/method[@name='setDimensions' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setDimensions", "(IIII)V", "")]
		public unsafe void SetDimensions (int maxCols, int minCols, int maxRows, int minRows)
		{
			const string __id = "setDimensions.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (maxCols);
				__args [1] = new JniArgumentValue (minCols);
				__args [2] = new JniArgumentValue (maxRows);
				__args [3] = new JniArgumentValue (minRows);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/method[@name='setEncoding' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register ("setEncoding", "(Ljava/nio/charset/Charset;)V", "")]
		public unsafe void SetEncoding (global::Java.Nio.Charset.Charset? encoding)
		{
			const string __id = "setEncoding.(Ljava/nio/charset/Charset;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((encoding == null) ? IntPtr.Zero : ((global::Java.Lang.Object) encoding).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (encoding);
			}
		}

	}
}
