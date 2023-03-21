using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/ParsedResultType", DoNotGenerateAcw=true)]
	public sealed partial class ParsedResultType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='ADDRESSBOOK']"
		[Register ("ADDRESSBOOK")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType? Addressbook {
			get {
				const string __id = "ADDRESSBOOK.Lcom/google/zxing/client/result/ParsedResultType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='CALENDAR']"
		[Register ("CALENDAR")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType? Calendar {
			get {
				const string __id = "CALENDAR.Lcom/google/zxing/client/result/ParsedResultType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='EMAIL_ADDRESS']"
		[Register ("EMAIL_ADDRESS")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType? EmailAddress {
			get {
				const string __id = "EMAIL_ADDRESS.Lcom/google/zxing/client/result/ParsedResultType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='GEO']"
		[Register ("GEO")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType? Geo {
			get {
				const string __id = "GEO.Lcom/google/zxing/client/result/ParsedResultType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='ISBN']"
		[Register ("ISBN")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType? Isbn {
			get {
				const string __id = "ISBN.Lcom/google/zxing/client/result/ParsedResultType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='PRODUCT']"
		[Register ("PRODUCT")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType? Product {
			get {
				const string __id = "PRODUCT.Lcom/google/zxing/client/result/ParsedResultType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='SMS']"
		[Register ("SMS")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType? Sms {
			get {
				const string __id = "SMS.Lcom/google/zxing/client/result/ParsedResultType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='TEL']"
		[Register ("TEL")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType? Tel {
			get {
				const string __id = "TEL.Lcom/google/zxing/client/result/ParsedResultType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='TEXT']"
		[Register ("TEXT")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType? Text {
			get {
				const string __id = "TEXT.Lcom/google/zxing/client/result/ParsedResultType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='URI']"
		[Register ("URI")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType? Uri {
			get {
				const string __id = "URI.Lcom/google/zxing/client/result/ParsedResultType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='VIN']"
		[Register ("VIN")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType? Vin {
			get {
				const string __id = "VIN.Lcom/google/zxing/client/result/ParsedResultType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='WIFI']"
		[Register ("WIFI")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType? Wifi {
			get {
				const string __id = "WIFI.Lcom/google/zxing/client/result/ParsedResultType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/client/result/ParsedResultType", typeof (ParsedResultType));

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

		internal ParsedResultType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/client/result/ParsedResultType;", "")]
		public static unsafe global::Com.Google.Zxing.Client.Result.ParsedResultType? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/google/zxing/client/result/ParsedResultType;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/client/result/ParsedResultType;", "")]
		public static unsafe global::Com.Google.Zxing.Client.Result.ParsedResultType[]? Values ()
		{
			const string __id = "values.()[Lcom/google/zxing/client/result/ParsedResultType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Google.Zxing.Client.Result.ParsedResultType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Client.Result.ParsedResultType));
			} finally {
			}
		}

	}
}
