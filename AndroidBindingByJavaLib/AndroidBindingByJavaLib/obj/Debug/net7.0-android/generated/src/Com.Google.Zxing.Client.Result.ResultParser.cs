using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/ResultParser", DoNotGenerateAcw=true)]
	public abstract partial class ResultParser : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/client/result/ResultParser", typeof (ResultParser));

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

		protected ResultParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/constructor[@name='ResultParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResultParser () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='getMassagedText' and count(parameter)=1 and parameter[1][@type='com.google.zxing.Result']]"
		[Register ("getMassagedText", "(Lcom/google/zxing/Result;)Ljava/lang/String;", "")]
		protected static unsafe string? GetMassagedText (global::Com.Google.Zxing.Result? result)
		{
			const string __id = "getMassagedText.(Lcom/google/zxing/Result;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (result);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='isStringOfDigits' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int']]"
		[Register ("isStringOfDigits", "(Ljava/lang/CharSequence;I)Z", "")]
		protected static unsafe bool IsStringOfDigits (global::Java.Lang.ICharSequence? value, int length)
		{
			const string __id = "isStringOfDigits.(Ljava/lang/CharSequence;I)Z";
			IntPtr native_value = CharSequence.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_value);
				__args [1] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (value);
			}
		}

		protected static bool IsStringOfDigits (string? value, int length)
		{
			var jls_value = value == null ? null : new global::Java.Lang.String (value);
			bool __result = IsStringOfDigits (jls_value, length);
			var __rsval = __result;
			jls_value?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='isSubstringOfDigits' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("isSubstringOfDigits", "(Ljava/lang/CharSequence;II)Z", "")]
		protected static unsafe bool IsSubstringOfDigits (global::Java.Lang.ICharSequence? value, int offset, int length)
		{
			const string __id = "isSubstringOfDigits.(Ljava/lang/CharSequence;II)Z";
			IntPtr native_value = CharSequence.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_value);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (value);
			}
		}

		protected static bool IsSubstringOfDigits (string? value, int offset, int length)
		{
			var jls_value = value == null ? null : new global::Java.Lang.String (value);
			bool __result = IsSubstringOfDigits (jls_value, offset, length);
			var __rsval = __result;
			jls_value?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='maybeAppend' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.StringBuilder']]"
		[Register ("maybeAppend", "(Ljava/lang/String;Ljava/lang/StringBuilder;)V", "")]
		protected static unsafe void MaybeAppend (string? value, global::Java.Lang.StringBuilder? result)
		{
			const string __id = "maybeAppend.(Ljava/lang/String;Ljava/lang/StringBuilder;)V";
			IntPtr native_value = JNIEnv.NewString ((string?)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_value);
				__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (result);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='maybeAppend' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.StringBuilder']]"
		[Register ("maybeAppend", "([Ljava/lang/String;Ljava/lang/StringBuilder;)V", "")]
		protected static unsafe void MaybeAppend (string[]? value, global::Java.Lang.StringBuilder? result)
		{
			const string __id = "maybeAppend.([Ljava/lang/String;Ljava/lang/StringBuilder;)V";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_value);
				__args [1] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
				global::System.GC.KeepAlive (value);
				global::System.GC.KeepAlive (result);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='maybeWrap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("maybeWrap", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		protected static unsafe string[]? MaybeWrap (string? value)
		{
			const string __id = "maybeWrap.(Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_value = JNIEnv.NewString ((string?)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate? cb_parse_Lcom_google_zxing_Result_;
#pragma warning disable 0169
		static Delegate GetParse_Lcom_google_zxing_Result_Handler ()
		{
			if (cb_parse_Lcom_google_zxing_Result_ == null)
				cb_parse_Lcom_google_zxing_Result_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Parse_Lcom_google_zxing_Result_);
			return cb_parse_Lcom_google_zxing_Result_;
		}

		static IntPtr n_Parse_Lcom_google_zxing_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ResultParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.google.zxing.Result']]"
		[Register ("parse", "(Lcom/google/zxing/Result;)Lcom/google/zxing/client/result/ParsedResult;", "GetParse_Lcom_google_zxing_Result_Handler")]
		public abstract global::Com.Google.Zxing.Client.Result.ParsedResult? Parse (global::Com.Google.Zxing.Result? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='parseHexDigit' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("parseHexDigit", "(C)I", "")]
		protected static unsafe int ParseHexDigit (char c)
		{
			const string __id = "parseHexDigit.(C)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='parseResult' and count(parameter)=1 and parameter[1][@type='com.google.zxing.Result']]"
		[Register ("parseResult", "(Lcom/google/zxing/Result;)Lcom/google/zxing/client/result/ParsedResult;", "")]
		public static unsafe global::Com.Google.Zxing.Client.Result.ParsedResult? ParseResult (global::Com.Google.Zxing.Result? theResult)
		{
			const string __id = "parseResult.(Lcom/google/zxing/Result;)Lcom/google/zxing/client/result/ParsedResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((theResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theResult).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (theResult);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='unescapeBackslash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unescapeBackslash", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		protected static unsafe string? UnescapeBackslash (string? escaped)
		{
			const string __id = "unescapeBackslash.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_escaped = JNIEnv.NewString ((string?)escaped);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_escaped);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_escaped);
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/client/result/ResultParser", DoNotGenerateAcw=true)]
	internal partial class ResultParserInvoker : ResultParser {
		public ResultParserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/client/result/ResultParser", typeof (ResultParserInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.google.zxing.Result']]"
		[Register ("parse", "(Lcom/google/zxing/Result;)Lcom/google/zxing/client/result/ParsedResult;", "GetParse_Lcom_google_zxing_Result_Handler")]
		public override unsafe global::Com.Google.Zxing.Client.Result.ParsedResult? Parse (global::Com.Google.Zxing.Result? p0)
		{
			const string __id = "parse.(Lcom/google/zxing/Result;)Lcom/google/zxing/client/result/ParsedResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
