using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Pdf417 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/PDF417Common", DoNotGenerateAcw=true)]
	public sealed partial class PDF417Common : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='BARS_IN_MODULE']"
		[Register ("BARS_IN_MODULE")]
		public const int BarsInModule = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='MAX_CODEWORDS_IN_BARCODE']"
		[Register ("MAX_CODEWORDS_IN_BARCODE")]
		public const int MaxCodewordsInBarcode = (int) 928;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='MAX_ROWS_IN_BARCODE']"
		[Register ("MAX_ROWS_IN_BARCODE")]
		public const int MaxRowsInBarcode = (int) 90;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='MIN_ROWS_IN_BARCODE']"
		[Register ("MIN_ROWS_IN_BARCODE")]
		public const int MinRowsInBarcode = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='MODULES_IN_CODEWORD']"
		[Register ("MODULES_IN_CODEWORD")]
		public const int ModulesInCodeword = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='MODULES_IN_STOP_PATTERN']"
		[Register ("MODULES_IN_STOP_PATTERN")]
		public const int ModulesInStopPattern = (int) 18;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='NUMBER_OF_CODEWORDS']"
		[Register ("NUMBER_OF_CODEWORDS")]
		public const int NumberOfCodewords = (int) 929;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='SYMBOL_TABLE']"
		[Register ("SYMBOL_TABLE")]
		public static IList<int>? SymbolTable {
			get {
				const string __id = "SYMBOL_TABLE.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/pdf417/PDF417Common", typeof (PDF417Common));

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

		internal PDF417Common (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/method[@name='getBitCountSum' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("getBitCountSum", "([I)I", "")]
		public static unsafe int GetBitCountSum (int[]? moduleBitCount)
		{
			const string __id = "getBitCountSum.([I)I";
			IntPtr native_moduleBitCount = JNIEnv.NewArray (moduleBitCount);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_moduleBitCount);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (moduleBitCount != null) {
					JNIEnv.CopyArray (native_moduleBitCount, moduleBitCount);
					JNIEnv.DeleteLocalRef (native_moduleBitCount);
				}
				global::System.GC.KeepAlive (moduleBitCount);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/method[@name='getCodeword' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCodeword", "(I)I", "")]
		public static unsafe int GetCodeword (int symbol)
		{
			const string __id = "getCodeword.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (symbol);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/method[@name='toIntArray' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.Integer&gt;']]"
		[Register ("toIntArray", "(Ljava/util/Collection;)[I", "")]
		public static unsafe int[]? ToIntArray (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>? list)
		{
			const string __id = "toIntArray.(Ljava/util/Collection;)[I";
			IntPtr native_list = global::Android.Runtime.JavaCollection<global::Java.Lang.Integer>.ToLocalJniHandle (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_list);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
				global::System.GC.KeepAlive (list);
			}
		}

	}
}
