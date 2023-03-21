using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']"
	[global::Android.Runtime.Register ("com/google/zxing/BarcodeFormat", DoNotGenerateAcw=true)]
	public sealed partial class BarcodeFormat : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='AZTEC']"
		[Register ("AZTEC")]
		public static global::Com.Google.Zxing.BarcodeFormat? Aztec {
			get {
				const string __id = "AZTEC.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='CODABAR']"
		[Register ("CODABAR")]
		public static global::Com.Google.Zxing.BarcodeFormat? Codabar {
			get {
				const string __id = "CODABAR.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='CODE_128']"
		[Register ("CODE_128")]
		public static global::Com.Google.Zxing.BarcodeFormat? Code128 {
			get {
				const string __id = "CODE_128.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='CODE_39']"
		[Register ("CODE_39")]
		public static global::Com.Google.Zxing.BarcodeFormat? Code39 {
			get {
				const string __id = "CODE_39.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='CODE_93']"
		[Register ("CODE_93")]
		public static global::Com.Google.Zxing.BarcodeFormat? Code93 {
			get {
				const string __id = "CODE_93.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='DATA_MATRIX']"
		[Register ("DATA_MATRIX")]
		public static global::Com.Google.Zxing.BarcodeFormat? DataMatrix {
			get {
				const string __id = "DATA_MATRIX.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='EAN_13']"
		[Register ("EAN_13")]
		public static global::Com.Google.Zxing.BarcodeFormat? Ean13 {
			get {
				const string __id = "EAN_13.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='EAN_8']"
		[Register ("EAN_8")]
		public static global::Com.Google.Zxing.BarcodeFormat? Ean8 {
			get {
				const string __id = "EAN_8.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='ITF']"
		[Register ("ITF")]
		public static global::Com.Google.Zxing.BarcodeFormat? Itf {
			get {
				const string __id = "ITF.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='MAXICODE']"
		[Register ("MAXICODE")]
		public static global::Com.Google.Zxing.BarcodeFormat? Maxicode {
			get {
				const string __id = "MAXICODE.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='PDF_417']"
		[Register ("PDF_417")]
		public static global::Com.Google.Zxing.BarcodeFormat? Pdf417 {
			get {
				const string __id = "PDF_417.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='QR_CODE']"
		[Register ("QR_CODE")]
		public static global::Com.Google.Zxing.BarcodeFormat? QrCode {
			get {
				const string __id = "QR_CODE.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='RSS_14']"
		[Register ("RSS_14")]
		public static global::Com.Google.Zxing.BarcodeFormat? Rss14 {
			get {
				const string __id = "RSS_14.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='RSS_EXPANDED']"
		[Register ("RSS_EXPANDED")]
		public static global::Com.Google.Zxing.BarcodeFormat? RssExpanded {
			get {
				const string __id = "RSS_EXPANDED.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='UPC_A']"
		[Register ("UPC_A")]
		public static global::Com.Google.Zxing.BarcodeFormat? UpcA {
			get {
				const string __id = "UPC_A.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='UPC_E']"
		[Register ("UPC_E")]
		public static global::Com.Google.Zxing.BarcodeFormat? UpcE {
			get {
				const string __id = "UPC_E.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='UPC_EAN_EXTENSION']"
		[Register ("UPC_EAN_EXTENSION")]
		public static global::Com.Google.Zxing.BarcodeFormat? UpcEanExtension {
			get {
				const string __id = "UPC_EAN_EXTENSION.Lcom/google/zxing/BarcodeFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/BarcodeFormat", typeof (BarcodeFormat));

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

		internal BarcodeFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/BarcodeFormat;", "")]
		public static unsafe global::Com.Google.Zxing.BarcodeFormat? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/zxing/BarcodeFormat;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/BarcodeFormat;", "")]
		public static unsafe global::Com.Google.Zxing.BarcodeFormat[]? Values ()
		{
			const string __id = "values.()[Lcom/google/zxing/BarcodeFormat;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Google.Zxing.BarcodeFormat[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.BarcodeFormat));
			} finally {
			}
		}

	}
}
