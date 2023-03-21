using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Oned.Rss.Expanded.Decoders {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned.rss.expanded.decoders']/class[@name='AbstractExpandedDecoder']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/rss/expanded/decoders/AbstractExpandedDecoder", DoNotGenerateAcw=true)]
	public abstract partial class AbstractExpandedDecoder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/oned/rss/expanded/decoders/AbstractExpandedDecoder", typeof (AbstractExpandedDecoder));

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

		protected AbstractExpandedDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		protected unsafe global::Com.Google.Zxing.Common.BitArray? Information {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss.expanded.decoders']/class[@name='AbstractExpandedDecoder']/method[@name='getInformation' and count(parameter)=0]"
			[Register ("getInformation", "()Lcom/google/zxing/common/BitArray;", "")]
			get {
				const string __id = "getInformation.()Lcom/google/zxing/common/BitArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss.expanded.decoders']/class[@name='AbstractExpandedDecoder']/method[@name='createDecoder' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitArray']]"
		[Register ("createDecoder", "(Lcom/google/zxing/common/BitArray;)Lcom/google/zxing/oned/rss/expanded/decoders/AbstractExpandedDecoder;", "")]
		public static unsafe global::Com.Google.Zxing.Oned.Rss.Expanded.Decoders.AbstractExpandedDecoder? CreateDecoder (global::Com.Google.Zxing.Common.BitArray? information)
		{
			const string __id = "createDecoder.(Lcom/google/zxing/common/BitArray;)Lcom/google/zxing/oned/rss/expanded/decoders/AbstractExpandedDecoder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((information == null) ? IntPtr.Zero : ((global::Java.Lang.Object) information).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.Rss.Expanded.Decoders.AbstractExpandedDecoder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (information);
			}
		}

		static Delegate? cb_parseInformation;
#pragma warning disable 0169
		static Delegate GetParseInformationHandler ()
		{
			if (cb_parseInformation == null)
				cb_parseInformation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ParseInformation);
			return cb_parseInformation;
		}

		static IntPtr n_ParseInformation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.Rss.Expanded.Decoders.AbstractExpandedDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ParseInformation ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss.expanded.decoders']/class[@name='AbstractExpandedDecoder']/method[@name='parseInformation' and count(parameter)=0]"
		[Register ("parseInformation", "()Ljava/lang/String;", "GetParseInformationHandler")]
		public abstract string? ParseInformation ();

	}

	[global::Android.Runtime.Register ("com/google/zxing/oned/rss/expanded/decoders/AbstractExpandedDecoder", DoNotGenerateAcw=true)]
	internal partial class AbstractExpandedDecoderInvoker : AbstractExpandedDecoder {
		public AbstractExpandedDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/oned/rss/expanded/decoders/AbstractExpandedDecoder", typeof (AbstractExpandedDecoderInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss.expanded.decoders']/class[@name='AbstractExpandedDecoder']/method[@name='parseInformation' and count(parameter)=0]"
		[Register ("parseInformation", "()Ljava/lang/String;", "GetParseInformationHandler")]
		public override unsafe string? ParseInformation ()
		{
			const string __id = "parseInformation.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
