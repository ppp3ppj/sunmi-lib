using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ppp.Sunmit2printer.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']"
	[global::Android.Runtime.Register ("com/ppp/sunmit2printer/utils/SunmiPrintHelper", DoNotGenerateAcw=true)]
	public partial class SunmiPrintHelper : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/field[@name='CheckSunmiPrinter']"
		[Register ("CheckSunmiPrinter")]
		public static int CheckSunmiPrinter {
			get {
				const string __id = "CheckSunmiPrinter.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "CheckSunmiPrinter.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/field[@name='FoundSunmiPrinter']"
		[Register ("FoundSunmiPrinter")]
		public static int FoundSunmiPrinter {
			get {
				const string __id = "FoundSunmiPrinter.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "FoundSunmiPrinter.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/field[@name='LostSunmiPrinter']"
		[Register ("LostSunmiPrinter")]
		public static int LostSunmiPrinter {
			get {
				const string __id = "LostSunmiPrinter.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "LostSunmiPrinter.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/field[@name='NoSunmiPrinter']"
		[Register ("NoSunmiPrinter")]
		public static int NoSunmiPrinter {
			get {
				const string __id = "NoSunmiPrinter.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "NoSunmiPrinter.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/field[@name='sunmiPrinter']"
		[Register ("sunmiPrinter")]
		public int SunmiPrinter {
			get {
				const string __id = "sunmiPrinter.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "sunmiPrinter.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ppp/sunmit2printer/utils/SunmiPrintHelper", typeof (SunmiPrintHelper));

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

		protected SunmiPrintHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getDeviceModel;
#pragma warning disable 0169
		static Delegate GetGetDeviceModelHandler ()
		{
			if (cb_getDeviceModel == null)
				cb_getDeviceModel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceModel);
			return cb_getDeviceModel;
		}

		static IntPtr n_GetDeviceModel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DeviceModel);
		}
#pragma warning restore 0169

		public virtual unsafe string? DeviceModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='getDeviceModel' and count(parameter)=0]"
			[Register ("getDeviceModel", "()Ljava/lang/String;", "GetGetDeviceModelHandler")]
			get {
				const string __id = "getDeviceModel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper? Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/ppp/sunmit2printer/utils/SunmiPrintHelper;", "")]
			get {
				const string __id = "getInstance.()Lcom/ppp/sunmit2printer/utils/SunmiPrintHelper;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_isBlackLabelMode;
#pragma warning disable 0169
		static Delegate GetIsBlackLabelModeHandler ()
		{
			if (cb_isBlackLabelMode == null)
				cb_isBlackLabelMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsBlackLabelMode);
			return cb_isBlackLabelMode;
		}

		static bool n_IsBlackLabelMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsBlackLabelMode;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsBlackLabelMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='isBlackLabelMode' and count(parameter)=0]"
			[Register ("isBlackLabelMode", "()Z", "GetIsBlackLabelModeHandler")]
			get {
				const string __id = "isBlackLabelMode.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isLabelMode;
#pragma warning disable 0169
		static Delegate GetIsLabelModeHandler ()
		{
			if (cb_isLabelMode == null)
				cb_isLabelMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLabelMode);
			return cb_isLabelMode;
		}

		static bool n_IsLabelMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsLabelMode;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLabelMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='isLabelMode' and count(parameter)=0]"
			[Register ("isLabelMode", "()Z", "GetIsLabelModeHandler")]
			get {
				const string __id = "isLabelMode.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getPrinterPaper;
#pragma warning disable 0169
		static Delegate GetGetPrinterPaperHandler ()
		{
			if (cb_getPrinterPaper == null)
				cb_getPrinterPaper = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrinterPaper);
			return cb_getPrinterPaper;
		}

		static IntPtr n_GetPrinterPaper (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.PrinterPaper);
		}
#pragma warning restore 0169

		public virtual unsafe string? PrinterPaper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='getPrinterPaper' and count(parameter)=0]"
			[Register ("getPrinterPaper", "()Ljava/lang/String;", "GetGetPrinterPaperHandler")]
			get {
				const string __id = "getPrinterPaper.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getPrinterSerialNo;
#pragma warning disable 0169
		static Delegate GetGetPrinterSerialNoHandler ()
		{
			if (cb_getPrinterSerialNo == null)
				cb_getPrinterSerialNo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrinterSerialNo);
			return cb_getPrinterSerialNo;
		}

		static IntPtr n_GetPrinterSerialNo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.PrinterSerialNo);
		}
