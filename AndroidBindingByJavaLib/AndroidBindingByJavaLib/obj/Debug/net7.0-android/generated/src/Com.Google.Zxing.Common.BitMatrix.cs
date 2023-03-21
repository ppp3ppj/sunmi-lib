using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']"
	[global::Android.Runtime.Register ("com/google/zxing/common/BitMatrix", DoNotGenerateAcw=true)]
	public sealed partial class BitMatrix : global::Java.Lang.Object, global::Java.Lang.ICloneable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/common/BitMatrix", typeof (BitMatrix));

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

		internal BitMatrix (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/constructor[@name='BitMatrix' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BitMatrix (int dimension) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dimension);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/constructor[@name='BitMatrix' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe BitMatrix (int width, int height) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "")]
			get {
				const string __id = "getHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int RowSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getRowSize' and count(parameter)=0]"
			[Register ("getRowSize", "()I", "")]
			get {
				const string __id = "getRowSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "")]
			get {
				const string __id = "getWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/google/zxing/common/BitMatrix;", "")]
		public unsafe global::Com.Google.Zxing.Common.BitMatrix? Clone ()
		{
			const string __id = "clone.()Lcom/google/zxing/common/BitMatrix;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='flip' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("flip", "(II)V", "")]
		public unsafe void Flip (int x, int y)
		{
			const string __id = "flip.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='get' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("get", "(II)Z", "")]
		public unsafe bool Get (int x, int y)
		{
			const string __id = "get.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getBottomRightOnBit' and count(parameter)=0]"
		[Register ("getBottomRightOnBit", "()[I", "")]
		public unsafe int[]? GetBottomRightOnBit ()
		{
			const string __id = "getBottomRightOnBit.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getEnclosingRectangle' and count(parameter)=0]"
		[Register ("getEnclosingRectangle", "()[I", "")]
		public unsafe int[]? GetEnclosingRectangle ()
		{
			const string __id = "getEnclosingRectangle.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray']]"
		[Register ("getRow", "(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;", "")]
		public unsafe global::Com.Google.Zxing.Common.BitArray? GetRow (int y, global::Com.Google.Zxing.Common.BitArray? row)
		{
			const string __id = "getRow.(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (y);
				__args [1] = new JniArgumentValue ((row == null) ? IntPtr.Zero : ((global::Java.Lang.Object) row).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (row);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getTopLeftOnBit' and count(parameter)=0]"
		[Register ("getTopLeftOnBit", "()[I", "")]
		public unsafe int[]? GetTopLeftOnBit ()
		{
			const string __id = "getTopLeftOnBit.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='parse' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/google/zxing/common/BitMatrix;", "")]
		public static unsafe global::Com.Google.Zxing.Common.BitMatrix? Parse (string? stringRepresentation, string? setString, string? unsetString)
		{
			const string __id = "parse.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/google/zxing/common/BitMatrix;";
			IntPtr native_stringRepresentation = JNIEnv.NewString ((string?)stringRepresentation);
			IntPtr native_setString = JNIEnv.NewString ((string?)setString);
			IntPtr native_unsetString = JNIEnv.NewString ((string?)unsetString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_stringRepresentation);
				__args [1] = new JniArgumentValue (native_setString);
				__args [2] = new JniArgumentValue (native_unsetString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRepresentation);
				JNIEnv.DeleteLocalRef (native_setString);
				JNIEnv.DeleteLocalRef (native_unsetString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='rotate180' and count(parameter)=0]"
		[Register ("rotate180", "()V", "")]
		public unsafe void Rotate180 ()
		{
			const string __id = "rotate180.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("set", "(II)V", "")]
		public unsafe void Set (int x, int y)
		{
			const string __id = "set.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='setRegion' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setRegion", "(IIII)V", "")]
		public unsafe void SetRegion (int left, int top, int width, int height)
		{
			const string __id = "setRegion.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='setRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray']]"
		[Register ("setRow", "(ILcom/google/zxing/common/BitArray;)V", "")]
		public unsafe void SetRow (int y, global::Com.Google.Zxing.Common.BitArray? row)
		{
			const string __id = "setRow.(ILcom/google/zxing/common/BitArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (y);
				__args [1] = new JniArgumentValue ((row == null) ? IntPtr.Zero : ((global::Java.Lang.Object) row).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (row);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='toString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("toString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string? ToString (string? setString, string? unsetString)
		{
			const string __id = "toString.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_setString = JNIEnv.NewString ((string?)setString);
			IntPtr native_unsetString = JNIEnv.NewString ((string?)unsetString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_setString);
				__args [1] = new JniArgumentValue (native_unsetString);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_setString);
				JNIEnv.DeleteLocalRef (native_unsetString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='toString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("toString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string? ToString (string? setString, string? unsetString, string? lineSeparator)
		{
			const string __id = "toString.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_setString = JNIEnv.NewString ((string?)setString);
			IntPtr native_unsetString = JNIEnv.NewString ((string?)unsetString);
			IntPtr native_lineSeparator = JNIEnv.NewString ((string?)lineSeparator);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_setString);
				__args [1] = new JniArgumentValue (native_unsetString);
				__args [2] = new JniArgumentValue (native_lineSeparator);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_setString);
				JNIEnv.DeleteLocalRef (native_unsetString);
				JNIEnv.DeleteLocalRef (native_lineSeparator);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='unset' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("unset", "(II)V", "")]
		public unsafe void Unset (int x, int y)
		{
			const string __id = "unset.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='xor' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register ("xor", "(Lcom/google/zxing/common/BitMatrix;)V", "")]
		public unsafe void Xor (global::Com.Google.Zxing.Common.BitMatrix? mask)
		{
			const string __id = "xor.(Lcom/google/zxing/common/BitMatrix;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mask == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mask).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mask);
			}
		}

	}
}
