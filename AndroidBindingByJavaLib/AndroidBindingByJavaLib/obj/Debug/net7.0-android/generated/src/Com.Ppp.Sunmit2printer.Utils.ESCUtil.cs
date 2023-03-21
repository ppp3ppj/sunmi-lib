using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ppp.Sunmit2printer.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']"
	[global::Android.Runtime.Register ("com/ppp/sunmit2printer/utils/ESCUtil", DoNotGenerateAcw=true)]
	public partial class ESCUtil : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/field[@name='CAN']"
		[Register ("CAN")]
		public const sbyte Can = (sbyte) 24;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/field[@name='CR']"
		[Register ("CR")]
		public const sbyte Cr = (sbyte) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/field[@name='DLE']"
		[Register ("DLE")]
		public const sbyte Dle = (sbyte) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/field[@name='ENQ']"
		[Register ("ENQ")]
		public const sbyte Enq = (sbyte) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/field[@name='EOT']"
		[Register ("EOT")]
		public const sbyte Eot = (sbyte) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/field[@name='ESC']"
		[Register ("ESC")]
		public const sbyte Esc = (sbyte) 27;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/field[@name='FF']"
		[Register ("FF")]
		public const sbyte Ff = (sbyte) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/field[@name='FS']"
		[Register ("FS")]
		public const sbyte Fs = (sbyte) 28;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/field[@name='GS']"
		[Register ("GS")]
		public const sbyte Gs = (sbyte) 29;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/field[@name='HT']"
		[Register ("HT")]
		public const sbyte Ht = (sbyte) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/field[@name='LF']"
		[Register ("LF")]
		public const sbyte Lf = (sbyte) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/field[@name='SP']"
		[Register ("SP")]
		public const sbyte Sp = (sbyte) 32;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ppp/sunmit2printer/utils/ESCUtil", typeof (ESCUtil));

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

		protected ESCUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/constructor[@name='ESCUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ESCUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='alignCenter' and count(parameter)=0]"
		[Register ("alignCenter", "()[B", "")]
		public static unsafe byte[]? AlignCenter ()
		{
			const string __id = "alignCenter.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='alignLeft' and count(parameter)=0]"
		[Register ("alignLeft", "()[B", "")]
		public static unsafe byte[]? AlignLeft ()
		{
			const string __id = "alignLeft.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='alignRight' and count(parameter)=0]"
		[Register ("alignRight", "()[B", "")]
		public static unsafe byte[]? AlignRight ()
		{
			const string __id = "alignRight.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='boldOff' and count(parameter)=0]"
		[Register ("boldOff", "()[B", "")]
		public static unsafe byte[]? BoldOff ()
		{
			const string __id = "boldOff.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='boldOn' and count(parameter)=0]"
		[Register ("boldOn", "()[B", "")]
		public static unsafe byte[]? BoldOn ()
		{
			const string __id = "boldOn.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='cutter' and count(parameter)=0]"
		[Register ("cutter", "()[B", "")]
		public static unsafe byte[]? Cutter ()
		{
			const string __id = "cutter.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='getPrintBarCode' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("getPrintBarCode", "(Ljava/lang/String;IIII)[B", "")]
		public static unsafe byte[]? GetPrintBarCode (string? data, int symbology, int height, int width, int textposition)
		{
			const string __id = "getPrintBarCode.(Ljava/lang/String;IIII)[B";
			IntPtr native_data = JNIEnv.NewString ((string?)data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (symbology);
				__args [2] = new JniArgumentValue (height);
				__args [3] = new JniArgumentValue (width);
				__args [4] = new JniArgumentValue (textposition);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='getPrintDoubleQRCode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("getPrintDoubleQRCode", "(Ljava/lang/String;Ljava/lang/String;II)[B", "")]
		public static unsafe byte[]? GetPrintDoubleQRCode (string? code1, string? code2, int modulesize, int errorlevel)
		{
			const string __id = "getPrintDoubleQRCode.(Ljava/lang/String;Ljava/lang/String;II)[B";
			IntPtr native_code1 = JNIEnv.NewString ((string?)code1);
			IntPtr native_code2 = JNIEnv.NewString ((string?)code2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_code1);
				__args [1] = new JniArgumentValue (native_code2);
				__args [2] = new JniArgumentValue (modulesize);
				__args [3] = new JniArgumentValue (errorlevel);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_code1);
				JNIEnv.DeleteLocalRef (native_code2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='getPrintQRCode' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getPrintQRCode", "(Ljava/lang/String;II)[B", "")]
		public static unsafe byte[]? GetPrintQRCode (string? code, int modulesize, int errorlevel)
		{
			const string __id = "getPrintQRCode.(Ljava/lang/String;II)[B";
			IntPtr native_code = JNIEnv.NewString ((string?)code);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_code);
				__args [1] = new JniArgumentValue (modulesize);
				__args [2] = new JniArgumentValue (errorlevel);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_code);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='getPrintQRCode2' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getPrintQRCode2", "(Ljava/lang/String;I)[B", "")]
		public static unsafe byte[]? GetPrintQRCode2 (string? data, int size)
		{
			const string __id = "getPrintQRCode2.(Ljava/lang/String;I)[B";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='gogogo' and count(parameter)=0]"
		[Register ("gogogo", "()[B", "")]
		public static unsafe byte[]? Gogogo ()
		{
			const string __id = "gogogo.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='init_printer' and count(parameter)=0]"
		[Register ("init_printer", "()[B", "")]
		public static unsafe byte[]? Init_printer ()
		{
			const string __id = "init_printer.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='nextLine' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("nextLine", "(I)[B", "")]
		public static unsafe byte[]? NextLine (int lineNum)
		{
			const string __id = "nextLine.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (lineNum);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='printBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("printBitmap", "(Landroid/graphics/Bitmap;)[B", "")]
		public static unsafe byte[]? PrintBitmap (global::Android.Graphics.Bitmap? bitmap)
		{
			const string __id = "printBitmap.(Landroid/graphics/Bitmap;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (bitmap);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='printBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("printBitmap", "(Landroid/graphics/Bitmap;I)[B", "")]
		public static unsafe byte[]? PrintBitmap (global::Android.Graphics.Bitmap? bitmap, int mode)
		{
			const string __id = "printBitmap.(Landroid/graphics/Bitmap;I)[B";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='printBitmap' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("printBitmap", "([B)[B", "")]
		public static unsafe byte[]? PrintBitmap (byte[]? bytes)
		{
			const string __id = "printBitmap.([B)[B";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='selectBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("selectBitmap", "(Landroid/graphics/Bitmap;I)[B", "")]
		public static unsafe byte[]? SelectBitmap (global::Android.Graphics.Bitmap? bitmap, int mode)
		{
			const string __id = "selectBitmap.(Landroid/graphics/Bitmap;I)[B";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='setCodeSystem' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("setCodeSystem", "(B)[B", "")]
		public static unsafe byte[]? SetCodeSystem (sbyte charset)
		{
			const string __id = "setCodeSystem.(B)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (charset);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='setCodeSystemSingle' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("setCodeSystemSingle", "(B)[B", "")]
		public static unsafe byte[]? SetCodeSystemSingle (sbyte charset)
		{
			const string __id = "setCodeSystemSingle.(B)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (charset);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='setDefaultLineSpace' and count(parameter)=0]"
		[Register ("setDefaultLineSpace", "()[B", "")]
		public static unsafe byte[]? SetDefaultLineSpace ()
		{
			const string __id = "setDefaultLineSpace.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='setLineSpace' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLineSpace", "(I)[B", "")]
		public static unsafe byte[]? SetLineSpace (int height)
		{
			const string __id = "setLineSpace.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (height);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='setPrinterDarkness' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPrinterDarkness", "(I)[B", "")]
		public static unsafe byte[]? SetPrinterDarkness (int value)
		{
			const string __id = "setPrinterDarkness.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='singleByte' and count(parameter)=0]"
		[Register ("singleByte", "()[B", "")]
		public static unsafe byte[]? SingleByte ()
		{
			const string __id = "singleByte.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='singleByteOff' and count(parameter)=0]"
		[Register ("singleByteOff", "()[B", "")]
		public static unsafe byte[]? SingleByteOff ()
		{
			const string __id = "singleByteOff.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='underlineOff' and count(parameter)=0]"
		[Register ("underlineOff", "()[B", "")]
		public static unsafe byte[]? UnderlineOff ()
		{
			const string __id = "underlineOff.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='underlineWithOneDotWidthOn' and count(parameter)=0]"
		[Register ("underlineWithOneDotWidthOn", "()[B", "")]
		public static unsafe byte[]? UnderlineWithOneDotWidthOn ()
		{
			const string __id = "underlineWithOneDotWidthOn.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='ESCUtil']/method[@name='underlineWithTwoDotWidthOn' and count(parameter)=0]"
		[Register ("underlineWithTwoDotWidthOn", "()[B", "")]
		public static unsafe byte[]? UnderlineWithTwoDotWidthOn ()
		{
			const string __id = "underlineWithTwoDotWidthOn.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
