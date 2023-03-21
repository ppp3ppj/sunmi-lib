using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Datamatrix.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/decoder/Version", DoNotGenerateAcw=true)]
	public sealed partial class Version : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/datamatrix/decoder/Version", typeof (Version));

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

		public unsafe int DataRegionSizeColumns {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getDataRegionSizeColumns' and count(parameter)=0]"
			[Register ("getDataRegionSizeColumns", "()I", "")]
			get {
				const string __id = "getDataRegionSizeColumns.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int DataRegionSizeRows {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getDataRegionSizeRows' and count(parameter)=0]"
			[Register ("getDataRegionSizeRows", "()I", "")]
			get {
				const string __id = "getDataRegionSizeRows.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int SymbolSizeColumns {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getSymbolSizeColumns' and count(parameter)=0]"
			[Register ("getSymbolSizeColumns", "()I", "")]
			get {
				const string __id = "getSymbolSizeColumns.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int SymbolSizeRows {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getSymbolSizeRows' and count(parameter)=0]"
			[Register ("getSymbolSizeRows", "()I", "")]
			get {
				const string __id = "getSymbolSizeRows.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int TotalCodewords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getTotalCodewords' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getVersionNumber' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getVersionForDimensions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getVersionForDimensions", "(II)Lcom/google/zxing/datamatrix/decoder/Version;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Decoder.Version? GetVersionForDimensions (int numRows, int numColumns)
		{
			const string __id = "getVersionForDimensions.(II)Lcom/google/zxing/datamatrix/decoder/Version;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (numRows);
				__args [1] = new JniArgumentValue (numColumns);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Decoder.Version> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
