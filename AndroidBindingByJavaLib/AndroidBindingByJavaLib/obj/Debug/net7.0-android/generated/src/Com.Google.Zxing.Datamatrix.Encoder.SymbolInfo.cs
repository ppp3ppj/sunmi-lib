using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Datamatrix.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/encoder/SymbolInfo", DoNotGenerateAcw=true)]
	public partial class SymbolInfo : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/field[@name='matrixHeight']"
		[Register ("matrixHeight")]
		public int MatrixHeight {
			get {
				const string __id = "matrixHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "matrixHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/field[@name='matrixWidth']"
		[Register ("matrixWidth")]
		public int MatrixWidth {
			get {
				const string __id = "matrixWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "matrixWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/datamatrix/encoder/SymbolInfo", typeof (SymbolInfo));

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

		protected SymbolInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/constructor[@name='SymbolInfo' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register (".ctor", "(ZIIIII)V", "")]
		public unsafe SymbolInfo (bool rectangular, int dataCapacity, int errorCodewords, int matrixWidth, int matrixHeight, int dataRegions) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZIIIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (rectangular);
				__args [1] = new JniArgumentValue (dataCapacity);
				__args [2] = new JniArgumentValue (errorCodewords);
				__args [3] = new JniArgumentValue (matrixWidth);
				__args [4] = new JniArgumentValue (matrixHeight);
				__args [5] = new JniArgumentValue (dataRegions);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_getCodewordCount;
#pragma warning disable 0169
		static Delegate GetGetCodewordCountHandler ()
		{
			if (cb_getCodewordCount == null)
				cb_getCodewordCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCodewordCount);
			return cb_getCodewordCount;
		}

		static int n_GetCodewordCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CodewordCount;
		}
#pragma warning restore 0169

		public virtual unsafe int CodewordCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getCodewordCount' and count(parameter)=0]"
			[Register ("getCodewordCount", "()I", "GetGetCodewordCountHandler")]
			get {
				const string __id = "getCodewordCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int DataCapacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getDataCapacity' and count(parameter)=0]"
			[Register ("getDataCapacity", "()I", "")]
			get {
				const string __id = "getDataCapacity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int ErrorCodewords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getErrorCodewords' and count(parameter)=0]"
			[Register ("getErrorCodewords", "()I", "")]
			get {
				const string __id = "getErrorCodewords.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getInterleavedBlockCount;
#pragma warning disable 0169
		static Delegate GetGetInterleavedBlockCountHandler ()
		{
			if (cb_getInterleavedBlockCount == null)
				cb_getInterleavedBlockCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetInterleavedBlockCount);
			return cb_getInterleavedBlockCount;
		}

		static int n_GetInterleavedBlockCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.InterleavedBlockCount;
		}
#pragma warning restore 0169

		public virtual unsafe int InterleavedBlockCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getInterleavedBlockCount' and count(parameter)=0]"
			[Register ("getInterleavedBlockCount", "()I", "GetGetInterleavedBlockCountHandler")]
			get {
				const string __id = "getInterleavedBlockCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int SymbolDataHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getSymbolDataHeight' and count(parameter)=0]"
			[Register ("getSymbolDataHeight", "()I", "")]
			get {
				const string __id = "getSymbolDataHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int SymbolDataWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getSymbolDataWidth' and count(parameter)=0]"
			[Register ("getSymbolDataWidth", "()I", "")]
			get {
				const string __id = "getSymbolDataWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int SymbolHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getSymbolHeight' and count(parameter)=0]"
			[Register ("getSymbolHeight", "()I", "")]
			get {
				const string __id = "getSymbolHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int SymbolWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getSymbolWidth' and count(parameter)=0]"
			[Register ("getSymbolWidth", "()I", "")]
			get {
				const string __id = "getSymbolWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getDataLengthForInterleavedBlock_I;
#pragma warning disable 0169
		static Delegate GetGetDataLengthForInterleavedBlock_IHandler ()
		{
			if (cb_getDataLengthForInterleavedBlock_I == null)
				cb_getDataLengthForInterleavedBlock_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetDataLengthForInterleavedBlock_I);
			return cb_getDataLengthForInterleavedBlock_I;
		}

		static int n_GetDataLengthForInterleavedBlock_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.GetDataLengthForInterleavedBlock (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getDataLengthForInterleavedBlock' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDataLengthForInterleavedBlock", "(I)I", "GetGetDataLengthForInterleavedBlock_IHandler")]
		public virtual unsafe int GetDataLengthForInterleavedBlock (int index)
		{
			const string __id = "getDataLengthForInterleavedBlock.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getErrorLengthForInterleavedBlock' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getErrorLengthForInterleavedBlock", "(I)I", "")]
		public unsafe int GetErrorLengthForInterleavedBlock (int index)
		{
			const string __id = "getErrorLengthForInterleavedBlock.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='lookup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("lookup", "(I)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo? Lookup (int dataCodewords)
		{
			const string __id = "lookup.(I)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dataCodewords);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='lookup' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("lookup", "(IZZ)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo? Lookup (int dataCodewords, bool allowRectangular, bool fail)
		{
			const string __id = "lookup.(IZZ)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (dataCodewords);
				__args [1] = new JniArgumentValue (allowRectangular);
				__args [2] = new JniArgumentValue (fail);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='lookup' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.datamatrix.encoder.SymbolShapeHint']]"
		[Register ("lookup", "(ILcom/google/zxing/datamatrix/encoder/SymbolShapeHint;)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo? Lookup (int dataCodewords, global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint? shape)
		{
			const string __id = "lookup.(ILcom/google/zxing/datamatrix/encoder/SymbolShapeHint;)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (dataCodewords);
				__args [1] = new JniArgumentValue ((shape == null) ? IntPtr.Zero : ((global::Java.Lang.Object) shape).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (shape);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='lookup' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.datamatrix.encoder.SymbolShapeHint'] and parameter[3][@type='com.google.zxing.Dimension'] and parameter[4][@type='com.google.zxing.Dimension'] and parameter[5][@type='boolean']]"
		[Register ("lookup", "(ILcom/google/zxing/datamatrix/encoder/SymbolShapeHint;Lcom/google/zxing/Dimension;Lcom/google/zxing/Dimension;Z)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo? Lookup (int dataCodewords, global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint? shape, global::Com.Google.Zxing.Dimension? minSize, global::Com.Google.Zxing.Dimension? maxSize, bool fail)
		{
			const string __id = "lookup.(ILcom/google/zxing/datamatrix/encoder/SymbolShapeHint;Lcom/google/zxing/Dimension;Lcom/google/zxing/Dimension;Z)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (dataCodewords);
				__args [1] = new JniArgumentValue ((shape == null) ? IntPtr.Zero : ((global::Java.Lang.Object) shape).Handle);
				__args [2] = new JniArgumentValue ((minSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) minSize).Handle);
				__args [3] = new JniArgumentValue ((maxSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxSize).Handle);
				__args [4] = new JniArgumentValue (fail);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (shape);
				global::System.GC.KeepAlive (minSize);
				global::System.GC.KeepAlive (maxSize);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='overrideSymbolSet' and count(parameter)=1 and parameter[1][@type='com.google.zxing.datamatrix.encoder.SymbolInfo[]']]"
		[Register ("overrideSymbolSet", "([Lcom/google/zxing/datamatrix/encoder/SymbolInfo;)V", "")]
		public static unsafe void OverrideSymbolSet (global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo[]? @override)
		{
			const string __id = "overrideSymbolSet.([Lcom/google/zxing/datamatrix/encoder/SymbolInfo;)V";
			IntPtr native__override = JNIEnv.NewArray (@override);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__override);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (@override != null) {
					JNIEnv.CopyArray (native__override, @override);
					JNIEnv.DeleteLocalRef (native__override);
				}
				global::System.GC.KeepAlive (@override);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string? ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
