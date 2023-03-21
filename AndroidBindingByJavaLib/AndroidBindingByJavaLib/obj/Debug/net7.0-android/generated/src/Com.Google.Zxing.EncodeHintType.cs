using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']"
	[global::Android.Runtime.Register ("com/google/zxing/EncodeHintType", DoNotGenerateAcw=true)]
	public sealed partial class EncodeHintType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='AZTEC_LAYERS']"
		[Register ("AZTEC_LAYERS")]
		public static global::Com.Google.Zxing.EncodeHintType? AztecLayers {
			get {
				const string __id = "AZTEC_LAYERS.Lcom/google/zxing/EncodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='CHARACTER_SET']"
		[Register ("CHARACTER_SET")]
		public static global::Com.Google.Zxing.EncodeHintType? CharacterSet {
			get {
				const string __id = "CHARACTER_SET.Lcom/google/zxing/EncodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='DATA_MATRIX_SHAPE']"
		[Register ("DATA_MATRIX_SHAPE")]
		public static global::Com.Google.Zxing.EncodeHintType? DataMatrixShape {
			get {
				const string __id = "DATA_MATRIX_SHAPE.Lcom/google/zxing/EncodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='ERROR_CORRECTION']"
		[Register ("ERROR_CORRECTION")]
		public static global::Com.Google.Zxing.EncodeHintType? ErrorCorrection {
			get {
				const string __id = "ERROR_CORRECTION.Lcom/google/zxing/EncodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='MARGIN']"
		[Register ("MARGIN")]
		public static global::Com.Google.Zxing.EncodeHintType? Margin {
			get {
				const string __id = "MARGIN.Lcom/google/zxing/EncodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='MAX_SIZE']"
		[Register ("MAX_SIZE")]
		[global::System.Obsolete (@"deprecated")]
		public static global::Com.Google.Zxing.EncodeHintType? MaxSize {
			get {
				const string __id = "MAX_SIZE.Lcom/google/zxing/EncodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='MIN_SIZE']"
		[Register ("MIN_SIZE")]
		[global::System.Obsolete (@"deprecated")]
		public static global::Com.Google.Zxing.EncodeHintType? MinSize {
			get {
				const string __id = "MIN_SIZE.Lcom/google/zxing/EncodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='PDF417_COMPACT']"
		[Register ("PDF417_COMPACT")]
		public static global::Com.Google.Zxing.EncodeHintType? Pdf417Compact {
			get {
				const string __id = "PDF417_COMPACT.Lcom/google/zxing/EncodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='PDF417_COMPACTION']"
		[Register ("PDF417_COMPACTION")]
		public static global::Com.Google.Zxing.EncodeHintType? Pdf417Compaction {
			get {
				const string __id = "PDF417_COMPACTION.Lcom/google/zxing/EncodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='PDF417_DIMENSIONS']"
		[Register ("PDF417_DIMENSIONS")]
		public static global::Com.Google.Zxing.EncodeHintType? Pdf417Dimensions {
			get {
				const string __id = "PDF417_DIMENSIONS.Lcom/google/zxing/EncodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='QR_VERSION']"
		[Register ("QR_VERSION")]
		public static global::Com.Google.Zxing.EncodeHintType? QrVersion {
			get {
				const string __id = "QR_VERSION.Lcom/google/zxing/EncodeHintType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/EncodeHintType", typeof (EncodeHintType));

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

		internal EncodeHintType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/EncodeHintType;", "")]
		public static unsafe global::Com.Google.Zxing.EncodeHintType? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/zxing/EncodeHintType;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/EncodeHintType;", "")]
		public static unsafe global::Com.Google.Zxing.EncodeHintType[]? Values ()
		{
			const string __id = "values.()[Lcom/google/zxing/EncodeHintType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Google.Zxing.EncodeHintType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.EncodeHintType));
			} finally {
			}
		}

	}
}
