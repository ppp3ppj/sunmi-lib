using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Qrcode.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='QRCodeDecoderMetaData']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/decoder/QRCodeDecoderMetaData", DoNotGenerateAcw=true)]
	public sealed partial class QRCodeDecoderMetaData : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/qrcode/decoder/QRCodeDecoderMetaData", typeof (QRCodeDecoderMetaData));

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

		internal QRCodeDecoderMetaData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe bool IsMirrored {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='QRCodeDecoderMetaData']/method[@name='isMirrored' and count(parameter)=0]"
			[Register ("isMirrored", "()Z", "")]
			get {
				const string __id = "isMirrored.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='QRCodeDecoderMetaData']/method[@name='applyMirroredCorrection' and count(parameter)=1 and parameter[1][@type='com.google.zxing.ResultPoint[]']]"
		[Register ("applyMirroredCorrection", "([Lcom/google/zxing/ResultPoint;)V", "")]
		public unsafe void ApplyMirroredCorrection (global::Com.Google.Zxing.ResultPoint[]? points)
		{
			const string __id = "applyMirroredCorrection.([Lcom/google/zxing/ResultPoint;)V";
			IntPtr native_points = JNIEnv.NewArray (points);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_points);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (points != null) {
					JNIEnv.CopyArray (native_points, points);
					JNIEnv.DeleteLocalRef (native_points);
				}
				global::System.GC.KeepAlive (points);
			}
		}

	}
}
