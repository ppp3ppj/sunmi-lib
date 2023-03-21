using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='NotFoundException']"
	[global::Android.Runtime.Register ("com/google/zxing/NotFoundException", DoNotGenerateAcw=true)]
	public sealed partial class NotFoundException : global::Com.Google.Zxing.ReaderException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/NotFoundException", typeof (NotFoundException));

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

		internal NotFoundException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Com.Google.Zxing.NotFoundException? NotFoundInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='NotFoundException']/method[@name='getNotFoundInstance' and count(parameter)=0]"
			[Register ("getNotFoundInstance", "()Lcom/google/zxing/NotFoundException;", "")]
			get {
				const string __id = "getNotFoundInstance.()Lcom/google/zxing/NotFoundException;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.NotFoundException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