#pragma warning restore 0169

		public virtual unsafe string? PrinterSerialNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='getPrinterSerialNo' and count(parameter)=0]"
			[Register ("getPrinterSerialNo", "()Ljava/lang/String;", "GetGetPrinterSerialNoHandler")]
			get {
				const string __id = "getPrinterSerialNo.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getPrinterVersion;
#pragma warning disable 0169
		static Delegate GetGetPrinterVersionHandler ()
		{
			if (cb_getPrinterVersion == null)
				cb_getPrinterVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrinterVersion);
			return cb_getPrinterVersion;
		}

		static IntPtr n_GetPrinterVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.PrinterVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string? PrinterVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='getPrinterVersion' and count(parameter)=0]"
			[Register ("getPrinterVersion", "()Ljava/lang/String;", "GetGetPrinterVersionHandler")]
			get {
				const string __id = "getPrinterVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_controlLcd_I;
#pragma warning disable 0169
		static Delegate GetControlLcd_IHandler ()
		{
			if (cb_controlLcd_I == null)
				cb_controlLcd_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_ControlLcd_I);
			return cb_controlLcd_I;
		}

		static void n_ControlLcd_I (IntPtr jnienv, IntPtr native__this, int flag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.ControlLcd (flag);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='controlLcd' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("controlLcd", "(I)V", "GetControlLcd_IHandler")]
		public virtual unsafe void ControlLcd (int flag)
		{
			const string __id = "controlLcd.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flag);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_cutpaper;
#pragma warning disable 0169
		static Delegate GetCutpaperHandler ()
		{
			if (cb_cutpaper == null)
				cb_cutpaper = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Cutpaper);
			return cb_cutpaper;
		}

		static void n_Cutpaper (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Cutpaper ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='cutpaper' and count(parameter)=0]"
		[Register ("cutpaper", "()V", "GetCutpaperHandler")]
		public virtual unsafe void Cutpaper ()
		{
			const string __id = "cutpaper.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_deInitSunmiPrinterService_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetDeInitSunmiPrinterService_Landroid_content_Context_Handler ()
		{
			if (cb_deInitSunmiPrinterService_Landroid_content_Context_ == null)
				cb_deInitSunmiPrinterService_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DeInitSunmiPrinterService_Landroid_content_Context_);
			return cb_deInitSunmiPrinterService_Landroid_content_Context_;
		}

		static void n_DeInitSunmiPrinterService_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.DeInitSunmiPrinterService (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='deInitSunmiPrinterService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("deInitSunmiPrinterService", "(Landroid/content/Context;)V", "GetDeInitSunmiPrinterService_Landroid_content_Context_Handler")]
		public virtual unsafe void DeInitSunmiPrinterService (global::Android.Content.Context? context)
		{
			const string __id = "deInitSunmiPrinterService.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate? cb_feedPaper;
#pragma warning disable 0169
		static Delegate GetFeedPaperHandler ()
		{
			if (cb_feedPaper == null)
				cb_feedPaper = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FeedPaper);
			return cb_feedPaper;
		}

		static void n_FeedPaper (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.FeedPaper ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='feedPaper' and count(parameter)=0]"
		[Register ("feedPaper", "()V", "GetFeedPaperHandler")]
		public virtual unsafe void FeedPaper ()
		{
			const string __id = "feedPaper.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_initPrinter;
#pragma warning disable 0169
		static Delegate GetInitPrinterHandler ()
		{
			if (cb_initPrinter == null)
				cb_initPrinter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_InitPrinter);
			return cb_initPrinter;
		}

		static void n_InitPrinter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.InitPrinter ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='initPrinter' and count(parameter)=0]"
		[Register ("initPrinter", "()V", "GetInitPrinterHandler")]
		public virtual unsafe void InitPrinter ()
		{
			const string __id = "initPrinter.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_initSunmiPrinterService_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInitSunmiPrinterService_Landroid_content_Context_Handler ()
		{
			if (cb_initSunmiPrinterService_Landroid_content_Context_ == null)
				cb_initSunmiPrinterService_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InitSunmiPrinterService_Landroid_content_Context_);
			return cb_initSunmiPrinterService_Landroid_content_Context_;
		}

		static void n_InitSunmiPrinterService_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.InitSunmiPrinterService (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='initSunmiPrinterService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initSunmiPrinterService", "(Landroid/content/Context;)V", "GetInitSunmiPrinterService_Landroid_content_Context_Handler")]
		public virtual unsafe void InitSunmiPrinterService (global::Android.Content.Context? context)
		{
			const string __id = "initSunmiPrinterService.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate? cb_openCashBox;
#pragma warning disable 0169
		static Delegate GetOpenCashBoxHandler ()
		{
			if (cb_openCashBox == null)
				cb_openCashBox = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OpenCashBox);
			return cb_openCashBox;
		}

		static void n_OpenCashBox (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OpenCashBox ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='openCashBox' and count(parameter)=0]"
		[Register ("openCashBox", "()V", "GetOpenCashBoxHandler")]
		public virtual unsafe void OpenCashBox ()
		{
			const string __id = "openCashBox.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_print3Line;
#pragma warning disable 0169
		static Delegate GetPrint3LineHandler ()
		{
			if (cb_print3Line == null)
				cb_print3Line = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Print3Line);
			return cb_print3Line;
		}

		static void n_Print3Line (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Print3Line ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='print3Line' and count(parameter)=0]"
		[Register ("print3Line", "()V", "GetPrint3LineHandler")]
		public virtual unsafe void Print3Line ()
		{
			const string __id = "print3Line.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_printBarCode_Ljava_lang_String_IIII;
#pragma warning disable 0169
		static Delegate GetPrintBarCode_Ljava_lang_String_IIIIHandler ()
		{
			if (cb_printBarCode_Ljava_lang_String_IIII == null)
				cb_printBarCode_Ljava_lang_String_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIII_V) n_PrintBarCode_Ljava_lang_String_IIII);
			return cb_printBarCode_Ljava_lang_String_IIII;
		}

		static void n_PrintBarCode_Ljava_lang_String_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int symbology, int height, int width, int textposition)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var data = JNIEnv.GetString (native_data, JniHandleOwnership.DoNotTransfer);
			__this.PrintBarCode (data, symbology, height, width, textposition);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='printBarCode' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("printBarCode", "(Ljava/lang/String;IIII)V", "GetPrintBarCode_Ljava_lang_String_IIIIHandler")]
		public virtual unsafe void PrintBarCode (string? data, int symbology, int height, int width, int textposition)
		{
			const string __id = "printBarCode.(Ljava/lang/String;IIII)V";
			IntPtr native_data = JNIEnv.NewString ((string?)data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (symbology);
				__args [2] = new JniArgumentValue (height);
				__args [3] = new JniArgumentValue (width);
				__args [4] = new JniArgumentValue (textposition);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static Delegate? cb_printBitmap_Landroid_graphics_Bitmap_I;
#pragma warning disable 0169
		static Delegate GetPrintBitmap_Landroid_graphics_Bitmap_IHandler ()
		{
			if (cb_printBitmap_Landroid_graphics_Bitmap_I == null)
				cb_printBitmap_Landroid_graphics_Bitmap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_PrintBitmap_Landroid_graphics_Bitmap_I);
			return cb_printBitmap_Landroid_graphics_Bitmap_I;
		}

		static void n_PrintBitmap_Landroid_graphics_Bitmap_I (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap, int orientation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmap (bitmap, orientation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='printBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("printBitmap", "(Landroid/graphics/Bitmap;I)V", "GetPrintBitmap_Landroid_graphics_Bitmap_IHandler")]
		public virtual unsafe void PrintBitmap (global::Android.Graphics.Bitmap? bitmap, int orientation)
		{
			const string __id = "printBitmap.(Landroid/graphics/Bitmap;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [1] = new JniArgumentValue (orientation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bitmap);
			}
		}

		static Delegate? cb_printBitmapBase64_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPrintBitmapBase64_Ljava_lang_String_IHandler ()
		{
			if (cb_printBitmapBase64_Ljava_lang_String_I == null)
				cb_printBitmapBase64_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_PrintBitmapBase64_Ljava_lang_String_I);
			return cb_printBitmapBase64_Ljava_lang_String_I;
		}

		static void n_PrintBitmapBase64_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_base64String, int orientation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var base64String = JNIEnv.GetString (native_base64String, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmapBase64 (base64String, orientation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='printBitmapBase64' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("printBitmapBase64", "(Ljava/lang/String;I)V", "GetPrintBitmapBase64_Ljava_lang_String_IHandler")]
		public virtual unsafe void PrintBitmapBase64 (string? base64String, int orientation)
		{
			const string __id = "printBitmapBase64.(Ljava/lang/String;I)V";
			IntPtr native_base64String = JNIEnv.NewString ((string?)base64String);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_base64String);
				__args [1] = new JniArgumentValue (orientation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_base64String);
			}
		}

		static Delegate? cb_printBitmapCustomGrayScaleBase64_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPrintBitmapCustomGrayScaleBase64_Ljava_lang_String_IHandler ()
		{
			if (cb_printBitmapCustomGrayScaleBase64_Ljava_lang_String_I == null)
				cb_printBitmapCustomGrayScaleBase64_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_PrintBitmapCustomGrayScaleBase64_Ljava_lang_String_I);
			return cb_printBitmapCustomGrayScaleBase64_Ljava_lang_String_I;
		}

		static void n_PrintBitmapCustomGrayScaleBase64_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_base64String, int orientation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var base64String = JNIEnv.GetString (native_base64String, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmapCustomGrayScaleBase64 (base64String, orientation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='printBitmapCustomGrayScaleBase64' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("printBitmapCustomGrayScaleBase64", "(Ljava/lang/String;I)V", "GetPrintBitmapCustomGrayScaleBase64_Ljava_lang_String_IHandler")]
		public virtual unsafe void PrintBitmapCustomGrayScaleBase64 (string? base64String, int orientation)
		{
			const string __id = "printBitmapCustomGrayScaleBase64.(Ljava/lang/String;I)V";
			IntPtr native_base64String = JNIEnv.NewString ((string?)base64String);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_base64String);
				__args [1] = new JniArgumentValue (orientation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_base64String);
			}
		}

		static Delegate? cb_printExampleWithBitMap_Landroid_content_Context_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetPrintExampleWithBitMap_Landroid_content_Context_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_printExampleWithBitMap_Landroid_content_Context_Landroid_graphics_Bitmap_ == null)
				cb_printExampleWithBitMap_Landroid_content_Context_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintExampleWithBitMap_Landroid_content_Context_Landroid_graphics_Bitmap_);
			return cb_printExampleWithBitMap_Landroid_content_Context_Landroid_graphics_Bitmap_;
		}

		static void n_PrintExampleWithBitMap_Landroid_content_Context_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_bitmap)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.PrintExampleWithBitMap (context, bitmap);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='printExampleWithBitMap' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("printExampleWithBitMap", "(Landroid/content/Context;Landroid/graphics/Bitmap;)V", "GetPrintExampleWithBitMap_Landroid_content_Context_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void PrintExampleWithBitMap (global::Android.Content.Context? context, global::Android.Graphics.Bitmap? bitmap)
		{
			const string __id = "printExampleWithBitMap.(Landroid/content/Context;Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (bitmap);
			}
		}

		static Delegate? cb_printMultiLabel_I;
