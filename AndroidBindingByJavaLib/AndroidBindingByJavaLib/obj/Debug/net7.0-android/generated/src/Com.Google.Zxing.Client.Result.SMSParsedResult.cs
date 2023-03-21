using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='SMSParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/SMSParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class SMSParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/client/result/SMSParsedResult", typeof (SMSParsedResult));

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

		internal SMSParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='SMSParsedResult']/constructor[@name='SMSParsedResult' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SMSParsedResult (string? number, string? via, string? subject, string? body) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_number = JNIEnv.NewString ((string?)number);
			IntPtr native_via = JNIEnv.NewString ((string?)via);
			IntPtr native_subject = JNIEnv.NewString ((string?)subject);
			IntPtr native_body = JNIEnv.NewString ((string?)body);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_number);
				__args [1] = new JniArgumentValue (native_via);
				__args [2] = new JniArgumentValue (native_subject);
				__args [3] = new JniArgumentValue (native_body);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_number);
				JNIEnv.DeleteLocalRef (native_via);
				JNIEnv.DeleteLocalRef (native_subject);
				JNIEnv.DeleteLocalRef (native_body);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='SMSParsedResult']/constructor[@name='SMSParsedResult' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "([Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SMSParsedResult (string[]? numbers, string[]? vias, string? subject, string? body) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_numbers = JNIEnv.NewArray (numbers);
			IntPtr native_vias = JNIEnv.NewArray (vias);
			IntPtr native_subject = JNIEnv.NewString ((string?)subject);
			IntPtr native_body = JNIEnv.NewString ((string?)body);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_numbers);
				__args [1] = new JniArgumentValue (native_vias);
				__args [2] = new JniArgumentValue (native_subject);
				__args [3] = new JniArgumentValue (native_body);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (numbers != null) {
					JNIEnv.CopyArray (native_numbers, numbers);
					JNIEnv.DeleteLocalRef (native_numbers);
				}
				if (vias != null) {
					JNIEnv.CopyArray (native_vias, vias);
					JNIEnv.DeleteLocalRef (native_vias);
				}
				JNIEnv.DeleteLocalRef (native_subject);
				JNIEnv.DeleteLocalRef (native_body);
				global::System.GC.KeepAlive (numbers);
				global::System.GC.KeepAlive (vias);
			}
		}

		public unsafe string? Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='SMSParsedResult']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getBody.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string? DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='SMSParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
			[Register ("getDisplayResult", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDisplayResult.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? SMSURI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='SMSParsedResult']/method[@name='getSMSURI' and count(parameter)=0]"
			[Register ("getSMSURI", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSMSURI.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? Subject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='SMSParsedResult']/method[@name='getSubject' and count(parameter)=0]"
			[Register ("getSubject", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSubject.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='SMSParsedResult']/method[@name='getNumbers' and count(parameter)=0]"
		[Register ("getNumbers", "()[Ljava/lang/String;", "")]
		public unsafe string[]? GetNumbers ()
		{
			const string __id = "getNumbers.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='SMSParsedResult']/method[@name='getVias' and count(parameter)=0]"
		[Register ("getVias", "()[Ljava/lang/String;", "")]
		public unsafe string[]? GetVias ()
		{
			const string __id = "getVias.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
