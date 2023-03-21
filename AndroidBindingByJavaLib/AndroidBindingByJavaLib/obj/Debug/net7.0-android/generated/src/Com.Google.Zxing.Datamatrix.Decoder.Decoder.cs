using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Datamatrix.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Decoder']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/decoder/Decoder", DoNotGenerateAcw=true)]
	public sealed partial class Decoder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/datamatrix/decoder/Decoder", typeof (Decoder));

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

		internal Decoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Decoder']/constructor[@name='Decoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Decoder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Decoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='boolean[][]']]"
		[Register ("decode", "([[Z)Lcom/google/zxing/common/DecoderResult;", "")]
		public unsafe global::Com.Google.Zxing.Common.DecoderResult? Decode (bool[][]? image)
		{
			const string __id = "decode.([[Z)Lcom/google/zxing/common/DecoderResult;";
			IntPtr native_image = JNIEnv.NewArray (image);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_image);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DecoderResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (image != null) {
					JNIEnv.CopyArray (native_image, image);
					JNIEnv.DeleteLocalRef (native_image);
				}
				global::System.GC.KeepAlive (image);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Decoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register ("decode", "(Lcom/google/zxing/common/BitMatrix;)Lcom/google/zxing/common/DecoderResult;", "")]
		public unsafe global::Com.Google.Zxing.Common.DecoderResult? Decode (global::Com.Google.Zxing.Common.BitMatrix? bits)
		{
			const string __id = "decode.(Lcom/google/zxing/common/BitMatrix;)Lcom/google/zxing/common/DecoderResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bits == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bits).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DecoderResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bits);
			}
		}

	}
}