#pragma warning disable 0169
		static Delegate GetPrintMultiLabel_IHandler ()
		{
			if (cb_printMultiLabel_I == null)
				cb_printMultiLabel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_PrintMultiLabel_I);
			return cb_printMultiLabel_I;
		}

		static void n_PrintMultiLabel_I (IntPtr jnienv, IntPtr native__this, int num)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrintMultiLabel (num);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='printMultiLabel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("printMultiLabel", "(I)V", "GetPrintMultiLabel_IHandler")]
		public virtual unsafe void PrintMultiLabel (int num)
		{
			const string __id = "printMultiLabel.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (num);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_printOneLabel;
#pragma warning disable 0169
		static Delegate GetPrintOneLabelHandler ()
		{
			if (cb_printOneLabel == null)
				cb_printOneLabel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PrintOneLabel);
			return cb_printOneLabel;
		}

		static void n_PrintOneLabel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PrintOneLabel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='printOneLabel' and count(parameter)=0]"
		[Register ("printOneLabel", "()V", "GetPrintOneLabelHandler")]
		public virtual unsafe void PrintOneLabel ()
		{
			const string __id = "printOneLabel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_printQr_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetPrintQr_Ljava_lang_String_IIHandler ()
		{
			if (cb_printQr_Ljava_lang_String_II == null)
				cb_printQr_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_PrintQr_Ljava_lang_String_II);
			return cb_printQr_Ljava_lang_String_II;
		}

		static void n_PrintQr_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int modulesize, int errorlevel)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var data = JNIEnv.GetString (native_data, JniHandleOwnership.DoNotTransfer);
			__this.PrintQr (data, modulesize, errorlevel);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='printQr' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("printQr", "(Ljava/lang/String;II)V", "GetPrintQr_Ljava_lang_String_IIHandler")]
		public virtual unsafe void PrintQr (string? data, int modulesize, int errorlevel)
		{
			const string __id = "printQr.(Ljava/lang/String;II)V";
			IntPtr native_data = JNIEnv.NewString ((string?)data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (modulesize);
				__args [2] = new JniArgumentValue (errorlevel);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static Delegate? cb_printTable_arrayLjava_lang_String_arrayIarrayI;
#pragma warning disable 0169
		static Delegate GetPrintTable_arrayLjava_lang_String_arrayIarrayIHandler ()
		{
			if (cb_printTable_arrayLjava_lang_String_arrayIarrayI == null)
				cb_printTable_arrayLjava_lang_String_arrayIarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PrintTable_arrayLjava_lang_String_arrayIarrayI);
			return cb_printTable_arrayLjava_lang_String_arrayIarrayI;
		}

		static void n_PrintTable_arrayLjava_lang_String_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_txts, IntPtr native_width, IntPtr native_align)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var txts = (string[]?) JNIEnv.GetArray (native_txts, JniHandleOwnership.DoNotTransfer, typeof (string));
			var width = (int[]?) JNIEnv.GetArray (native_width, JniHandleOwnership.DoNotTransfer, typeof (int));
			var align = (int[]?) JNIEnv.GetArray (native_align, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.PrintTable (txts, width, align);
			if (txts != null)
				JNIEnv.CopyArray (txts, native_txts);
			if (width != null)
				JNIEnv.CopyArray (width, native_width);
			if (align != null)
				JNIEnv.CopyArray (align, native_align);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='printTable' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]']]"
		[Register ("printTable", "([Ljava/lang/String;[I[I)V", "GetPrintTable_arrayLjava_lang_String_arrayIarrayIHandler")]
		public virtual unsafe void PrintTable (string[]? txts, int[]? width, int[]? align)
		{
			const string __id = "printTable.([Ljava/lang/String;[I[I)V";
			IntPtr native_txts = JNIEnv.NewArray (txts);
			IntPtr native_width = JNIEnv.NewArray (width);
			IntPtr native_align = JNIEnv.NewArray (align);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_txts);
				__args [1] = new JniArgumentValue (native_width);
				__args [2] = new JniArgumentValue (native_align);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (txts != null) {
					JNIEnv.CopyArray (native_txts, txts);
					JNIEnv.DeleteLocalRef (native_txts);
				}
				if (width != null) {
					JNIEnv.CopyArray (native_width, width);
					JNIEnv.DeleteLocalRef (native_width);
				}
				if (align != null) {
					JNIEnv.CopyArray (native_align, align);
					JNIEnv.DeleteLocalRef (native_align);
				}
				global::System.GC.KeepAlive (txts);
				global::System.GC.KeepAlive (width);
				global::System.GC.KeepAlive (align);
			}
		}

		static Delegate? cb_printText_Ljava_lang_String_FZZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrintText_Ljava_lang_String_FZZLjava_lang_String_Handler ()
		{
			if (cb_printText_Ljava_lang_String_FZZLjava_lang_String_ == null)
				cb_printText_Ljava_lang_String_FZZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLFZZL_V) n_PrintText_Ljava_lang_String_FZZLjava_lang_String_);
			return cb_printText_Ljava_lang_String_FZZLjava_lang_String_;
		}

		static void n_PrintText_Ljava_lang_String_FZZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_content, float size, bool isBold, bool isUnderLine, IntPtr native_typeface)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var content = JNIEnv.GetString (native_content, JniHandleOwnership.DoNotTransfer);
			var typeface = JNIEnv.GetString (native_typeface, JniHandleOwnership.DoNotTransfer);
			__this.PrintText (content, size, isBold, isUnderLine, typeface);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='printText' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String']]"
		[Register ("printText", "(Ljava/lang/String;FZZLjava/lang/String;)V", "GetPrintText_Ljava_lang_String_FZZLjava_lang_String_Handler")]
		public virtual unsafe void PrintText (string? content, float size, bool isBold, bool isUnderLine, string? typeface)
		{
			const string __id = "printText.(Ljava/lang/String;FZZLjava/lang/String;)V";
			IntPtr native_content = JNIEnv.NewString ((string?)content);
			IntPtr native_typeface = JNIEnv.NewString ((string?)typeface);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_content);
				__args [1] = new JniArgumentValue (size);
				__args [2] = new JniArgumentValue (isBold);
				__args [3] = new JniArgumentValue (isUnderLine);
				__args [4] = new JniArgumentValue (native_typeface);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_content);
				JNIEnv.DeleteLocalRef (native_typeface);
			}
		}

		static Delegate? cb_sendPicToLcd_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSendPicToLcd_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_sendPicToLcd_Landroid_graphics_Bitmap_ == null)
				cb_sendPicToLcd_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SendPicToLcd_Landroid_graphics_Bitmap_);
			return cb_sendPicToLcd_Landroid_graphics_Bitmap_;
		}

		static void n_SendPicToLcd_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pic)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var pic = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_pic, JniHandleOwnership.DoNotTransfer);
			__this.SendPicToLcd (pic);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='sendPicToLcd' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("sendPicToLcd", "(Landroid/graphics/Bitmap;)V", "GetSendPicToLcd_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SendPicToLcd (global::Android.Graphics.Bitmap? pic)
		{
			const string __id = "sendPicToLcd.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pic == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pic).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pic);
			}
		}

		static Delegate? cb_sendRawData_arrayB;
