using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ProductParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/ProductParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class ProductParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/client/result/ProductParsedResult", typeof (ProductParsedResult));

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

		internal ProductParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public override unsafe string? DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ProductParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
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

		public unsafe string? NormalizedProductID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ProductParsedResult']/method[@name='getNormalizedProductID' and count(parameter)=0]"
			[Register ("getNormalizedProductID", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getNormalizedProductID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? ProductID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ProductParsedResult']/method[@name='getProductID' and count(parameter)=0]"
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

	}
}
