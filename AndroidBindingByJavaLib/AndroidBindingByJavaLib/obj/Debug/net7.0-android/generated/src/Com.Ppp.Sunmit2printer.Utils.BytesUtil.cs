using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ppp.Sunmit2printer.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']"
	[global::Android.Runtime.Register ("com/ppp/sunmit2printer/utils/BytesUtil", DoNotGenerateAcw=true)]
	public partial class BytesUtil : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ppp/sunmit2printer/utils/BytesUtil", typeof (BytesUtil));

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

		protected BytesUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/constructor[@name='BytesUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BytesUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='byteMerger' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("byteMerger", "([B[B)[B", "")]
		public static unsafe byte[]? ByteMerger (byte[]? byte_1, byte[]? byte_2)
		{
			const string __id = "byteMerger.([B[B)[B";
			IntPtr native_byte_1 = JNIEnv.NewArray (byte_1);
			IntPtr native_byte_2 = JNIEnv.NewArray (byte_2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_byte_1);
				__args [1] = new JniArgumentValue (native_byte_2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (byte_1 != null) {
					JNIEnv.CopyArray (native_byte_1, byte_1);
					JNIEnv.DeleteLocalRef (native_byte_1);
				}
				if (byte_2 != null) {
					JNIEnv.CopyArray (native_byte_2, byte_2);
					JNIEnv.DeleteLocalRef (native_byte_2);
				}
				global::System.GC.KeepAlive (byte_1);
				global::System.GC.KeepAlive (byte_2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='byteMerger' and count(parameter)=1 and parameter[1][@type='byte[][]']]"
		[Register ("byteMerger", "([[B)[B", "")]
		public static unsafe byte[]? ByteMerger (byte[][]? byteList)
		{
			const string __id = "byteMerger.([[B)[B";
			IntPtr native_byteList = JNIEnv.NewArray (byteList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_byteList);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (byteList != null) {
					JNIEnv.CopyArray (native_byteList, byteList);
					JNIEnv.DeleteLocalRef (native_byteList);
				}
				global::System.GC.KeepAlive (byteList);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='customData' and count(parameter)=0]"
		[Register ("customData", "()[B", "")]
		public static unsafe byte[]? CustomData ()
		{
			const string __id = "customData.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='getBaiduTestBytes' and count(parameter)=0]"
		[Register ("getBaiduTestBytes", "()[B", "")]
		public static unsafe byte[]? GetBaiduTestBytes ()
		{
			const string __id = "getBaiduTestBytes.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='getBytesFromBitMap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("getBytesFromBitMap", "(Landroid/graphics/Bitmap;)[B", "")]
		public static unsafe byte[]? GetBytesFromBitMap (global::Android.Graphics.Bitmap? bitmap)
		{
			const string __id = "getBytesFromBitMap.(Landroid/graphics/Bitmap;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (bitmap);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='getBytesFromBitMap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("getBytesFromBitMap", "(Landroid/graphics/Bitmap;I)[B", "")]
		public static unsafe byte[]? GetBytesFromBitMap (global::Android.Graphics.Bitmap? bitmap, int mode)
		{
			const string __id = "getBytesFromBitMap.(Landroid/graphics/Bitmap;I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [1] = new JniArgumentValue (mode);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (bitmap);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='getBytesFromBitMatrix' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register ("getBytesFromBitMatrix", "(Lcom/google/zxing/common/BitMatrix;)[B", "")]
		public static unsafe byte[]? GetBytesFromBitMatrix (global::Com.Google.Zxing.Common.BitMatrix? bits)
		{
			const string __id = "getBytesFromBitMatrix.(Lcom/google/zxing/common/BitMatrix;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bits == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bits).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (bits);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='getBytesFromDecString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesFromDecString", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[]? GetBytesFromDecString (string? decstring)
		{
			const string __id = "getBytesFromDecString.(Ljava/lang/String;)[B";
			IntPtr native_decstring = JNIEnv.NewString ((string?)decstring);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_decstring);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_decstring);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='getBytesFromHexString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesFromHexString", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[]? GetBytesFromHexString (string? hexstring)
		{
			const string __id = "getBytesFromHexString.(Ljava/lang/String;)[B";
			IntPtr native_hexstring = JNIEnv.NewString ((string?)hexstring);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hexstring);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_hexstring);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='getErlmoData' and count(parameter)=0]"
		[Register ("getErlmoData", "()[B", "")]
		public static unsafe byte[]? GetErlmoData ()
		{
			const string __id = "getErlmoData.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='getHexStringFromBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getHexStringFromBytes", "([B)Ljava/lang/String;", "")]
		public static unsafe string? GetHexStringFromBytes (byte[]? data)
		{
			const string __id = "getHexStringFromBytes.([B)Ljava/lang/String;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='getKoubeiData' and count(parameter)=0]"
		[Register ("getKoubeiData", "()[B", "")]
		public static unsafe byte[]? GetKoubeiData ()
		{
			const string __id = "getKoubeiData.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='getMeituanBill' and count(parameter)=0]"
		[Register ("getMeituanBill", "()[B", "")]
		public static unsafe byte[]? GetMeituanBill ()
		{
			const string __id = "getMeituanBill.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='getZXingQRCode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getZXingQRCode", "(Ljava/lang/String;I)[B", "")]
		public static unsafe byte[]? GetZXingQRCode (string? data, int size)
		{
			const string __id = "getZXingQRCode.(Ljava/lang/String;I)[B";
			IntPtr native_data = JNIEnv.NewString ((string?)data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (size);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='initBlackBlock' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("initBlackBlock", "(I)[B", "")]
		public static unsafe byte[]? InitBlackBlock (int w)
		{
			const string __id = "initBlackBlock.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (w);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='initBlackBlock' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("initBlackBlock", "(II)[B", "")]
		public static unsafe byte[]? InitBlackBlock (int h, int w)
		{
			const string __id = "initBlackBlock.(II)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (h);
				__args [1] = new JniArgumentValue (w);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='initTable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("initTable", "(II)[B", "")]
		public static unsafe byte[]? InitTable (int h, int w)
		{
			const string __id = "initTable.(II)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (h);
				__args [1] = new JniArgumentValue (w);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='BytesUtil']/method[@name='wordData' and count(parameter)=0]"
		[Register ("wordData", "()[B", "")]
		public static unsafe byte[]? WordData ()
		{
			const string __id = "wordData.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