#pragma warning disable 0169
		static Delegate GetSendRawData_arrayBHandler ()
		{
			if (cb_sendRawData_arrayB == null)
				cb_sendRawData_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SendRawData_arrayB);
			return cb_sendRawData_arrayB;
		}

		static void n_SendRawData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SendRawData (data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='sendRawData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sendRawData", "([B)V", "GetSendRawData_arrayBHandler")]
		public virtual unsafe void SendRawData (byte[]? data)
		{
			const string __id = "sendRawData.([B)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate? cb_sendTextToLcd;
#pragma warning disable 0169
		static Delegate GetSendTextToLcdHandler ()
		{
			if (cb_sendTextToLcd == null)
				cb_sendTextToLcd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SendTextToLcd);
			return cb_sendTextToLcd;
		}

		static void n_SendTextToLcd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SendTextToLcd ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='sendTextToLcd' and count(parameter)=0]"
		[Register ("sendTextToLcd", "()V", "GetSendTextToLcdHandler")]
		public virtual unsafe void SendTextToLcd ()
		{
			const string __id = "sendTextToLcd.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_sendTextsToLcd;
#pragma warning disable 0169
		static Delegate GetSendTextsToLcdHandler ()
		{
			if (cb_sendTextsToLcd == null)
				cb_sendTextsToLcd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SendTextsToLcd);
			return cb_sendTextsToLcd;
		}

		static void n_SendTextsToLcd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SendTextsToLcd ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='sendTextsToLcd' and count(parameter)=0]"
		[Register ("sendTextsToLcd", "()V", "GetSendTextsToLcdHandler")]
		public virtual unsafe void SendTextsToLcd ()
		{
			const string __id = "sendTextsToLcd.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_setAlign_I;
#pragma warning disable 0169
		static Delegate GetSetAlign_IHandler ()
		{
			if (cb_setAlign_I == null)
				cb_setAlign_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAlign_I);
			return cb_setAlign_I;
		}

		static void n_SetAlign_I (IntPtr jnienv, IntPtr native__this, int align)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetAlign (align);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='setAlign' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAlign", "(I)V", "GetSetAlign_IHandler")]
		public virtual unsafe void SetAlign (int align)
		{
			const string __id = "setAlign.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (align);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_showPrinterStatus_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetShowPrinterStatus_Landroid_content_Context_Handler ()
		{
			if (cb_showPrinterStatus_Landroid_content_Context_ == null)
				cb_showPrinterStatus_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ShowPrinterStatus_Landroid_content_Context_);
			return cb_showPrinterStatus_Landroid_content_Context_;
		}

		static void n_ShowPrinterStatus_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.ShowPrinterStatus (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='showPrinterStatus' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("showPrinterStatus", "(Landroid/content/Context;)V", "GetShowPrinterStatus_Landroid_content_Context_Handler")]
		public virtual unsafe void ShowPrinterStatus (global::Android.Content.Context? context)
		{
			const string __id = "showPrinterStatus.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate? cb_sunmiLineWrap_I;
#pragma warning disable 0169
		static Delegate GetSunmiLineWrap_IHandler ()
		{
			if (cb_sunmiLineWrap_I == null)
				cb_sunmiLineWrap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SunmiLineWrap_I);
			return cb_sunmiLineWrap_I;
		}

		static void n_SunmiLineWrap_I (IntPtr jnienv, IntPtr native__this, int n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SunmiLineWrap (n);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='sunmiLineWrap' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sunmiLineWrap", "(I)V", "GetSunmiLineWrap_IHandler")]
		public virtual unsafe void SunmiLineWrap (int n)
		{
			const string __id = "sunmiLineWrap.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_sunmiPrintColumnsString_arrayLjava_lang_String_arrayIarrayI;
#pragma warning disable 0169
		static Delegate GetSunmiPrintColumnsString_arrayLjava_lang_String_arrayIarrayIHandler ()
		{
			if (cb_sunmiPrintColumnsString_arrayLjava_lang_String_arrayIarrayI == null)
				cb_sunmiPrintColumnsString_arrayLjava_lang_String_arrayIarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SunmiPrintColumnsString_arrayLjava_lang_String_arrayIarrayI);
			return cb_sunmiPrintColumnsString_arrayLjava_lang_String_arrayIarrayI;
		}

		static void n_SunmiPrintColumnsString_arrayLjava_lang_String_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_dataText, IntPtr native_width, IntPtr native_align)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ppp.Sunmit2printer.Utils.SunmiPrintHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var dataText = (string[]?) JNIEnv.GetArray (native_dataText, JniHandleOwnership.DoNotTransfer, typeof (string));
			var width = (int[]?) JNIEnv.GetArray (native_width, JniHandleOwnership.DoNotTransfer, typeof (int));
			var align = (int[]?) JNIEnv.GetArray (native_align, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SunmiPrintColumnsString (dataText, width, align);
			if (dataText != null)
				JNIEnv.CopyArray (dataText, native_dataText);
			if (width != null)
				JNIEnv.CopyArray (width, native_width);
			if (align != null)
				JNIEnv.CopyArray (align, native_align);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ppp.sunmit2printer.utils']/class[@name='SunmiPrintHelper']/method[@name='sunmiPrintColumnsString' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]']]"
		[Register ("sunmiPrintColumnsString", "([Ljava/lang/String;[I[I)V", "GetSunmiPrintColumnsString_arrayLjava_lang_String_arrayIarrayIHandler")]
		public virtual unsafe void SunmiPrintColumnsString (string[]? dataText, int[]? width, int[]? align)
		{
			const string __id = "sunmiPrintColumnsString.([Ljava/lang/String;[I[I)V";
			IntPtr native_dataText = JNIEnv.NewArray (dataText);
			IntPtr native_width = JNIEnv.NewArray (width);
			IntPtr native_align = JNIEnv.NewArray (align);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_dataText);
				__args [1] = new JniArgumentValue (native_width);
				__args [2] = new JniArgumentValue (native_align);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (dataText != null) {
					JNIEnv.CopyArray (native_dataText, dataText);
					JNIEnv.DeleteLocalRef (native_dataText);
				}
				if (width != null) {
					JNIEnv.CopyArray (native_width, width);
					JNIEnv.DeleteLocalRef (native_width);
				}
				if (align != null) {
					JNIEnv.CopyArray (native_align, align);
					JNIEnv.DeleteLocalRef (native_align);
				}
				global::System.GC.KeepAlive (dataText);
				global::System.GC.KeepAlive (width);
				global::System.GC.KeepAlive (align);
			}
		}

	}
}
