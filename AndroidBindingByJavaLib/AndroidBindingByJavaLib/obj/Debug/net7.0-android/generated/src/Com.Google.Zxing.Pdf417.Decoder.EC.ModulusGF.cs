using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Pdf417.Decoder.EC {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.decoder.ec']/class[@name='ModulusGF']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/decoder/ec/ModulusGF", DoNotGenerateAcw=true)]
	public sealed partial class ModulusGF : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417.decoder.ec']/class[@name='ModulusGF']/field[@name='PDF417_GF']"
		[Register ("PDF417_GF")]
		public static global::Com.Google.Zxing.Pdf417.Decoder.EC.ModulusGF? Pdf417Gf {
			get {
				const string __id = "PDF417_GF.Lcom/google/zxing/pdf417/decoder/ec/ModulusGF;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Decoder.EC.ModulusGF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/pdf417/decoder/ec/ModulusGF", typeof (ModulusGF));

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

		internal ModulusGF (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
