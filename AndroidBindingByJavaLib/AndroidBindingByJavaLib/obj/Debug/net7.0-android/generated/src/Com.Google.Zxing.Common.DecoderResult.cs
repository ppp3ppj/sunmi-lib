using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']"
	[global::Android.Runtime.Register ("com/google/zxing/common/DecoderResult", DoNotGenerateAcw=true)]
	public sealed partial class DecoderResult : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/common/DecoderResult", typeof (DecoderResult));

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

		internal DecoderResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/constructor[@name='DecoderResult' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;byte[]&gt;'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "([BLjava/lang/String;Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe DecoderResult (byte[]? rawBytes, string? text, global::System.Collections.Generic.IList<byte[]>? byteSegments, string? ecLevel) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BLjava/lang/String;Ljava/util/List;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rawBytes = JNIEnv.NewArray (rawBytes);
			IntPtr native_text = JNIEnv.NewString ((string?)text);
			IntPtr native_byteSegments = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (byteSegments);
			IntPtr native_ecLevel = JNIEnv.NewString ((string?)ecLevel);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_rawBytes);
				__args [1] = new JniArgumentValue (native_text);
				__args [2] = new JniArgumentValue (native_byteSegments);
				__args [3] = new JniArgumentValue (native_ecLevel);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (rawBytes != null) {
					JNIEnv.CopyArray (native_rawBytes, rawBytes);
					JNIEnv.DeleteLocalRef (native_rawBytes);
				}
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_byteSegments);
				JNIEnv.DeleteLocalRef (native_ecLevel);
				global::System.GC.KeepAlive (rawBytes);
				global::System.GC.KeepAlive (byteSegments);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/constructor[@name='DecoderResult' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;byte[]&gt;'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register (".ctor", "([BLjava/lang/String;Ljava/util/List;Ljava/lang/String;II)V", "")]
		public unsafe DecoderResult (byte[]? rawBytes, string? text, global::System.Collections.Generic.IList<byte[]>? byteSegments, string? ecLevel, int saSequence, int saParity) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BLjava/lang/String;Ljava/util/List;Ljava/lang/String;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rawBytes = JNIEnv.NewArray (rawBytes);
			IntPtr native_text = JNIEnv.NewString ((string?)text);
			IntPtr native_byteSegments = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (byteSegments);
			IntPtr native_ecLevel = JNIEnv.NewString ((string?)ecLevel);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_rawBytes);
				__args [1] = new JniArgumentValue (native_text);
				__args [2] = new JniArgumentValue (native_byteSegments);
				__args [3] = new JniArgumentValue (native_ecLevel);
				__args [4] = new JniArgumentValue (saSequence);
				__args [5] = new JniArgumentValue (saParity);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (rawBytes != null) {
					JNIEnv.CopyArray (native_rawBytes, rawBytes);
					JNIEnv.DeleteLocalRef (native_rawBytes);
				}
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_byteSegments);
				JNIEnv.DeleteLocalRef (native_ecLevel);
				global::System.GC.KeepAlive (rawBytes);
				global::System.GC.KeepAlive (byteSegments);
			}
		}

		public unsafe global::System.Collections.Generic.IList<byte[]>? ByteSegments {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getByteSegments' and count(parameter)=0]"
			[Register ("getByteSegments", "()Ljava/util/List;", "")]
			get {
				const string __id = "getByteSegments.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<byte[]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? ECLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getECLevel' and count(parameter)=0]"
			[Register ("getECLevel", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getECLevel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Integer? Erasures {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getErasures' and count(parameter)=0]"
			[Register ("getErasures", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getErasures.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='setErasures' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setErasures", "(Ljava/lang/Integer;)V", "")]
			set {
				const string __id = "setErasures.(Ljava/lang/Integer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Java.Lang.Integer? ErrorsCorrected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getErrorsCorrected' and count(parameter)=0]"
			[Register ("getErrorsCorrected", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getErrorsCorrected.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='setErrorsCorrected' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setErrorsCorrected", "(Ljava/lang/Integer;)V", "")]
			set {
				const string __id = "setErrorsCorrected.(Ljava/lang/Integer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe bool HasStructuredAppend {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='hasStructuredAppend' and count(parameter)=0]"
			[Register ("hasStructuredAppend", "()Z", "")]
			get {
				const string __id = "hasStructuredAppend.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int NumBits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getNumBits' and count(parameter)=0]"
			[Register ("getNumBits", "()I", "")]
			get {
				const string __id = "getNumBits.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='setNumBits' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumBits", "(I)V", "")]
			set {
				const string __id = "setNumBits.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Object? Other {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getOther' and count(parameter)=0]"
			[Register ("getOther", "()Ljava/lang/Object;", "")]
			get {
				const string __id = "getOther.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='setOther' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setOther", "(Ljava/lang/Object;)V", "")]
			set {
				const string __id = "setOther.(Ljava/lang/Object;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe int StructuredAppendParity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getStructuredAppendParity' and count(parameter)=0]"
			[Register ("getStructuredAppendParity", "()I", "")]
			get {
				const string __id = "getStructuredAppendParity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int StructuredAppendSequenceNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getStructuredAppendSequenceNumber' and count(parameter)=0]"
			[Register ("getStructuredAppendSequenceNumber", "()I", "")]
			get {
				const string __id = "getStructuredAppendSequenceNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string? Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getText' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getRawBytes' and count(parameter)=0]"
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

	}
}
