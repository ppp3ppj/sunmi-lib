using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Pdf417.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.decoder']/class[@name='PDF417ScanningDecoder']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/decoder/PDF417ScanningDecoder", DoNotGenerateAcw=true)]
	public sealed partial class PDF417ScanningDecoder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/pdf417/decoder/PDF417ScanningDecoder", typeof (PDF417ScanningDecoder));

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

		internal PDF417ScanningDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.decoder']/class[@name='PDF417ScanningDecoder']/method[@name='decode' and count(parameter)=7 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='com.google.zxing.ResultPoint'] and parameter[3][@type='com.google.zxing.ResultPoint'] and parameter[4][@type='com.google.zxing.ResultPoint'] and parameter[5][@type='com.google.zxing.ResultPoint'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("decode", "(Lcom/google/zxing/common/BitMatrix;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;II)Lcom/google/zxing/common/DecoderResult;", "")]
		public static unsafe global::Com.Google.Zxing.Common.DecoderResult? Decode (global::Com.Google.Zxing.Common.BitMatrix? image, global::Com.Google.Zxing.ResultPoint? imageTopLeft, global::Com.Google.Zxing.ResultPoint? imageBottomLeft, global::Com.Google.Zxing.ResultPoint? imageTopRight, global::Com.Google.Zxing.ResultPoint? imageBottomRight, int minCodewordWidth, int maxCodewordWidth)
		{
			const string __id = "decode.(Lcom/google/zxing/common/BitMatrix;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;II)Lcom/google/zxing/common/DecoderResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				__args [1] = new JniArgumentValue ((imageTopLeft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageTopLeft).Handle);
				__args [2] = new JniArgumentValue ((imageBottomLeft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageBottomLeft).Handle);
				__args [3] = new JniArgumentValue ((imageTopRight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageTopRight).Handle);
				__args [4] = new JniArgumentValue ((imageBottomRight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageBottomRight).Handle);
				__args [5] = new JniArgumentValue (minCodewordWidth);
				__args [6] = new JniArgumentValue (maxCodewordWidth);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DecoderResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (image);
				global::System.GC.KeepAlive (imageTopLeft);
				global::System.GC.KeepAlive (imageBottomLeft);
				global::System.GC.KeepAlive (imageTopRight);
				global::System.GC.KeepAlive (imageBottomRight);
			}
		}

	}
}
