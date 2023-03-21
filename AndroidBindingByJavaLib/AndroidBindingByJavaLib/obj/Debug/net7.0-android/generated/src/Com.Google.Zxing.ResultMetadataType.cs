using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']"
	[global::Android.Runtime.Register ("com/google/zxing/ResultMetadataType", DoNotGenerateAcw=true)]
	public sealed partial class ResultMetadataType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='BYTE_SEGMENTS']"
		[Register ("BYTE_SEGMENTS")]
		public static global::Com.Google.Zxing.ResultMetadataType? ByteSegments {
			get {
				const string __id = "BYTE_SEGMENTS.Lcom/google/zxing/ResultMetadataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='ERROR_CORRECTION_LEVEL']"
		[Register ("ERROR_CORRECTION_LEVEL")]
		public static global::Com.Google.Zxing.ResultMetadataType? ErrorCorrectionLevel {
			get {
				const string __id = "ERROR_CORRECTION_LEVEL.Lcom/google/zxing/ResultMetadataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='ISSUE_NUMBER']"
		[Register ("ISSUE_NUMBER")]
		public static global::Com.Google.Zxing.ResultMetadataType? IssueNumber {
			get {
				const string __id = "ISSUE_NUMBER.Lcom/google/zxing/ResultMetadataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='ORIENTATION']"
		[Register ("ORIENTATION")]
		public static global::Com.Google.Zxing.ResultMetadataType? Orientation {
			get {
				const string __id = "ORIENTATION.Lcom/google/zxing/ResultMetadataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='OTHER']"
		[Register ("OTHER")]
		public static global::Com.Google.Zxing.ResultMetadataType? Other {
			get {
				const string __id = "OTHER.Lcom/google/zxing/ResultMetadataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='PDF417_EXTRA_METADATA']"
		[Register ("PDF417_EXTRA_METADATA")]
		public static global::Com.Google.Zxing.ResultMetadataType? Pdf417ExtraMetadata {
			get {
				const string __id = "PDF417_EXTRA_METADATA.Lcom/google/zxing/ResultMetadataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='POSSIBLE_COUNTRY']"
		[Register ("POSSIBLE_COUNTRY")]
		public static global::Com.Google.Zxing.ResultMetadataType? PossibleCountry {
			get {
				const string __id = "POSSIBLE_COUNTRY.Lcom/google/zxing/ResultMetadataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='STRUCTURED_APPEND_PARITY']"
		[Register ("STRUCTURED_APPEND_PARITY")]
		public static global::Com.Google.Zxing.ResultMetadataType? StructuredAppendParity {
			get {
				const string __id = "STRUCTURED_APPEND_PARITY.Lcom/google/zxing/ResultMetadataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='STRUCTURED_APPEND_SEQUENCE']"
		[Register ("STRUCTURED_APPEND_SEQUENCE")]
		public static global::Com.Google.Zxing.ResultMetadataType? StructuredAppendSequence {
			get {
				const string __id = "STRUCTURED_APPEND_SEQUENCE.Lcom/google/zxing/ResultMetadataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='SUGGESTED_PRICE']"
		[Register ("SUGGESTED_PRICE")]
		public static global::Com.Google.Zxing.ResultMetadataType? SuggestedPrice {
			get {
				const string __id = "SUGGESTED_PRICE.Lcom/google/zxing/ResultMetadataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='UPC_EAN_EXTENSION']"
		[Register ("UPC_EAN_EXTENSION")]
		public static global::Com.Google.Zxing.ResultMetadataType? UpcEanExtension {
			get {
				const string __id = "UPC_EAN_EXTENSION.Lcom/google/zxing/ResultMetadataType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/ResultMetadataType", typeof (ResultMetadataType));

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

		internal ResultMetadataType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/ResultMetadataType;", "")]
		public static unsafe global::Com.Google.Zxing.ResultMetadataType? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/zxing/ResultMetadataType;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/ResultMetadataType;", "")]
		public static unsafe global::Com.Google.Zxing.ResultMetadataType[]? Values ()
		{
			const string __id = "values.()[Lcom/google/zxing/ResultMetadataType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Google.Zxing.ResultMetadataType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.ResultMetadataType));
			} finally {
			}
		}

	}
}
