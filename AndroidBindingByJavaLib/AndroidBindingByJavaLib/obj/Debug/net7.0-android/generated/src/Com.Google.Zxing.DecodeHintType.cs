using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']"
	[global::Android.Runtime.Register ("com/google/zxing/DecodeHintType", DoNotGenerateAcw=true)]
	public sealed partial class DecodeHintType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='ALLOWED_EAN_EXTENSIONS']"
		[Register ("ALLOWED_EAN_EXTENSIONS")]
		public static global::Com.Google.Zxing.DecodeHintType? AllowedEanExtensions {
			get {
				const string __id = "ALLOWED_EAN_EXTENSIONS.Lcom/google/zxing/DecodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='ALLOWED_LENGTHS']"
		[Register ("ALLOWED_LENGTHS")]
		public static global::Com.Google.Zxing.DecodeHintType? AllowedLengths {
			get {
				const string __id = "ALLOWED_LENGTHS.Lcom/google/zxing/DecodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='ASSUME_CODE_39_CHECK_DIGIT']"
		[Register ("ASSUME_CODE_39_CHECK_DIGIT")]
		public static global::Com.Google.Zxing.DecodeHintType? AssumeCode39CheckDigit {
			get {
				const string __id = "ASSUME_CODE_39_CHECK_DIGIT.Lcom/google/zxing/DecodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='ASSUME_GS1']"
		[Register ("ASSUME_GS1")]
		public static global::Com.Google.Zxing.DecodeHintType? AssumeGs1 {
			get {
				const string __id = "ASSUME_GS1.Lcom/google/zxing/DecodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='CHARACTER_SET']"
		[Register ("CHARACTER_SET")]
		public static global::Com.Google.Zxing.DecodeHintType? CharacterSet {
			get {
				const string __id = "CHARACTER_SET.Lcom/google/zxing/DecodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='NEED_RESULT_POINT_CALLBACK']"
		[Register ("NEED_RESULT_POINT_CALLBACK")]
		public static global::Com.Google.Zxing.DecodeHintType? NeedResultPointCallback {
			get {
				const string __id = "NEED_RESULT_POINT_CALLBACK.Lcom/google/zxing/DecodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='OTHER']"
		[Register ("OTHER")]
		public static global::Com.Google.Zxing.DecodeHintType? Other {
			get {
				const string __id = "OTHER.Lcom/google/zxing/DecodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='POSSIBLE_FORMATS']"
		[Register ("POSSIBLE_FORMATS")]
		public static global::Com.Google.Zxing.DecodeHintType? PossibleFormats {
			get {
				const string __id = "POSSIBLE_FORMATS.Lcom/google/zxing/DecodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='PURE_BARCODE']"
		[Register ("PURE_BARCODE")]
		public static global::Com.Google.Zxing.DecodeHintType? PureBarcode {
			get {
				const string __id = "PURE_BARCODE.Lcom/google/zxing/DecodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='RETURN_CODABAR_START_END']"
		[Register ("RETURN_CODABAR_START_END")]
		public static global::Com.Google.Zxing.DecodeHintType? ReturnCodabarStartEnd {
			get {
				const string __id = "RETURN_CODABAR_START_END.Lcom/google/zxing/DecodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='TRY_HARDER']"
		[Register ("TRY_HARDER")]
		public static global::Com.Google.Zxing.DecodeHintType? TryHarder {
			get {
				const string __id = "TRY_HARDER.Lcom/google/zxing/DecodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/DecodeHintType", typeof (DecodeHintType));

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

		internal DecodeHintType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Java.Lang.Class? ValueType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/method[@name='getValueType' and count(parameter)=0]"
			[Register ("getValueType", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getValueType.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/DecodeHintType;", "")]
		public static unsafe global::Com.Google.Zxing.DecodeHintType? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/zxing/DecodeHintType;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/DecodeHintType;", "")]
		public static unsafe global::Com.Google.Zxing.DecodeHintType[]? Values ()
		{
			const string __id = "values.()[Lcom/google/zxing/DecodeHintType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Google.Zxing.DecodeHintType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.DecodeHintType));
			} finally {
			}
		}

	}
}
