using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Qrcode.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/decoder/Version", DoNotGenerateAcw=true)]
	public sealed partial class Version : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECB']"
		[global::Android.Runtime.Register ("com/google/zxing/qrcode/decoder/Version$ECB", DoNotGenerateAcw=true)]
		public sealed partial class ECB : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/qrcode/decoder/Version$ECB", typeof (ECB));

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

			internal ECB (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			public unsafe int Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECB']/method[@name='getCount' and count(parameter)=0]"
				[Register ("getCount", "()I", "")]
				get {
					const string __id = "getCount.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe int DataCodewords {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECB']/method[@name='getDataCodewords' and count(parameter)=0]"
				[Register ("getDataCodewords", "()I", "")]
				get {
					const string __id = "getDataCodewords.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECBlocks']"
		[global::Android.Runtime.Register ("com/google/zxing/qrcode/decoder/Version$ECBlocks", DoNotGenerateAcw=true)]
		public sealed partial class ECBlocks : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/qrcode/decoder/Version$ECBlocks", typeof (ECBlocks));

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

			internal ECBlocks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			public unsafe int ECCodewordsPerBlock {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECBlocks']/method[@name='getECCodewordsPerBlock' and count(parameter)=0]"
				[Register ("getECCodewordsPerBlock", "()I", "")]
				get {
					const string __id = "getECCodewordsPerBlock.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe int NumBlocks {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECBlocks']/method[@name='getNumBlocks' and count(parameter)=0]"
				[Register ("getNumBlocks", "()I", "")]
				get {
					const string __id = "getNumBlocks.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe int TotalECCodewords {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECBlocks']/method[@name='getTotalECCodewords' and count(parameter)=0]"
				[Register ("getTotalECCodewords", "()I", "")]
				get {
					const string __id = "getTotalECCodewords.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECBlocks']/method[@name='getECBlocks' and count(parameter)=0]"
			[Register ("getECBlocks", "()[Lcom/google/zxing/qrcode/decoder/Version$ECB;", "")]
			public unsafe global::Com.Google.Zxing.Qrcode.Decoder.Version.ECB[]? GetECBlocks ()
			{
				const string __id = "getECBlocks.()[Lcom/google/zxing/qrcode/decoder/Version$ECB;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (global::Com.Google.Zxing.Qrcode.Decoder.Version.ECB[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Qrcode.Decoder.Version.ECB));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/qrcode/decoder/Version", typeof (Version));

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

		internal Version (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe int DimensionForVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getDimensionForVersion' and count(parameter)=0]"
			[Register ("getDimensionForVersion", "()I", "")]
			get {
				const string __id = "getDimensionForVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int TotalCodewords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getTotalCodewords' and count(parameter)=0]"
			[Register ("getTotalCodewords", "()I", "")]
			get {
				const string __id = "getTotalCodewords.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int VersionNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getVersionNumber' and count(parameter)=0]"
			[Register ("getVersionNumber", "()I", "")]
			get {
				const string __id = "getVersionNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getAlignmentPatternCenters' and count(parameter)=0]"
		[Register ("getAlignmentPatternCenters", "()[I", "")]
		public unsafe int[]? GetAlignmentPatternCenters ()
		{
			const string __id = "getAlignmentPatternCenters.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getECBlocksForLevel' and count(parameter)=1 and parameter[1][@type='com.google.zxing.qrcode.decoder.ErrorCorrectionLevel']]"
		[Register ("getECBlocksForLevel", "(Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;)Lcom/google/zxing/qrcode/decoder/Version$ECBlocks;", "")]
		public unsafe global::Com.Google.Zxing.Qrcode.Decoder.Version.ECBlocks? GetECBlocksForLevel (global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel? ecLevel)
		{
			const string __id = "getECBlocksForLevel.(Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;)Lcom/google/zxing/qrcode/decoder/Version$ECBlocks;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ecLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ecLevel).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Version.ECBlocks> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (ecLevel);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getProvisionalVersionForDimension' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getProvisionalVersionForDimension", "(I)Lcom/google/zxing/qrcode/decoder/Version;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.Version? GetProvisionalVersionForDimension (int dimension)
		{
			const string __id = "getProvisionalVersionForDimension.(I)Lcom/google/zxing/qrcode/decoder/Version;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dimension);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Version> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getVersionForNumber' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getVersionForNumber", "(I)Lcom/google/zxing/qrcode/decoder/Version;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.Version? GetVersionForNumber (int versionNumber)
		{
			const string __id = "getVersionForNumber.(I)Lcom/google/zxing/qrcode/decoder/Version;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (versionNumber);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Version> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
