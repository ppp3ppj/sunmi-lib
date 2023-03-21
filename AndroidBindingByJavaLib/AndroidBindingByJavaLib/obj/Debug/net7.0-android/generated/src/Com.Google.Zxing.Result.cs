using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']"
	[global::Android.Runtime.Register ("com/google/zxing/Result", DoNotGenerateAcw=true)]
	public sealed partial class Result : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/Result", typeof (Result));

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

		internal Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/constructor[@name='Result' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.google.zxing.ResultPoint[]'] and parameter[4][@type='com.google.zxing.BarcodeFormat']]"
		[Register (".ctor", "(Ljava/lang/String;[B[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;)V", "")]
		public unsafe Result (string? text, byte[]? rawBytes, global::Com.Google.Zxing.ResultPoint[]? resultPoints, global::Com.Google.Zxing.BarcodeFormat? format) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;[B[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString ((string?)text);
			IntPtr native_rawBytes = JNIEnv.NewArray (rawBytes);
			IntPtr native_resultPoints = JNIEnv.NewArray (resultPoints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (native_rawBytes);
				__args [2] = new JniArgumentValue (native_resultPoints);
				__args [3] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				if (rawBytes != null) {
					JNIEnv.CopyArray (native_rawBytes, rawBytes);
					JNIEnv.DeleteLocalRef (native_rawBytes);
				}
				if (resultPoints != null) {
					JNIEnv.CopyArray (native_resultPoints, resultPoints);
					JNIEnv.DeleteLocalRef (native_resultPoints);
				}
				global::System.GC.KeepAlive (rawBytes);
				global::System.GC.KeepAlive (resultPoints);
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/constructor[@name='Result' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.google.zxing.ResultPoint[]'] and parameter[4][@type='com.google.zxing.BarcodeFormat'] and parameter[5][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;[B[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;J)V", "")]
		public unsafe Result (string? text, byte[]? rawBytes, global::Com.Google.Zxing.ResultPoint[]? resultPoints, global::Com.Google.Zxing.BarcodeFormat? format, long timestamp) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;[B[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString ((string?)text);
			IntPtr native_rawBytes = JNIEnv.NewArray (rawBytes);
			IntPtr native_resultPoints = JNIEnv.NewArray (resultPoints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (native_rawBytes);
				__args [2] = new JniArgumentValue (native_resultPoints);
				__args [3] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [4] = new JniArgumentValue (timestamp);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				if (rawBytes != null) {
					JNIEnv.CopyArray (native_rawBytes, rawBytes);
					JNIEnv.DeleteLocalRef (native_rawBytes);
				}
				if (resultPoints != null) {
					JNIEnv.CopyArray (native_resultPoints, resultPoints);
					JNIEnv.DeleteLocalRef (native_resultPoints);
				}
				global::System.GC.KeepAlive (rawBytes);
				global::System.GC.KeepAlive (resultPoints);
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/constructor[@name='Result' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='com.google.zxing.ResultPoint[]'] and parameter[5][@type='com.google.zxing.BarcodeFormat'] and parameter[6][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;[BI[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;J)V", "")]
		public unsafe Result (string? text, byte[]? rawBytes, int numBits, global::Com.Google.Zxing.ResultPoint[]? resultPoints, global::Com.Google.Zxing.BarcodeFormat? format, long timestamp) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;[BI[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString ((string?)text);
			IntPtr native_rawBytes = JNIEnv.NewArray (rawBytes);
			IntPtr native_resultPoints = JNIEnv.NewArray (resultPoints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (native_rawBytes);
				__args [2] = new JniArgumentValue (numBits);
				__args [3] = new JniArgumentValue (native_resultPoints);
				__args [4] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [5] = new JniArgumentValue (timestamp);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				if (rawBytes != null) {
					JNIEnv.CopyArray (native_rawBytes, rawBytes);
					JNIEnv.DeleteLocalRef (native_rawBytes);
				}
				if (resultPoints != null) {
					JNIEnv.CopyArray (native_resultPoints, resultPoints);
					JNIEnv.DeleteLocalRef (native_resultPoints);
				}
				global::System.GC.KeepAlive (rawBytes);
				global::System.GC.KeepAlive (resultPoints);
				global::System.GC.KeepAlive (format);
			}
		}

		public unsafe global::Com.Google.Zxing.BarcodeFormat? BarcodeFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='getBarcodeFormat' and count(parameter)=0]"
			[Register ("getBarcodeFormat", "()Lcom/google/zxing/BarcodeFormat;", "")]
			get {
				const string __id = "getBarcodeFormat.()Lcom/google/zxing/BarcodeFormat;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int NumBits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='getNumBits' and count(parameter)=0]"
			[Register ("getNumBits", "()I", "")]
			get {
				const string __id = "getNumBits.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.ResultMetadataType, global::Java.Lang.Object>? ResultMetadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='getResultMetadata' and count(parameter)=0]"
			[Register ("getResultMetadata", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getResultMetadata.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.ResultMetadataType, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "")]
			get {
				const string __id = "getTimestamp.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='addResultPoints' and count(parameter)=1 and parameter[1][@type='com.google.zxing.ResultPoint[]']]"
		[Register ("addResultPoints", "([Lcom/google/zxing/ResultPoint;)V", "")]
		public unsafe void AddResultPoints (global::Com.Google.Zxing.ResultPoint[]? newPoints)
		{
			const string __id = "addResultPoints.([Lcom/google/zxing/ResultPoint;)V";
			IntPtr native_newPoints = JNIEnv.NewArray (newPoints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_newPoints);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (newPoints != null) {
					JNIEnv.CopyArray (native_newPoints, newPoints);
					JNIEnv.DeleteLocalRef (native_newPoints);
				}
				global::System.GC.KeepAlive (newPoints);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='getRawBytes' and count(parameter)=0]"
		[Register ("getRawBytes", "()[B", "")]
		public unsafe byte[]? GetRawBytes ()
		{
			const string __id = "getRawBytes.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='getResultPoints' and count(parameter)=0]"
		[Register ("getResultPoints", "()[Lcom/google/zxing/ResultPoint;", "")]
		public unsafe global::Com.Google.Zxing.ResultPoint[]? GetResultPoints ()
		{
			const string __id = "getResultPoints.()[Lcom/google/zxing/ResultPoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::Com.Google.Zxing.ResultPoint[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.ResultPoint));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='putAllMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;com.google.zxing.ResultMetadataType, java.lang.Object&gt;']]"
		[Register ("putAllMetadata", "(Ljava/util/Map;)V", "")]
		public unsafe void PutAllMetadata (global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.ResultMetadataType, global::Java.Lang.Object>? metadata)
		{
			const string __id = "putAllMetadata.(Ljava/util/Map;)V";
			IntPtr native_metadata = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.ResultMetadataType, global::Java.Lang.Object>.ToLocalJniHandle (metadata);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_metadata);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_metadata);
				global::System.GC.KeepAlive (metadata);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='putMetadata' and count(parameter)=2 and parameter[1][@type='com.google.zxing.ResultMetadataType'] and parameter[2][@type='java.lang.Object']]"
		[Register ("putMetadata", "(Lcom/google/zxing/ResultMetadataType;Ljava/lang/Object;)V", "")]
		public unsafe void PutMetadata (global::Com.Google.Zxing.ResultMetadataType? type, global::Java.Lang.Object? value)
		{
			const string __id = "putMetadata.(Lcom/google/zxing/ResultMetadataType;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (value);
			}
		}

	}
}
