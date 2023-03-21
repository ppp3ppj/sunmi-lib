using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/ExpandedProductParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class ExpandedProductParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/field[@name='KILOGRAM']"
		[Register ("KILOGRAM")]
		public const string Kilogram = (string) "KG";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/field[@name='POUND']"
		[Register ("POUND")]
		public const string Pound = (string) "LB";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/client/result/ExpandedProductParsedResult", typeof (ExpandedProductParsedResult));

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

		internal ExpandedProductParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/constructor[@name='ExpandedProductParsedResult' and count(parameter)=15 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='java.lang.String'] and parameter[12][@type='java.lang.String'] and parameter[13][@type='java.lang.String'] and parameter[14][@type='java.lang.String'] and parameter[15][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe ExpandedProductParsedResult (string? rawText, string? productID, string? sscc, string? lotNumber, string? productionDate, string? packagingDate, string? bestBeforeDate, string? expirationDate, string? weight, string? weightType, string? weightIncrement, string? price, string? priceIncrement, string? priceCurrency, global::System.Collections.Generic.IDictionary<string, string>? uncommonAIs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rawText = JNIEnv.NewString ((string?)rawText);
			IntPtr native_productID = JNIEnv.NewString ((string?)productID);
			IntPtr native_sscc = JNIEnv.NewString ((string?)sscc);
			IntPtr native_lotNumber = JNIEnv.NewString ((string?)lotNumber);
			IntPtr native_productionDate = JNIEnv.NewString ((string?)productionDate);
			IntPtr native_packagingDate = JNIEnv.NewString ((string?)packagingDate);
			IntPtr native_bestBeforeDate = JNIEnv.NewString ((string?)bestBeforeDate);
			IntPtr native_expirationDate = JNIEnv.NewString ((string?)expirationDate);
			IntPtr native_weight = JNIEnv.NewString ((string?)weight);
			IntPtr native_weightType = JNIEnv.NewString ((string?)weightType);
			IntPtr native_weightIncrement = JNIEnv.NewString ((string?)weightIncrement);
			IntPtr native_price = JNIEnv.NewString ((string?)price);
			IntPtr native_priceIncrement = JNIEnv.NewString ((string?)priceIncrement);
			IntPtr native_priceCurrency = JNIEnv.NewString ((string?)priceCurrency);
			IntPtr native_uncommonAIs = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (uncommonAIs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [15];
				__args [0] = new JniArgumentValue (native_rawText);
				__args [1] = new JniArgumentValue (native_productID);
				__args [2] = new JniArgumentValue (native_sscc);
				__args [3] = new JniArgumentValue (native_lotNumber);
				__args [4] = new JniArgumentValue (native_productionDate);
				__args [5] = new JniArgumentValue (native_packagingDate);
				__args [6] = new JniArgumentValue (native_bestBeforeDate);
				__args [7] = new JniArgumentValue (native_expirationDate);
				__args [8] = new JniArgumentValue (native_weight);
				__args [9] = new JniArgumentValue (native_weightType);
				__args [10] = new JniArgumentValue (native_weightIncrement);
				__args [11] = new JniArgumentValue (native_price);
				__args [12] = new JniArgumentValue (native_priceIncrement);
				__args [13] = new JniArgumentValue (native_priceCurrency);
				__args [14] = new JniArgumentValue (native_uncommonAIs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_rawText);
				JNIEnv.DeleteLocalRef (native_productID);
				JNIEnv.DeleteLocalRef (native_sscc);
				JNIEnv.DeleteLocalRef (native_lotNumber);
				JNIEnv.DeleteLocalRef (native_productionDate);
				JNIEnv.DeleteLocalRef (native_packagingDate);
				JNIEnv.DeleteLocalRef (native_bestBeforeDate);
				JNIEnv.DeleteLocalRef (native_expirationDate);
				JNIEnv.DeleteLocalRef (native_weight);
				JNIEnv.DeleteLocalRef (native_weightType);
				JNIEnv.DeleteLocalRef (native_weightIncrement);
				JNIEnv.DeleteLocalRef (native_price);
				JNIEnv.DeleteLocalRef (native_priceIncrement);
				JNIEnv.DeleteLocalRef (native_priceCurrency);
				JNIEnv.DeleteLocalRef (native_uncommonAIs);
				global::System.GC.KeepAlive (uncommonAIs);
			}
		}

		public unsafe string? BestBeforeDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getBestBeforeDate' and count(parameter)=0]"
			[Register ("getBestBeforeDate", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getBestBeforeDate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string? DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
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

		public unsafe string? ExpirationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getExpirationDate' and count(parameter)=0]"
			[Register ("getExpirationDate", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getExpirationDate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? LotNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getLotNumber' and count(parameter)=0]"
			[Register ("getLotNumber", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLotNumber.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? PackagingDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getPackagingDate' and count(parameter)=0]"
			[Register ("getPackagingDate", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getPackagingDate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? Price {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getPrice' and count(parameter)=0]"
			[Register ("getPrice", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getPrice.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? PriceCurrency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getPriceCurrency' and count(parameter)=0]"
			[Register ("getPriceCurrency", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getPriceCurrency.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? PriceIncrement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getPriceIncrement' and count(parameter)=0]"
			[Register ("getPriceIncrement", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getPriceIncrement.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? ProductID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getProductID' and count(parameter)=0]"
			[Register ("getProductID", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getProductID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? ProductionDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getProductionDate' and count(parameter)=0]"
			[Register ("getProductionDate", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getProductionDate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? RawText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getRawText' and count(parameter)=0]"
			[Register ("getRawText", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getRawText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? Sscc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getSscc' and count(parameter)=0]"
			[Register ("getSscc", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSscc.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<string, string>? UncommonAIs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getUncommonAIs' and count(parameter)=0]"
			[Register ("getUncommonAIs", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getUncommonAIs.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? Weight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getWeight' and count(parameter)=0]"
			[Register ("getWeight", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getWeight.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? WeightIncrement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getWeightIncrement' and count(parameter)=0]"
			[Register ("getWeightIncrement", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getWeightIncrement.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? WeightType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getWeightType' and count(parameter)=0]"
			[Register ("getWeightType", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getWeightType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
